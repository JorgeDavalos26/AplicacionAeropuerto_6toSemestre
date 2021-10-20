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

namespace _16100075_Jorge_AeroMaya_ProyectoFinal
{
    public partial class Admin_AgregarVuelo : Form
    {
        public Admin_AgregarVuelo()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWind, int wMsg, int wParam, int lParam);

        String stringConnection = "SERVER=localhost;" + "DATABASE=aeromayabd;" + "UID=root;" + "PASSWORD=;";

        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataReader reader;

        String query;

        String fechaDef = "1-1-2019";
        String hsalidaDef = "00:00:00";
        String hllegadaDef = "00:00:00";

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pBCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Admin_AgregarVuelo_Load(object sender, EventArgs e)
        {
            loadTripulantes();
            loadClase();
            loadAvion();
            loadPuerta();
            loadDestino();

            dTPSalida.Format = DateTimePickerFormat.Custom;
            dTPLlegada.Format = DateTimePickerFormat.Custom;
            dTPSalida.CustomFormat = "HH:mm:ss";
            dTPLlegada.CustomFormat = "HH:mm:ss";
            dTPSalida.ShowUpDown = true;
            dTPLlegada.ShowUpDown = true;

            dTP1.Text = fechaDef;
            dTP2.Text = fechaDef;
            dTPSalida.Text = hsalidaDef;
            dTPLlegada.Text = hllegadaDef;

            this.Location = new Point(400, 210);
        }

        void loadTripulantes()
        {
            try
            {
                connection = new MySqlConnection(stringConnection);

                query = "SELECT id_tripulantes FROM Tripulantes";

                command = new MySqlCommand(query, connection);
                command.CommandTimeout = 60;

                connection.Open();
                reader = command.ExecuteReader();

                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        cBTripulantes.Items.Add(reader.GetString(0));
                    }
                }

                connection.Close();
            }
            catch(Exception)
            {
                MessageBox.Show(this, "Error en la busqueda de tripulantes",
                    "CREW ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void loadClase()
        {
            try
            {
                connection = new MySqlConnection(stringConnection);

                query = "SELECT Descripcion FROM Clase";

                command = new MySqlCommand(query, connection);
                command.CommandTimeout = 60;

                connection.Open();
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cBClase.Items.Add(reader.GetString(0));
                    }
                }

                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Error en la busqueda de clases",
                    "CLASS ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void loadAvion()
        {
            try
            {
                connection = new MySqlConnection(stringConnection);

                query = "SELECT Nombre FROM Avion";

                command = new MySqlCommand(query, connection);
                command.CommandTimeout = 60;

                connection.Open();
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cBAvion.Items.Add(reader.GetString(0));
                    }
                }

                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Error en la busqueda de aviones",
                    "AIRPLANE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void loadPuerta()
        {
            try
            {
                connection = new MySqlConnection(stringConnection);

                query = "SELECT Descripcion FROM Puerta";

                command = new MySqlCommand(query, connection);
                command.CommandTimeout = 60;

                connection.Open();
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cBPuerta.Items.Add(reader.GetString(0));
                    }
                }

                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Error en la busqueda de puertas",
                    "DOOR ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void loadDestino()
        {
            try
            {
                connection = new MySqlConnection(stringConnection);

                query = "SELECT Nombre FROM Estado";

                command = new MySqlCommand(query, connection);
                command.CommandTimeout = 60;

                connection.Open();
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if(reader.GetString(0) != "Guadalajara")
                        {
                            cBDestino.Items.Add(reader.GetString(0));
                        }
                    }
                }

                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Error en la busqueda de destinos",
                    "DESTINATION ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();

                if(tBPrecioUnitario.Text != "")
                {
                    if(cBTripulantes.Text != "")
                    {
                        if(cBAvion.Text != "")
                        {
                            if(cBClase.Text != "")
                            {
                                if(cBPuerta.Text != "")
                                {
                                    if(cBDestino.Text != "")
                                    {
                                        if(dTP1.Text != "1/1/2019")
                                        {
                                            if (dTP2.Text != "1/1/2019")
                                            {
                                                if (dTPSalida.Text != "00:00:00")
                                                {
                                                    if (dTPLlegada.Text != "00:00:00")
                                                    {
                                                        switch (MessageBox.Show(this, "Estas seguro de crear vuelo?",
                                                            "ARE U SURE?",
                                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                                                        {
                                                            case DialogResult.Yes:

                                                                connection = new MySqlConnection(stringConnection);

                                                                query = "INSERT INTO Vuelo VALUES (0," +
                                                                    " 1," +
                                                                    " (SELECT id_clase FROM Clase WHERE Descripcion = '" + cBClase.Text + "')," +
                                                                    " (SELECT id_avion FROM Avion WHERE Nombre = '" + cBAvion.Text + "')," +
                                                                    " (SELECT id_puerta FROM Puerta WHERE Descripcion = '" + cBPuerta.Text + "')," +
                                                                    " 1," +
                                                                    " (SELECT id_estado FROM Estado WHERE Nombre = '" + cBDestino.Text + "')," +
                                                                    " '" + dTP1.Value.ToString("yyyy-MM-dd") + "', '" + dTPSalida.Text + "', '" + 
                                                                    dTP2.Value.ToString("yyyy-MM-dd") + "', '" + dTPLlegada.Text + "', " +
                                                                    Convert.ToInt32(tBPrecioUnitario.Text) + ")";

                                                                command = new MySqlCommand(query, connection);
                                                                command.CommandTimeout = 60;

                                                                connection.Open();
                                                                reader = command.ExecuteReader();

                                                                connection.Close();

                                                                MessageBox.Show(this, "Vuelo creado con exito", "FLIGHT CREATED",
                                                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                                                                this.Close();
                                                                break;
                                                            default:
                                                                break;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        errorProvider1.SetError(dTPLlegada, "Favor de ingresar la hora de llegada");
                                                    }
                                                }
                                                else
                                                {
                                                    errorProvider1.SetError(dTPSalida, "Favor de ingresar la hora de salida");
                                                }
                                            }
                                            else
                                            {
                                                errorProvider1.SetError(dTP2, "Favor de ingresar la fecha de entrada");
                                            }
                                        }
                                        else
                                        {
                                            errorProvider1.SetError(dTP1, "Favor de ingresar la fecha de salida");
                                        }
                                    }
                                    else
                                    {
                                        errorProvider1.SetError(cBDestino, "Favor de ingresar el destino de vuelo");
                                    }
                                }
                                else
                                {
                                    errorProvider1.SetError(cBPuerta, "Favor de ingresar la puerta para vuelo");
                                }
                            }
                            else
                            {
                                errorProvider1.SetError(cBClase, "Favor de ingresar la clase de vuelo");
                            }
                        }
                        else
                        {
                            errorProvider1.SetError(cBAvion, "Favor de ingresar el avion para vuelo");
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(cBTripulantes, "Favor de ingresar el equipo de tripulantes");
                    }
                }
                else
                {
                    errorProvider1.SetError(tBPrecioUnitario, "Favor de ingresar el costo del vuelo");
                }
            }
            catch(Exception)
            {
                MessageBox.Show(this, "Error en la Base de Datos",
                    "DATA BASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tBPrecioUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
