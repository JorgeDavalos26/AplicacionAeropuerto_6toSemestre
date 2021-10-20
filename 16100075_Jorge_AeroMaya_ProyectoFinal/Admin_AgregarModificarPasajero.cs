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
    public partial class Admin_AgregarModificarPasajero : Form
    {
        public Admin_AgregarModificarPasajero(String _purpose, int _id_pasajero)
        {
            InitializeComponent();

            purpose = _purpose;

            id_pasajero = _id_pasajero;

        }

        String purpose = "";

        String stringConnection = "SERVER=localhost;" + "DATABASE=aeromayabd;" + "UID=root;" + "PASSWORD=;";

        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataReader reader;

        String query;
        
        int id_pasajero;

        String nom, ape, corr;
        double tel;
        int ed;

        /* CODIGO PARA QUE VENTANA SE PUEDA MOVER DE MANERA LIBRE */

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWind, int wMsg, int wParam, int lParam);

        private void pSuperior_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pBCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Admin_AgregarModificarPasajero_Load(object sender, EventArgs e)
        {
            if(purpose == "Modificar")
            {
                loadPasajero();

                nom = tBNombre.Text;
                ape = tBApellido.Text;
                corr = tBCorreo.Text;
                tel = Convert.ToDouble(tBTelefono.Text);
                ed = Convert.ToInt32(tBEdad.Text);
            }
            else
            {

            }

            this.Location = new Point(540, 290);
        }

        void loadPasajero()
        {
            try
            {
                connection = new MySqlConnection(stringConnection);

                query = "SELECT * FROM Pasajero WHERE id_pasajero = " + id_pasajero;

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
                    MessageBox.Show(this, "No existen datos de este pasajero",
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

                tBNombre.Text = reader.GetString(1);
                tBApellido.Text = reader.GetString(2);
                tBCorreo.Text = reader.GetString(3);
                tBTelefono.Text = reader.GetString(4);
                tBEdad.Text = reader.GetString(5);

            }
            catch (Exception)
            {
                MessageBox.Show(this, "Error en la lectura de datos de pasajero",
                    "DATA PASSENGER MISSING", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                                if (Convert.ToInt32(tBEdad.Text) < 110)
                                {
                                    if(nom == tBNombre.Text && 
                                        ape == tBApellido.Text &&
                                        corr == tBCorreo.Text &&
                                        tel == Convert.ToDouble(tBTelefono.Text) &&
                                        ed == Convert.ToInt32(tBEdad.Text))
                                    {
                                        
                                    }
                                    else
                                    {
                                        query = "UPDATE Pasajero SET Nombre = '" + tBNombre.Text + "', " +
                                        "Apellido = '" + tBApellido.Text + "', " +
                                        "Correo = '" + tBCorreo.Text + "', " +
                                        "Telefono = " + Convert.ToDouble(tBTelefono.Text) + ", " +
                                        "Edad = " + Convert.ToInt32(tBEdad.Text) + " WHERE id_pasajero = " + id_pasajero;

                                        command = new MySqlCommand(query, connection);
                                        command.CommandTimeout = 60;

                                        connection.Open();
                                        reader = command.ExecuteReader();

                                        connection.Close();

                                        MessageBox.Show("Datos de pasajero se han modificado con exito");
                                    }

                                    this.Close();
                                }
                                else
                                {
                                    errorProvider1.SetError(tBEdad, "Ingresa una edad valida");
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
                                if (Convert.ToInt32(tBEdad.Text) < 110)
                                {
                                    query = "INSERT INTO Pasajero " +
                                            " VALUES (0, '" + tBNombre.Text + "', '" + tBApellido.Text + "', '" +
                                            tBCorreo.Text + "', " + Convert.ToDouble(tBTelefono.Text) + ", " +
                                            Convert.ToInt32(tBEdad.Text) + ")";


                                    command = new MySqlCommand(query, connection);
                                    command.CommandTimeout = 60;

                                    connection.Open();
                                    reader = command.ExecuteReader();

                                    MessageBox.Show("Pasajero se ha dado de alta con exito");

                                    this.Close();
                                }
                                else
                                {
                                    errorProvider1.SetError(tBEdad, "Ingresa una edad valida");
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
}
