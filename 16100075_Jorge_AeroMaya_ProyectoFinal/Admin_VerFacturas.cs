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
    public partial class Admin_VerFacturas : Form
    {
        public Admin_VerFacturas()
        {
            InitializeComponent();
        }

        String stringConnection = "SERVER=localhost;" + "DATABASE=aeromayabd;" + "UID=root;" + "PASSWORD=;";

        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataReader reader;

        String query;

        DataTable table;

        int p;
        int id_factura;

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

        private void Admin_VerFacturas_Load(object sender, EventArgs e)
        {
            table = new DataTable();

            table.Columns.Add("#Factura", typeof(int));
            table.Columns.Add("Aerolinea", typeof(String));
            table.Columns.Add("#Vuelo", typeof(int));
            table.Columns.Add("Fecha Salida", typeof(String));
            table.Columns.Add("Fecha Llegada", typeof(String));
            table.Columns.Add("Hora Salida", typeof(String));
            table.Columns.Add("Hora Llegada", typeof(String));
            table.Columns.Add("Nombre de Pasajero", typeof(String));
            table.Columns.Add("Origen", typeof(String));
            table.Columns.Add("Destino", typeof(String));
            table.Columns.Add("Puerta", typeof(String));
            table.Columns.Add("Asiento(s)", typeof(String));
            table.Columns.Add("Clase", typeof(String));
            table.Columns.Add("Tarjeta", typeof(String));
            table.Columns.Add("Precio Total", typeof(int));

            dGV1.DataSource = table;

            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "Eliminar";

            dGV1.Columns.Add(btnDelete);

            loadFacturas();

            loadNombreDePasajeroItems();
            loadClaseItems();
            loadAerolineaItems();

            this.Location = new Point(20, 60);
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
                    id_factura = Convert.ToInt32(dGV1.CurrentRow.Cells[0].Value);

                    connection = new MySqlConnection(stringConnection);

                    query = "DELETE FROM Factura WHERE id_factura = " + id_factura;

                    command = new MySqlCommand(query, connection);
                    command.CommandTimeout = 60;

                    connection.Open();
                    reader = command.ExecuteReader();

                    connection.Close();

                    loadFacturas();
                }

            }
            catch (Exception)
            {
                MessageBox.Show(this, "Error en la App",
                    "GENERAL APP ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pBCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            loadFacturas();

            cBNombreCompleto.Text = "";
            cBClase.Text = "";
            cBAerolinea.Text = "";
        }

        void loadFacturas()
        {
            try
            {
                table.Rows.Clear();

                connection = new MySqlConnection(stringConnection);

                query = "SELECT Factura.id_factura, Aerolinea.Nombre, Vuelo.id_vuelo," +
                    " Vuelo.FechaSalida, Vuelo.FechaLlegada," + 
                    " Vuelo.HSalida, Vuelo.HLlegada," +
                    " CONCAT(Pasajero.Nombre, ' ', Pasajero.Apellido)," +
                    " E1.Nombre, E2.Nombre," +
                    " Puerta.descripcion, Factura.Asientos," +
                    " Clase.descripcion, TarjetaCredito.Descripcion, Factura.PrecioTotal FROM Vuelo" +
                    " INNER JOIN Avion ON Avion.id_avion = Vuelo.id_avion" +
                    " INNER JOIN Aerolinea ON Aerolinea.id_aerolinea = Avion.id_aerolinea" +
                    " INNER JOIN Estado E1 ON E1.id_estado = Vuelo.id_EstadoOrigen" +
                    " INNER JOIN Estado E2 ON E2.id_estado = Vuelo.id_EstadoDestino" +
                    " INNER JOIN Puerta ON Puerta.id_puerta = Vuelo.id_puerta" +
                    " INNER JOIN Clase ON Clase.id_clase = Vuelo.id_clase" +
                    " INNER JOIN Factura ON Factura.id_vuelo = Vuelo.id_vuelo" +
                    " INNER JOIN Pasajero ON Pasajero.id_pasajero = Factura.id_pasajero" +
                    " INNER JOIN TarjetaCredito ON TarjetaCredito.id_tarjeta = Factura.id_tarjeta" +
                    " WHERE Pasajero.id_pasajero = Pasajero.id_pasajero" +
                    " AND Clase.Descripcion = Clase.Descripcion AND Aerolinea.Nombre = Aerolinea.Nombre" +
                    " ORDER BY Vuelo.FechaSalida ASC, Vuelo.HSalida ASC";
                

                command = new MySqlCommand(query, connection);
                command.CommandTimeout = 60;

                connection.Open();
                reader = command.ExecuteReader();

                p = 0;

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        createRowsOfDataGridView();  
                    }
                }
                else
                {
                    MessageBox.Show(this, "Lo sentimos, no se encuentra disponible ninguna factura",
                        "BILL NOT FOUND", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    Convert.ToInt32(reader.GetString(2)),
                    reader.GetString(3),
                    reader.GetString(4),
                    reader.GetString(5),
                    reader.GetString(6),
                    reader.GetString(7),
                    reader.GetString(8),
                    reader.GetString(9),
                    reader.GetString(10),
                    reader.GetString(11),
                    reader.GetString(12),
                    reader.GetString(13),
                    Convert.ToInt32(reader.GetString(14)));

                

                if (reader.GetString(12) == "Primera Clase")
                {
                    dGV1.Rows[p].DefaultCellStyle.BackColor = Color.LightGreen;
                    dGV1.Rows[p].DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else if (reader.GetString(12) == "Ejecutiva")
                {
                    dGV1.Rows[p].DefaultCellStyle.BackColor = Color.LightSalmon;
                    dGV1.Rows[p].DefaultCellStyle.BackColor = Color.LightSalmon;
                }
                else
                {
                    dGV1.Rows[p].DefaultCellStyle.BackColor = Color.LightBlue;
                    dGV1.Rows[p].DefaultCellStyle.BackColor = Color.LightBlue;
                }

                p++;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error en la lectura de facturas" + ex.ToString(),
                    "DATA BILL MISSING", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void loadNombreDePasajeroItems()
        {
            try
            {
                cBNombreCompleto.Items.Clear();

                connection = new MySqlConnection(stringConnection);

                query = "SELECT CONCAT(Nombre, ' ', Apellido) FROM Pasajero";

                command = new MySqlCommand(query, connection);
                command.CommandTimeout = 60;

                connection.Open();
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cBNombreCompleto.Items.Add(reader.GetString(0));
                    }
                }
                else
                {
                    MessageBox.Show(this, "No hay pasajeros registrados",
                        "PASSENGER NOT FOUND", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Error en la Base de Datos",
                    "DATA BASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void loadAerolineaItems()
        {
            try
            {
                cBAerolinea.Items.Clear();

                connection = new MySqlConnection(stringConnection);

                query = "SELECT Nombre FROM Aerolinea";

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
                    MessageBox.Show(this, "No hay aerolineas",
                        "AEROLINE NOT FOUND", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Error en la Base de Datos",
                    "DATA BASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void loadClaseItems()
        {
            try
            {
                cBClase.Items.Clear();

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
                else
                {
                    MessageBox.Show(this, "No hay clases de vuelos",
                        "CLASS NOT FOUND", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Error en la Base de Datos",
                    "DATA BASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                table.Rows.Clear();

                connection = new MySqlConnection(stringConnection);

                query = "SELECT Factura.id_factura, Aerolinea.Nombre, Vuelo.id_vuelo," +
                    " Vuelo.FechaSalida, Vuelo.FechaLlegada," +
                    " Vuelo.HSalida, Vuelo.HLlegada," +
                    " CONCAT(Pasajero.Nombre, ' ', Pasajero.Apellido)," +
                    " E1.Nombre, E2.Nombre," +
                    " Puerta.descripcion, Factura.Asientos," +
                    " Clase.descripcion, TarjetaCredito.Descripcion, Factura.PrecioTotal FROM Vuelo" +
                    " INNER JOIN Avion ON Avion.id_avion = Vuelo.id_avion" +
                    " INNER JOIN Aerolinea ON Aerolinea.id_aerolinea = Avion.id_aerolinea" +
                    " INNER JOIN Estado E1 ON E1.id_estado = Vuelo.id_EstadoOrigen" +
                    " INNER JOIN Estado E2 ON E2.id_estado = Vuelo.id_EstadoDestino" +
                    " INNER JOIN Puerta ON Puerta.id_puerta = Vuelo.id_puerta" +
                    " INNER JOIN Clase ON Clase.id_clase = Vuelo.id_clase" +
                    " INNER JOIN Factura ON Factura.id_vuelo = Vuelo.id_vuelo" +
                    " INNER JOIN Pasajero ON Pasajero.id_pasajero = Factura.id_pasajero" +
                    " INNER JOIN TarjetaCredito ON TarjetaCredito.id_tarjeta = Factura.id_tarjeta";

                if (cBNombreCompleto.Text != "")
                {
                    query = query + " WHERE Pasajero.id_pasajero =" +
                        " (SELECT ID FROM ComboPasajero WHERE NombreCompleto = '" + cBNombreCompleto.Text + "')";
                }
                else
                {
                    query = query + " WHERE Pasajero.id_pasajero = Pasajero.id_pasajero";
                }

                if (cBClase.Text != "")
                {
                    query = query + " AND Clase.Descripcion = '" + cBClase.Text + "'";
                }
                else
                {
                    query = query + " AND Clase.Descripcion = Clase.Descripcion";
                }

                if (cBAerolinea.Text != "")
                {
                    query = query + " AND Aerolinea.Nombre = '" + cBAerolinea.Text + "'";
                }
                else
                {
                    query = query + " AND Aerolinea.Nombre = Aerolinea.Nombre";
                }

                query = query + " ORDER BY Vuelo.FechaSalida ASC, Vuelo.HSalida ASC";


                command = new MySqlCommand(query, connection);
                command.CommandTimeout = 60;

                connection.Open();
                reader = command.ExecuteReader();

                p = 0;

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        createRowsOfDataGridView();
                    }
                }
                else
                {
                    MessageBox.Show(this, "No se encuentra ninguna factura con esas caracteristicas",
                        "BILL NOT FOUND", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Favor de ingresar bien los datos",
                    "DATA ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void paintCells()
        {
            foreach (DataGridViewRow row in dGV1.Rows)
            {
                try
                {
                    if (row.Cells[12].Value.ToString() == "Primera Clase")
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    else if (row.Cells[12].Value.ToString() == "Ejecutiva")
                    {
                        row.DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.LightBlue;
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        private void dGV1_Sorted_1(object sender, EventArgs e)
        {
            paintCells();
        }
    }
}
