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
    public partial class Trabajador_VerVuelos : Form
    {
        public Trabajador_VerVuelos()
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
        int id_vuelo;

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

        private void Trabajador_VerVuelos_Load(object sender, EventArgs e)
        {
            table = new DataTable();

            table.Columns.Add("#Vuelo", typeof(int));
            table.Columns.Add("Aerolinea", typeof(String));
            table.Columns.Add("Fecha de Salida", typeof(String));
            table.Columns.Add("Fecha de LLegada", typeof(String));
            table.Columns.Add("Clase", typeof(String));
            table.Columns.Add("Origen", typeof(String));
            table.Columns.Add("Destino", typeof(String));
            table.Columns.Add("Hora Salida", typeof(String));
            table.Columns.Add("Hora Llegada", typeof(String));
            table.Columns.Add("Precio Unitario", typeof(int));
            
            dGV1.DataSource = table;

            if(Form1.tipoUsuario == "Admin")
            {
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.Name = "Eliminar";

                dGV1.Columns.Add(btnDelete);
            }
            else
            {
                bAgregarVuelo.Hide();
            }
            
            loadVuelos();

            loadDestinoItems();
            loadAerolineaItems();
            loadClaseItems();

            cBOrigen.Text = "Guadalajara";
            cBOrigen.Enabled = false;

            dTP1.Value = Convert.ToDateTime("01/01/2019");
            
            this.Location = new Point(260, 120);
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

        private void pBCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            loadVuelos();

            cBDestino.Text = "";
            cBClase.Text = "";
            cBAerolinea.Text = "";
            dTP1.Value = Convert.ToDateTime("01/01/2019");
        }

        void loadVuelos()
        {
            try
            {
                table.Rows.Clear();

                connection = new MySqlConnection(stringConnection);

                query = "SELECT Vuelo.id_vuelo, Aerolinea.Nombre," +
                    " DATE_FORMAT(Vuelo.FechaSalida, '%Y-%m-%d')," +
                    " DATE_FORMAT(Vuelo.FechaLlegada, '%Y-%m-%d')," +
                    " Clase.Descripcion, E1.Nombre, E2.Nombre," +
                    " Vuelo.HSalida, Vuelo.HLlegada," +
                    " Vuelo.PrecioUnitario FROM Vuelo" +
                    " INNER JOIN Avion ON Avion.id_avion = Vuelo.id_avion" +
                    " INNER JOIN Aerolinea ON Aerolinea.id_aerolinea = Avion.id_aerolinea" +
                    " INNER JOIN Estado E1 ON E1.id_estado = Vuelo.id_EstadoOrigen" +
                    " INNER JOIN Estado E2 ON E2.id_estado = Vuelo.id_EstadoDestino" +
                    " INNER JOIN Clase ON Clase.id_clase = Vuelo.id_clase" +
                    " WHERE Aerolinea.Nombre = Aerolinea.Nombre" +
                    " AND Clase.Descripcion = Clase.Descripcion" +
                    " AND E2.Nombre = E2.Nombre AND Vuelo.HSalida = Vuelo.hsalida";

                if (Form1.tipoUsuario != "Admin")
                {
                    query += " AND CONCAT(Vuelo.FechaSalida, ' ', Vuelo.HSalida) > (SELECT ADDTIME(CURRENT_TIMESTAMP(), '00:15:00'))";
                }

                query += " ORDER BY Vuelo.FechaSalida ASC, Vuelo.HSalida ASC";

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
                    MessageBox.Show(this, "Lo sentimos, no se encuentra disponible ningun vuelo", 
                        "FLIGHT NOT FOUND", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    reader.GetString(4),
                    reader.GetString(5),
                    reader.GetString(6),
                    reader.GetString(7),
                    reader.GetString(8),
                    Convert.ToInt32(reader.GetString(9)));

                    if (reader.GetString(4) == "Primera Clase")
                    {
                        dGV1.Rows[p].DefaultCellStyle.BackColor = Color.LightGreen;
                        dGV1.Rows[p].DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    else if (reader.GetString(4) == "Ejecutiva")
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
            catch (Exception)
            {
                MessageBox.Show(this, "Error en la lectura de vuelos", 
                    "DATA FLIGHT MISSING", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        void loadDestinoItems()
        {
            try
            {
                cBDestino.Items.Clear();

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
                else
                {
                    MessageBox.Show(this, "No hay destinos", 
                        "DESTINATION NOT FOUND", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void bBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                table.Rows.Clear();

                connection = new MySqlConnection(stringConnection);

                query = "SELECT Vuelo.id_vuelo, Aerolinea.Nombre," +
                    " DATE_FORMAT(Vuelo.FechaSalida, '%Y-%m-%d')," +
                    " DATE_FORMAT(Vuelo.FechaLlegada, '%Y-%m-%d')," +
                    " Clase.Descripcion, E1.Nombre, E2.Nombre, " +
                    " Vuelo.HSalida, Vuelo.HLlegada, " +
                    " Vuelo.PrecioUnitario FROM Vuelo" +
                    " INNER JOIN Avion ON Avion.id_avion = Vuelo.id_avion" +
                    " INNER JOIN Aerolinea ON Aerolinea.id_aerolinea = Avion.id_aerolinea" +
                    " INNER JOIN Estado E1 ON E1.id_estado = Vuelo.id_EstadoOrigen" +
                    " INNER JOIN Estado E2 ON E2.id_estado = Vuelo.id_EstadoDestino" +
                    " INNER JOIN Clase ON Clase.id_clase = Vuelo.id_clase";

                if(cBAerolinea.Text != "")
                {
                    query = query + " WHERE Aerolinea.Nombre = '" + cBAerolinea.Text + "'";
                }
                else
                {
                    query = query + " WHERE Aerolinea.Nombre = Aerolinea.Nombre";
                }
                
                if (cBClase.Text != "")
                {
                    query = query + " AND Clase.Descripcion = '" + cBClase.Text + "'";
                }
                else
                {
                    query = query + " AND Clase.Descripcion = Clase.Descripcion";
                }

                if (cBDestino.Text != "")
                {
                    query = query + " AND E2.Nombre = '" + cBDestino.Text + "'";
                }
                else
                {
                    query = query + " AND E2.Nombre = E2.Nombre";
                }

                if (dTP1.Value.ToString("dd/MM/yyyy") != "01/01/2019")
                {
                    query = query + " AND Vuelo.FechaSalida = '" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
                }
                else
                {
                    query = query + " AND Vuelo.FechaSalida = Vuelo.FechaSalida";
                }

                if (Form1.tipoUsuario != "Admin")
                {
                    query += " AND CONCAT(Vuelo.FechaSalida, ' ', Vuelo.HSalida) > (SELECT ADDTIME(CURRENT_TIMESTAMP(), '00:15:00'))";
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
                    MessageBox.Show(this, "No se encuentra ningun vuelo con esas caracteristicas", 
                        "FLIGHT NOT FOUND", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Favor de ingresar bien los datos", 
                    "DATA ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void dGV1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(Form1.tipoUsuario == "Admin")
                {
                    if (this.dGV1.Columns[e.ColumnIndex].Name == "Eliminar")
                    {
                        id_vuelo = Convert.ToInt32(dGV1.CurrentRow.Cells[0].Value);

                        connection = new MySqlConnection(stringConnection);

                        query = "DELETE FROM Vuelo WHERE id_vuelo = " + id_vuelo;

                        command = new MySqlCommand(query, connection);
                        command.CommandTimeout = 60;

                        connection.Open();
                        reader = command.ExecuteReader();

                        connection.Close();

                        loadVuelos();
                    }
                    else
                    {
                        if (e.RowIndex != -1)
                        {
                            id_vuelo = Convert.ToInt32(dGV1.CurrentRow.Cells[0].Value);




                            query = "SELECT asientos FROM Factura WHERE id_vuelo = " + id_vuelo;

                            command = new MySqlCommand(query, connection);
                            command.CommandTimeout = 60;

                            connection.Open();
                            reader = command.ExecuteReader();

                            String aux = "";

                            int p = 0;

                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    aux += reader.GetString(0);
                                }
                            }

                            connection.Close();

                            p = aux.Length/3;


                            if(p != 32)
                            {
                                Trabajador_AgregarPasaje newForm = new Trabajador_AgregarPasaje(id_vuelo, p);
                                newForm.ShowDialog();
                                loadVuelos();

                                loadDestinoItems();
                                loadAerolineaItems();
                                loadClaseItems();

                                cBOrigen.Text = "Guadalajara";
                                cBOrigen.Enabled = false;

                                dTP1.Value = Convert.ToDateTime("01/01/2019");
                            }
                            else
                            {
                                MessageBox.Show(this, "Ya no hay lugares, lo sentimos", "FLIGHT FULLY",
                                    MessageBoxButtons.OK, MessageBoxIcon.None);
                            }
                        }
                        else
                        {
                        }
                    }
                }
                else
                {
                    if (e.RowIndex != -1)
                    {
                        id_vuelo = Convert.ToInt32(dGV1.CurrentRow.Cells[0].Value);






                        query = "SELECT asientos FROM Factura WHERE id_vuelo = " + id_vuelo;

                        command = new MySqlCommand(query, connection);
                        command.CommandTimeout = 60;

                        connection.Open();
                        reader = command.ExecuteReader();

                        String aux = "";

                        int p = 0;

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                aux += reader.GetString(0);
                            }
                        }

                        connection.Close();

                        p = aux.Length / 3;


                        if (p != 32)
                        {
                            Trabajador_AgregarPasaje newForm = new Trabajador_AgregarPasaje(id_vuelo, p);
                            newForm.ShowDialog();
                            loadVuelos();

                            loadDestinoItems();
                            loadAerolineaItems();
                            loadClaseItems();

                            cBOrigen.Text = "Guadalajara";
                            cBOrigen.Enabled = false;

                            dTP1.Value = Convert.ToDateTime("01/01/2019");
                        }
                        else
                        {
                            MessageBox.Show(this, "Ya no hay lugares, lo sentimos", "FLIGHT FULLY",
                                MessageBoxButtons.OK, MessageBoxIcon.None);
                        }
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

        private void bAgregarVuelo_Click(object sender, EventArgs e)
        {
            Admin_AgregarVuelo newForm = new Admin_AgregarVuelo();
            newForm.ShowDialog();

            cBDestino.Text = "";
            cBClase.Text = "";
            cBAerolinea.Text = "";
            dTP1.Value = Convert.ToDateTime("01/01/2019");
            loadVuelos();
        }
        
        void paintCells()
        {
            foreach (DataGridViewRow row in dGV1.Rows)
            {
                try
                {
                    if (row.Cells[4].Value.ToString() == "Primera Clase")
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    else if (row.Cells[4].Value.ToString() == "Ejecutiva")
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

        private void dGV1_Sorted(object sender, EventArgs e)
        {
            paintCells();
        }
    }
}
