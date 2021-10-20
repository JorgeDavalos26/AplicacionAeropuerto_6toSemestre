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
    public partial class Admin_AgregarModificarAvion : Form
    {
        public Admin_AgregarModificarAvion(String _purpose, int _id_avion)
        {
            InitializeComponent();

            purpose = _purpose;

            id_avion = _id_avion;
        }
        
        String purpose = "";

        String stringConnection = "SERVER=localhost;" + "DATABASE=aeromayabd;" + "UID=root;" + "PASSWORD=;";

        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataReader reader;

        String query;

        int id_avion;

        String nom, aero;

        /* CODIGO PARA QUE VENTANA SE PUEDA MOVER DE MANERA LIBRE */

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWind, int wMsg, int wParam, int lParam);

        private void Admin_AgregarModificarAvion_Load(object sender, EventArgs e)
        {
            if (purpose == "Modificar")
            {
                loadAvion();

                aero = cBAerolinea.Text;
                nom = tBNombre.Text;

                loadAerolinea();

                cBAerolinea.Text = aero;
            }
            else
            {
                loadAerolinea();
            }

            this.Location = new Point(620, 260);
        }

        private void pBCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        void loadAerolinea()
        {
            connection = new MySqlConnection(stringConnection);

            query = "SELECT Nombre FROM Aerolinea;";

            command = new MySqlCommand(query, connection);
            command.CommandTimeout = 60;

            connection.Open();
            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    cBAerolinea.Items.Add(reader.GetString(0));
                }
            }
            else
            {
                MessageBox.Show(this, "No existen datos de aerolineas",
                    "DATA NOT FOUND", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            connection.Close();
        }

        void loadAvion()
        {
            try
            {
                connection = new MySqlConnection(stringConnection);

                query = "SELECT Avion.id_avion, Avion.Nombre, Aerolinea.Nombre" +
                    " FROM Avion" +
                    " INNER JOIN Aerolinea ON Aerolinea.id_aerolinea = Avion.id_aerolinea" +
                    " WHERE Avion.id_avion = " + id_avion;

                command = new MySqlCommand(query, connection);
                command.CommandTimeout = 60;

                connection.Open();
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        obtainDataAirplane();
                    }
                }
                else
                {
                    MessageBox.Show(this, "No existen datos de este avion",
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

        void obtainDataAirplane()
        {
            try
            {
                tBNombre.Text = reader.GetString(1);
                cBAerolinea.Text = reader.GetString(2);
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Error en la lectura de datos de avion",
                    "DATA AIRPLANE MISSING", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    if (tBNombre.Text != "")
                    {
                        if (cBAerolinea.Text != "")
                        {
                            if (aero == cBAerolinea.Text &&
                                nom == tBNombre.Text)
                            {

                            }
                            else
                            {
                                query = "UPDATE Avion SET id_aerolinea =" +
                                    " (SELECT id_aerolinea FROM Aerolinea WHERE Nombre = '" + cBAerolinea.Text + "')," +
                                    " Nombre = '" + tBNombre.Text + "' WHERE id_avion = " + id_avion;

                                command = new MySqlCommand(query, connection);
                                command.CommandTimeout = 60;

                                connection.Open();
                                reader = command.ExecuteReader();

                                connection.Close();

                                MessageBox.Show("Datos de avion han sido modificados");
                            }

                            this.Close();
                        }
                        else
                        {
                            errorProvider1.SetError(cBAerolinea, "Ingresa una aerolinea");
                            throw new FormatException();
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(tBNombre, "Ingresa nombre de avion");
                        throw new FormatException();
                    }

                }
                else
                {
                    errorProvider1.Clear();

                    if (tBNombre.Text != "")
                    {
                        if (cBAerolinea.Text != "")
                        {
                            query = "INSERT INTO Avion VALUES (0," +
                                " (SELECT id_aerolinea FROM Aerolinea WHERE Nombre = '" + cBAerolinea.Text + "')," +
                                " '" + tBNombre.Text + "')";

                            command = new MySqlCommand(query, connection);
                            command.CommandTimeout = 60;

                            connection.Open();
                            reader = command.ExecuteReader();

                            MessageBox.Show("Avion se ha dado de alta con exito");

                            this.Close();
                        }
                        else
                        {
                            errorProvider1.SetError(cBAerolinea, "Ingresa una aerolinea");
                            throw new FormatException();
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(tBNombre, "Ingresa nombre de avion");
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
