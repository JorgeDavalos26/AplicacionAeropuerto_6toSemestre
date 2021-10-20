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
    public partial class Trabajador_SeleccionarAsientos : Form
    {
        public Trabajador_SeleccionarAsientos(int _id_vuelo)
        {
            InitializeComponent();

            if (_id_vuelo != 0)
            {
                id_vuelo = _id_vuelo;
            }
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

        Button[,] A = new Button[4, 8];
        int letra = 0;
        int numero = 0;
        Button a;

        int id_vuelo;

        static int numAsientos = 0;

        private void Trabajador_SeleccionarAsientos_Load(object sender, EventArgs e)
        {
            numAsientos = 0;

            numero = 0;
            letra = 0;
            
            foreach (Control item in this.Controls)
            {
                if (item is Button)
                {
                    if(item.Name != "bConfirmar")
                    {
                        A[letra, numero] = new Button();
                        A[letra, numero] = (Button)item;

                        numero++;

                        if (numero == 8)
                        {
                            letra++;
                            numero = 0;
                        }

                        item.BackColor = Color.LightBlue;
                    }
                }
            }

            String asientos = Trabajador_AgregarPasaje.tB.Text;
            int i = 0;
            
            char c = '\x0';
            int n = 0;

            while (i < asientos.Length)
            {
                letra = 0;
                numero = 0;

                switch (asientos[i])
                {
                    case '@':
                        break;
                    case 'A':
                    case 'B':
                    case 'C':
                    case 'D':
                        c = asientos[i];
                        break;
                    default:
                        n = (Convert.ToInt32(asientos[i]))-48;
                        foreach (Control item in this.Controls)
                        {
                            if (item is Button)
                            {
                                if (item.Name != "bConfirmar")
                                {
                                    if (item.Text == c + n.ToString())
                                    {
                                        A[letra, numero].BackColor = Color.Red;
                                        numAsientos++;
                                    }

                                    numero++;

                                    if (numero == 8)
                                    {
                                        letra++;
                                        numero = 0;
                                    }
                                }
                            }
                        }
                        break;
                }

                i++;
            }
            
            asientos = "";

            connection = new MySqlConnection(stringConnection);

            //MessageBox.Show(id_vuelo.ToString());

            query = "SELECT asientos FROM Factura WHERE id_vuelo = " + id_vuelo;

            command = new MySqlCommand(query, connection);
            command.CommandTimeout = 60;

            connection.Open();
            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    //MessageBox.Show(reader.GetString(0));
                    asientos += reader.GetString(0);
                }
            }

            connection.Close();

            i = 0;

            c = '\x0';
            n = 0;

            while (i < asientos.Length)
            {
                letra = 0;
                numero = 0;

                switch (asientos[i])
                {
                    case '@':
                        break;
                    case 'A':
                    case 'B':
                    case 'C':
                    case 'D':
                        c = asientos[i];
                        break;
                    default:
                        n = (Convert.ToInt32(asientos[i])) - 48;
                        foreach (Control item in this.Controls)
                        {
                            if (item is Button)
                            {
                                if (item.Name != "bConfirmar")
                                {
                                    if (item.Text == c + n.ToString())
                                    {
                                        A[letra, numero].BackColor = Color.IndianRed;

                                    }

                                    numero++;

                                    if (numero == 8)
                                    {
                                        letra++;
                                        numero = 0;
                                    }
                                }
                            }
                        }
                        break;
                }

                i++;
            }

            bConfirmar.Enabled = false;

            if (numAsientos == Trabajador_AgregarPasaje.nUD.Value)
            {
                bConfirmar.Enabled = true;
            }
            else
            {
                bConfirmar.Enabled = false;
            }

            this.Location = new Point(520, 120);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = sender as Button;

            if(a.BackColor != Color.IndianRed)
            {
                if (a.BackColor == Color.LightBlue)
                {
                    if (numAsientos != Trabajador_AgregarPasaje.nUD.Value)
                    {
                        a.BackColor = Color.Red;
                        numAsientos++;
                        //numBoletos--;

                        if(numAsientos == Trabajador_AgregarPasaje.nUD.Value)
                        {
                            bConfirmar.Enabled = true;
                        }
                        else
                        {
                            bConfirmar.Enabled = false;
                        }
                    }
                    //newForm.tBAsientos.Text += "@" + a.Text;
                    //MessageBox.Show("Rojo");
                }
                else
                {
                    a.BackColor = Color.LightBlue;
                    numAsientos--;
                    bConfirmar.Enabled = false;

                    //numBoletos++;
                    //MessageBox.Show("Azul");
                }
            }
        }

        private void bConfirmar_Click(object sender, EventArgs e)
        {
            Trabajador_AgregarPasaje.tB.Text = "";

            numero = 0;
            letra = 0;

            foreach (Control item in this.Controls)
            {
                if (item is Button)
                {
                    if (item.Name != "bConfirmar")
                    {
                        if (A[letra, numero].BackColor == Color.Red)
                        {
                            Trabajador_AgregarPasaje.tB.Text += "@" + A[letra, numero].Text;
                        }

                        numero++;

                        if (numero == 8)
                        {
                            letra++;
                            numero = 0;
                        }
                    }
                }
            }

            Trabajador_AgregarPasaje.boletos = true;

            this.Close();
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
    }
}
