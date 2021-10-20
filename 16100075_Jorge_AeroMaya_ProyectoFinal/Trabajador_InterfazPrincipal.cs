using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;

namespace _16100075_Jorge_AeroMaya_ProyectoFinal
{
    public partial class Trabajador_InterfazPrincipal : Form
    {
        String dirRoute = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

        public Trabajador_InterfazPrincipal()
        {
            InitializeComponent();
        }

        Boolean play = false;

        /* CODIGO PARA QUE VENTANA SE PUEDA MOVER DE MANERA LIBRE */

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWind, int wMsg, int wParam, int lParam);

        private void pSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Trabajador_InterfazPrincipal_Load(object sender, EventArgs e)
        {
            this.Location = new Point(300, 170);
            //String trailer = "C:\\Users\\jorge\\Desktop\\16100075_Jorge_AeroMaya_ProyectoFinal\\CommercialAirlines.mp4";
            String trailer = dirRoute + "\\CommercialAirlines.mp4";
            axWindowsMediaPlayer1.URL = trailer;

            /*pBPause.Image = Image.FromFile("C:\\Users\\jorge\\Desktop\\16100075_Jorge_AeroMaya_ProyectoFinal\\play.png");
            pBReload.Image = Image.FromFile("C:\\Users\\jorge\\Desktop\\16100075_Jorge_AeroMaya_ProyectoFinal\\refrescar.png");
            pBStop.Image = Image.FromFile("C:\\Users\\jorge\\Desktop\\16100075_Jorge_AeroMaya_ProyectoFinal\\stop.png");*/
            pBPause.Image = Image.FromFile(dirRoute + "\\play.png");
            pBReload.Image = Image.FromFile(dirRoute + "\\refrescar.png");
            pBStop.Image = Image.FromFile(dirRoute + "\\stop.png");

            axWindowsMediaPlayer1.uiMode = "none";

            axWindowsMediaPlayer1.settings.volume = 5;
            trackBar1.Value = 5;

            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void pBCancel_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bVerVuelos_MouseHover(object sender, EventArgs e)
        {
            bVerVuelos.Image = Properties.Resources.Azul_Marino;
            bVerPasajeros.Image = Properties.Resources.VerdeLima;
            bAgregarPasajero.Image = Properties.Resources.VerdeLima;

            bVerVuelos.ForeColor = Color.White;
            bVerPasajeros.ForeColor = Color.Black;
            bAgregarPasajero.ForeColor = Color.Black;
        }

        private void bVerPasajeros_MouseHover(object sender, EventArgs e)
        {
            bVerVuelos.Image = Properties.Resources.VerdeLima;
            bVerPasajeros.Image = Properties.Resources.Azul_Marino;
            bAgregarPasajero.Image = Properties.Resources.VerdeLima;

            bVerVuelos.ForeColor = Color.Black;
            bVerPasajeros.ForeColor = Color.White;
            bAgregarPasajero.ForeColor = Color.Black;
        }

        private void bAgregarPasajero_MouseHover(object sender, EventArgs e)
        {
            bVerVuelos.Image = Properties.Resources.VerdeLima;
            bVerPasajeros.Image = Properties.Resources.VerdeLima;
            bAgregarPasajero.Image = Properties.Resources.Azul_Marino;

            bVerVuelos.ForeColor = Color.Black;
            bVerPasajeros.ForeColor = Color.Black;
            bAgregarPasajero.ForeColor = Color.White;
        }

        private void bVerVuelos_Click(object sender, EventArgs e)
        {
            Trabajador_VerVuelos newForm = new Trabajador_VerVuelos();
            newForm.ShowDialog();
        }

        private void bVerPasajeros_Click(object sender, EventArgs e)
        {
            Admin_VerPasajeros newForm = new Admin_VerPasajeros();
            newForm.ShowDialog();
        }

        private void bAgregarPasajero_Click(object sender, EventArgs e)
        {
            Admin_AgregarModificarPasajero newForm = new Admin_AgregarModificarPasajero("Agregar", 0);
            newForm.ShowDialog();
        }

        private void pBReload_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();

            axWindowsMediaPlayer1.Ctlcontrols.play();
            //pBPause.Image = Image.FromFile("C:\\Users\\jorge\\Desktop\\16100075_Jorge_AeroMaya_ProyectoFinal\\pausa.png");
            pBPause.Image = Image.FromFile(dirRoute + "\\pausa.png");
            play = true;
        }

        private void pBPause_Click(object sender, EventArgs e)
        {
            if (play)
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                //pBPause.Image = Image.FromFile("C:\\Users\\jorge\\Desktop\\16100075_Jorge_AeroMaya_ProyectoFinal\\play.png");
                pBPause.Image = Image.FromFile(dirRoute + "\\play.png");
                play = false;
            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                //pBPause.Image = Image.FromFile("C:\\Users\\jorge\\Desktop\\16100075_Jorge_AeroMaya_ProyectoFinal\\pausa.png");
                pBPause.Image = Image.FromFile(dirRoute + "\\pausa.png");
                play = true;
            }

        }

        private void pBStop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();

            //pBPause.Image = Image.FromFile("C:\\Users\\jorge\\Desktop\\16100075_Jorge_AeroMaya_ProyectoFinal\\play.png");
            pBPause.Image = Image.FromFile(dirRoute + "\\play.png");
            play = false;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
        }

        private void bCambiarDeCuenta_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
            // this.Close();
            this.Dispose();
        }
    }
}
