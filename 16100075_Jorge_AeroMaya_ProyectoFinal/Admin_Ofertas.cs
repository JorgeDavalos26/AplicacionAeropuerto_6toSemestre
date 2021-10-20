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
    public partial class Admin_Ofertas : Form
    {
        public Admin_Ofertas()
        {
            InitializeComponent();
        }

        String stringConnection = "SERVER=localhost;" + "DATABASE=aeromayabd;" + "UID=root;" + "PASSWORD=;";

        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataReader reader;

        String query;

        int nn1, pp1, nn2, pp2, nn3, pp3;

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

        private void pBCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Admin_Ofertas_Load(object sender, EventArgs e)
        {
            query = "SELECT NumBoletos, Porcentaje FROM Oferta";

            doQueryOfertas(query);

            this.Location = new Point(600, 190);
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if(nn1 != n1.Value || pp1 != p1.Value || nn2 != n2.Value || 
                    pp2 != p2.Value || nn3 != n3.Value || pp3 != p3.Value)
                {
                    for (int p = 0; p < 3; p++)
                    {
                        switch (p)
                        {
                            case 0:
                                query = "UPDATE Oferta SET " +
                                    "NumBoletos = " + n1.Value + ", Porcentaje = " + p1.Value + " WHERE id_oferta = " + (p + 1);
                                break;
                            case 1:
                                query = "UPDATE Oferta SET " +
                                    "NumBoletos = " + n2.Value + ", Porcentaje = " + p2.Value + " WHERE id_oferta = " + (p + 1);
                                break;
                            case 2:
                                query = "UPDATE Oferta SET " +
                                    "NumBoletos = " + n3.Value + ", Porcentaje = " + p3.Value + " WHERE id_oferta = " + (p + 1);
                                break;
                        }

                        doUpdateOfertas(query);
                    }

                    MessageBox.Show("Se han modificado con exito los cambios");
                }
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Error en query de Ofertas",
                    "OFFERS ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void doQueryOfertas(String q)
        {
            connection = new MySqlConnection(stringConnection);
            command = new MySqlCommand(q, connection);
            command.CommandTimeout = 60;

            connection.Open();
            reader = command.ExecuteReader();

            int p = 0;

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    whichQueryOfertas(p);
                    p++;
                }
            }

            connection.Close();
        }

        void whichQueryOfertas(int x)
        {
            switch(x)
            {
                case 0:
                    n1.Value = Convert.ToInt32(reader.GetString(0));
                    nn1 = Convert.ToInt32(n1.Value);
                    p1.Value = Convert.ToInt32(reader.GetString(1));
                    pp1 = Convert.ToInt32(p1.Value);
                    break;
                case 1:
                    n2.Value = Convert.ToInt32(reader.GetString(0));
                    nn2 = Convert.ToInt32(n2.Value);
                    p2.Value = Convert.ToInt32(reader.GetString(1));
                    pp2 = Convert.ToInt32(p2.Value);
                    break;
                case 2:
                    n3.Value = Convert.ToInt32(reader.GetString(0));
                    nn3 = Convert.ToInt32(n3.Value);
                    p3.Value = Convert.ToInt32(reader.GetString(1));
                    pp3 = Convert.ToInt32(p3.Value);
                    break;
            }
        }

        void doUpdateOfertas(String q)
        {
            connection = new MySqlConnection(stringConnection);
            command = new MySqlCommand(q, connection);
            command.CommandTimeout = 60;

            connection.Open();
            reader = command.ExecuteReader();

            connection.Close();
        }
        
    }
}
