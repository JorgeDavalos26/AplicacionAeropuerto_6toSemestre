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
using System.Diagnostics;
using System.IO;

namespace _16100075_Jorge_AeroMaya_ProyectoFinal
{
    public partial class Form1 : Form
    {
        String stringConnection = "SERVER=localhost;" + "DATABASE=aeromayabd;" + "UID=root;" + "PASSWORD=;";

        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataReader reader;

        String query;

        public static String tipoUsuario = "";

        // Constructor

        public Form1()
        {
            //MessageBox.Show(Directory.GetCurrentDirectory() + "      " + Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName);
            InitializeComponent();
        }

        // Para mover la ventana 

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWind, int wMsg, int wParam, int lParam);

        private void pSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // Metodos

        private void Form1_Load(object sender, EventArgs e)
        {
            bIngresar.Focus();
            this.Location = new Point(570, 250);
        }

        private void pBCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bIngresar_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Click en ingresar");

            try
            {
                if(!ComprobarFormatoEmail(tBCorreo.Text))
                {
                    throw new Exception();
                }
                
                connection = new MySqlConnection(stringConnection);

                query = "SELECT * FROM Empleado WHERE correo = '" +
                    tBCorreo.Text.ToString() + "'  AND contrasena = '" +
                    tBContrasena.Text.ToString() + "'";

                command = new MySqlCommand(query, connection);
                command.CommandTimeout = 60;

                connection.Open();
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if(Convert.ToInt32(reader.GetString(1)) == 5)
                        {
                            tipoUsuario = "Admin";
                            Admin_InterfazPrincipal newForm = new Admin_InterfazPrincipal();
                            newForm.Show();
                        }
                        else
                        {
                            tipoUsuario = "Trabajador";
                            Trabajador_InterfazPrincipal newForm = new Trabajador_InterfazPrincipal();
                            newForm.Show();
                        }

                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show(this, "Lo sentimos, no existe cuenta", 
                        "ACCOUNT NOT FOUND", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, "Favor de llenar correctamente los campos   " + ex.ToString(), 
                    "DATA ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void bIngresar_MouseHover(object sender, EventArgs e)
        {
            bIngresar.BackgroundImage = Properties.Resources.VerdeLima;
        }

        private void bIngresar_MouseLeave(object sender, EventArgs e)
        {
            bIngresar.BackgroundImage = Properties.Resources.Aquamarina;
        }
        
    }
}
