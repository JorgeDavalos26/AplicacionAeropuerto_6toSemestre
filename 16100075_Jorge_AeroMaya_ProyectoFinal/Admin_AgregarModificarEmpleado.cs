using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace _16100075_Jorge_AeroMaya_ProyectoFinal
{
    public partial class Admin_AgregarModificarEmpleado : Form
    {
        public Admin_AgregarModificarEmpleado(String _purpose, int _id_empleado)
        {
            InitializeComponent();

            purpose = _purpose;

            id_empleado = _id_empleado;
        }

        String purpose = "";
        int id_empleado;

        String stringConnection = "SERVER=localhost;" + "DATABASE=aeromayabd;" + "UID=root;" + "PASSWORD=;";

        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataReader reader;

        String query;

        String pue, nom, ape, corr, contra;

        double tel;
        
        /* CODIGO PARA QUE VENTANA SE PUEDA MOVER DE MANERA LIBRE */

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWind, int wMsg, int wParam, int lParam);

        private void Admin_AgregarModificarEmpleado_Load(object sender, EventArgs e)
        {
            if (purpose == "Modificar")
            {
                loadEmpleado();

                pue = cBPuesto.Text;
                nom = tBNombre.Text;
                ape = tBApellido.Text;
                tel = Convert.ToDouble(tBTelefono.Text);
                corr = tBCorreo.Text;
                contra = tBContrasena.Text;

                loadPuesto();

                cBPuesto.Text = pue;
            }
            else
            {
                loadPuesto();


            }


            this.Location = new Point(540, 290);
        }

        private void pSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pBCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void loadPuesto()
        {
            connection = new MySqlConnection(stringConnection);

            query = "SELECT Descripcion FROM Puesto";

            command = new MySqlCommand(query, connection);
            command.CommandTimeout = 60;

            connection.Open();
            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    cBPuesto.Items.Add(reader.GetString(0));
                }
            }
            else
            {
                MessageBox.Show(this, "No existen datos de este empleado",
                    "DATA NOT FOUND", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            connection.Close();
        }

        void loadEmpleado()
        {
            try
            {
                connection = new MySqlConnection(stringConnection);

                query = "SELECT Empleado.id_empleado, Puesto.Descripcion, Empleado.Nombre," +
                    " Empleado.Apellido, Empleado.Telefono, Empleado.Correo," +
                    " Empleado.Contrasena FROM Empleado" +
                    " INNER JOIN Puesto ON Puesto.id_puesto = Empleado.id_puesto" +
                    " WHERE Empleado.id_empleado = " + id_empleado;

                command = new MySqlCommand(query, connection);
                command.CommandTimeout = 60;

                connection.Open();
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        obtainDataPassenger();
                    }
                }
                else
                {
                    MessageBox.Show(this, "No existen datos de este empleado",
                        "DATA NOT FOUND", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Error en la Base de Datos",
                    "DATA BASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void obtainDataPassenger()
        {
            try
            {
                cBPuesto.Text = reader.GetString(1);
                tBNombre.Text = reader.GetString(2);
                tBApellido.Text = reader.GetString(3);
                tBTelefono.Text = reader.GetString(4);
                tBCorreo.Text = reader.GetString(5);
                tBContrasena.Text = reader.GetString(6);
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Error en la lectura de datos de empleado",
                    "DATA WORKER MISSING", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new MySqlConnection(stringConnection);

                if (purpose == "Modificar")
                {
                    errorProvider1.Clear();

                    if (tBNombre.Text != "" && tBApellido.Text != "")
                    {
                        if (ComprobarFormatoEmail(tBCorreo.Text))
                        {
                            if ((tBTelefono.Text.ToString()).Length >= 8 &&
                                (tBTelefono.Text.ToString()).Length <= 10)
                            {
                                if (tBContrasena.Text != "")
                                {
                                    if (cBPuesto.Text != "")
                                    {
                                        if (pue == cBPuesto.Text &&
                                        nom == tBNombre.Text &&
                                        ape == tBApellido.Text &&
                                        corr == tBCorreo.Text &&
                                        tel == Convert.ToDouble(tBTelefono.Text) &&
                                        contra == tBContrasena.Text)
                                        {

                                        }
                                        else
                                        {
                                            query = "UPDATE Empleado SET id_puesto =" +
                                                " (SELECT id_puesto FROM Puesto" +
                                                " WHERE Descripcion = '" + cBPuesto.Text + "')," +
                                                " Nombre = '" + tBNombre.Text + "'," +
                                                " Apellido = '" + tBApellido.Text + "'," +
                                                " Telefono = " + Convert.ToDouble(tBTelefono.Text) + "," +
                                                " Correo = '" + tBCorreo.Text + "'," +
                                                " Contrasena = '" + tBContrasena.Text + "'" +
                                                " WHERE id_empleado = " + id_empleado;

                                            command = new MySqlCommand(query, connection);
                                            command.CommandTimeout = 60;

                                            connection.Open();
                                            reader = command.ExecuteReader();

                                            connection.Close();

                                            MessageBox.Show("Datos de empleado se han modificado con exito");
                                        }

                                        this.Close();
                                    }
                                    else
                                    {
                                        errorProvider1.SetError(cBPuesto, "Ingresa un puesto para el empleado");
                                        throw new FormatException();
                                    }
                                }
                                else
                                {
                                    errorProvider1.SetError(tBContrasena, "Ingresa una contraseña valida");
                                    throw new FormatException();
                                }
                            }
                            else
                            {
                                errorProvider1.SetError(tBTelefono, "Ingresa un numero telefono valido");
                                throw new FormatException();
                            }
                        }
                        else
                        {
                            errorProvider1.SetError(tBCorreo, "Ingresa un correo valido");
                            throw new FormatException();
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(tBNombre, "Ingresa nombre y apellidos");
                        throw new FormatException();
                    }

                }
                else
                {
                    errorProvider1.Clear();

                    if (tBNombre.Text != "" && tBApellido.Text != "")
                    {
                        if (ComprobarFormatoEmail(tBCorreo.Text))
                        {
                            if ((tBTelefono.Text.ToString()).Length >= 8 &&
                                (tBTelefono.Text.ToString()).Length <= 10)
                            {
                                if (tBContrasena.Text != "")
                                {
                                    if (cBPuesto.Text != "")
                                    {
                                        query = "INSERT INTO Empleado VALUES(0," +
                                            " (SELECT id_puesto FROM Puesto WHERE Descripcion = '" + cBPuesto.Text + "')," +
                                            " '" + tBNombre.Text + "'," +
                                            " '" + tBApellido.Text + "'," +
                                            " " + Convert.ToDouble(tBTelefono.Text) + "," +
                                            " '" + tBCorreo.Text + "'," +
                                            " '" + tBContrasena.Text + "')";

                                        command = new MySqlCommand(query, connection);
                                        command.CommandTimeout = 60;

                                        connection.Open();
                                        reader = command.ExecuteReader();

                                        MessageBox.Show("Empleado se ha dado de alta con exito");

                                        this.Close();
                                    }
                                    else
                                    {
                                        errorProvider1.SetError(cBPuesto, "Ingresa un puesto para el empleado");
                                        throw new FormatException();
                                    }
                                }
                                else
                                {
                                    errorProvider1.SetError(tBContrasena, "Ingresa una contraseña valida");
                                    throw new FormatException();
                                }
                            }
                            else
                            {
                                errorProvider1.SetError(tBTelefono, "Ingresa un numero telefono valido");
                                throw new FormatException();
                            }
                        }
                        else
                        {
                            errorProvider1.SetError(tBCorreo, "Ingresa un correo valido");
                            throw new FormatException();
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(tBNombre, "Ingresa nombre y apellidos");
                        throw new FormatException();
                    }
                }
            }
            catch (FormatException)
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error en la Base de Datos",
                    "DATABASE MISSING", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        Boolean ComprobarFormatoEmail(string seMailAComprobar)
        {
            String sFormato;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(seMailAComprobar, sFormato))
            {
                if (Regex.Replace(seMailAComprobar, sFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }



    }
}
