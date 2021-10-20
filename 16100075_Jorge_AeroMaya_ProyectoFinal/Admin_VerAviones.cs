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
    public partial class Admin_VerAviones : Form
    {
        public Admin_VerAviones()
        {
            InitializeComponent();
        }

        String stringConnection = "SERVER=localhost;" + "DATABASE=aeromayabd;" + "UID=root;" + "PASSWORD=;";

        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataReader reader;

        String query;

        DataTable table;

        int id_avion;

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

        private void Admin_VerAviones_Load(object sender, EventArgs e)
        {
            table = new DataTable();

            table.Columns.Add("#Avion", typeof(int));
            table.Columns.Add("Nombre", typeof(String));
            table.Columns.Add("Aerolinea", typeof(String));

            dGV1.DataSource = table;

            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "Eliminar";

            dGV1.Columns.Add(btnDelete);

            loadAviones();

            this.Location = new Point(550, 200);
        }

        void loadAviones()
        {
            try
            {
                table.Rows.Clear();

                connection = new MySqlConnection(stringConnection);

                query = "SELECT Avion.id_avion, Avion.Nombre, Aerolinea.Nombre" +
                    " FROM Avion" +
                    " INNER JOIN Aerolinea ON Aerolinea.id_aerolinea = Avion.id_aerolinea; ";

                command = new MySqlCommand(query, connection);
                command.CommandTimeout = 60;

                connection.Open();
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        createRowsOfDataGridView();
                    }
                }
                else
                {
                    MessageBox.Show(this, "No hay aviones registrados en la Base de Datos",
                        "PASSENGERS NOT FOUND", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Error en la Base de Datos",
                    "DATA BASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void createRowsOfDataGridView()
        {
            try
            {
                table.Rows.Add(Convert.ToInt32(reader.GetString(0)),
                    reader.GetString(1),
                    reader.GetString(2));

            }
            catch (Exception)
            {
                MessageBox.Show(this, "Error en la lectura de aviones",
                    "DATA PASSENGER MISSING", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dGV1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dGV1.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dGV1.Rows[e.RowIndex].Cells["Eliminar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\\delete.ico");
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dGV1.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.dGV1.Columns[e.ColumnIndex].Width = icoAtomico.Width + 8;

                e.Handled = true;
            }
        }

        private void dGV1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dGV1.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    id_avion = Convert.ToInt32(dGV1.CurrentRow.Cells[0].Value);

                    connection = new MySqlConnection(stringConnection);

                    query = "DELETE FROM Avion WHERE id_avion = " + id_avion;

                    command = new MySqlCommand(query, connection);
                    command.CommandTimeout = 60;

                    connection.Open();
                    reader = command.ExecuteReader();

                    connection.Close();

                    loadAviones();
                }
                else
                {
                    if (e.RowIndex != -1)
                    {
                        id_avion = Convert.ToInt32(dGV1.CurrentRow.Cells[0].Value);

                        Admin_AgregarModificarAvion newForm =
                            new Admin_AgregarModificarAvion("Modificar", id_avion);
                        newForm.ShowDialog();

                        loadAviones();
                    }
                    else
                    {
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show(this, "Error en la App",
                    "GENERAL APP ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bAgregarAvion_Click(object sender, EventArgs e)
        {
            Admin_AgregarModificarAvion newForm =
                new Admin_AgregarModificarAvion("Agregar", 0);
            newForm.ShowDialog();

            loadAviones();
        }
    }
}
