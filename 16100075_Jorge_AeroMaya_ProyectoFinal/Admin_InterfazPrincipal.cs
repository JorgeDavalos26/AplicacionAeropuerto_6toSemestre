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
using System.IO;

namespace _16100075_Jorge_AeroMaya_ProyectoFinal
{
    public partial class Admin_InterfazPrincipal : Form
    {
        String dirRoute = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

        public Admin_InterfazPrincipal()
        {
            InitializeComponent();
        }

        Boolean play = false;

        /* CODIGO PARA QUE VENTANA SE PUEDA MOVER DE MANERA LIBRE */

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWind, int wMsg, int wParam, int lParam);

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Admin_InterfazPrincipal_Load(object sender, EventArgs e)
        {
            /*String trailer = "C:\\Users\\jorge\\Desktop\\16100075_Jorge_AeroMaya_ProyectoFinal\\CommercialAirlines.mp4";*/
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

            this.Location = new Point(320, 120);
        }

        private void vuelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Trabajador_VerVuelos newForm = new Trabajador_VerVuelos();
            newForm.ShowDialog();*/
        }

        private void pasajerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_VerPasajeros newForm = new Admin_VerPasajeros();
            newForm.ShowDialog();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_VerEmpleados newForm = new Admin_VerEmpleados();
            newForm.ShowDialog();
        }

        private void avionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_VerAviones newForm = new Admin_VerAviones();
            newForm.ShowDialog();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_VerFacturas newForm = new Admin_VerFacturas();
            newForm.ShowDialog();
        }

        private void pBCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pBStop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();

            //pBPause.Image = Image.FromFile("C:\\Users\\jorge\\Desktop\\16100075_Jorge_AeroMaya_ProyectoFinal\\play.png");
            pBPause.Image = Image.FromFile(dirRoute + "\\play.png");
            play = false;
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

        private void pBReload_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();

            axWindowsMediaPlayer1.Ctlcontrols.play();
            //pBPause.Image = Image.FromFile("C:\\Users\\jorge\\Desktop\\16100075_Jorge_AeroMaya_ProyectoFinal\\pausa.png");
            pBPause.Image = Image.FromFile(dirRoute + "\\pausa.png");
            play = true;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
        }

        private void aBOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void bCambiarDeCuenta_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
            // this.Close();
            this.Dispose();
        }

        private void verVuelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trabajador_VerVuelos newForm = new Trabajador_VerVuelos();
            newForm.ShowDialog();
        }

        private void descuentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_Ofertas newForm = new Admin_Ofertas();
            newForm.ShowDialog();
        }

        private void nombreDeAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jorge Alberto Davalos Sigala");
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("16100075");
        }

        private void materiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programacion Avanzada");
        }

        private void gradoYGrupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("7A2");
        }

        private void aBOUTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            About newForm = new About();
            newForm.ShowDialog();
        }
    }
}
