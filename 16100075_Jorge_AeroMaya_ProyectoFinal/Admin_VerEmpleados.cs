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
    public partial class Admin_VerEmpleados : Form
    {
        public Admin_VerEmpleados()
        {
            InitializeComponent();
        }

        String stringConnection = "SERVER=localhost;" + "DATABASE=aeromayabd;" + "UID=root;" + "PASSWORD=;";

        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataReader reader;

        String query;

        DataTable table;

        int id_empleado;

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

        private void Admin_VerEmpleados_Load(object sender, EventArgs e)
        {
            table = new DataTable();

            table.Columns.Add("#Empleado", typeof(int));
            table.Columns.Add("Puesto", typeof(String));
            table.Columns.Add("Nombre", typeof(String));
            table.Columns.Add("Apellido", typeof(String));
            table.Columns.Add("Telefono", typeof(double));
            table.Columns.Add("Correo", typeof(String));
            table.Columns.Add("Contrasena", typeof(String));

            dGV1.DataSource = table;

            if (Form1.tipoUsuario == "Admin")
            {
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.Name = "Eliminar";

                dGV1.Columns.Add(btnDelete);
            }
            else
            {

            }

            loadEmpleados();

            this.Location = new Point(260, 120);
        }

        void loadEmpleados()
        {
            try
            {
                table.Rows.Clear();

                connection = new MySqlConnection(stringConnection);

                query = "SELECT Empleado.id_empleado, Puesto.Descripcion, Empleado.Nombre," +
                    " Empleado.Apellido, Empleado.Telefono, Empleado.Correo," +
                    " Empleado.Contrasena FROM Empleado" +
                    " INNER JOIN Puesto ON Puesto.id_puesto = Empleado.id_puesto";

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
                    MessageBox.Show(this, "No hay empleados en Base de Datos",
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
                    reader.GetString(2),
                    reader.GetString(3),
                    Convert.ToDouble(reader.GetString(4)),
                    reader.GetString(5),
                    reader.GetString(6));

            }
            catch (Exception)
            {
                MessageBox.Show(this, "Error en la lectura de empleados",
                    "DATA PASSENGER MISSING", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dGV1_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void pBCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dGV1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Form1.tipoUsuario == "Admin")
                {
                    if (this.dGV1.Columns[e.ColumnIndex].Name == "Eliminar")
                    {
                        id_empleado = Convert.ToInt32(dGV1.CurrentRow.Cells[0].Value);

                        connection = new MySqlConnection(stringConnection);

                        query = "DELETE FROM Pasajero WHERE id_pasajero = " + id_empleado;

                        command = new MySqlCommand(query, connection);
                        command.CommandTimeout = 60;

                        connection.Open();
                        reader = command.ExecuteReader();

                        connection.Close();

                        loadEmpleados();
                    }
                    else
                    {
                        if (e.RowIndex != -1)
                        {
                            id_empleado = Convert.ToInt32(dGV1.CurrentRow.Cells[0].Value);

                            Admin_AgregarModificarEmpleado newForm =
                                new Admin_AgregarModificarEmpleado("Modificar", id_empleado);
                            newForm.ShowDialog();

                            loadEmpleados();

                        }
                        else
                        {
                        }
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show(this, "Error en la App",
                    "GENERAL APP ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void bAgregarEmpleado_Click(object sender, EventArgs e)
        {
            Admin_AgregarModificarEmpleado newForm =
                new Admin_AgregarModificarEmpleado("Agregar", 0);
            newForm.ShowDialog();
            loadEmpleados();
        }

        

        

        
    }
}
