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
using System.Globalization;
using System.Diagnostics;

namespace _16100075_Jorge_AeroMaya_ProyectoFinal
{
    public partial class Trabajador_AgregarPasaje : Form
    {
        public Trabajador_AgregarPasaje(int _id_vuelo, int _numAsientos)
        {
            InitializeComponent();

            if(_id_vuelo != 0)
            {
                id_vuelo = _id_vuelo;
            }

            numAsientos = _numAsientos;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWind, int wMsg, int wParam, int lParam);

        int id_vuelo, id_pasajero, id_tarjeta, numAsientos;

        String stringConnection = "SERVER=localhost;" + "DATABASE=aeromayabd;" + "UID=root;" + "PASSWORD=;";

        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataReader reader;

        String query;

        bool userExist = false;

        static public TextBox tB;
        static public NumericUpDown nUD;

        static public Boolean boletos = false;

        private void pBCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bBuscar_MouseHover(object sender, EventArgs e)
        {
            bBuscar.Image = Properties.Resources.Azul_Marino;
        }

        private void bBuscar_MouseLeave(object sender, EventArgs e)
        {
            bBuscar.Image = Properties.Resources.VerdeLima;
        }

        private void pSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Trabajador_AgregarPasaje_Load(object sender, EventArgs e)
        {
            if((32-numAsientos) < 10)
            {
                nUD1.Maximum = 32 - numAsientos;
            }

            nUD1.Value = 1;
            nUD = new NumericUpDown();
            nUD = nUD1;
            tB = new TextBox();
            tB = tBAsientos;

            tBAeropuerto.Enabled = false;
            tBNombrePasajero.Enabled = false;
            tBNumVuelo.Enabled = false;
            tBAerolinea.Enabled = false;
            tBClase.Enabled = false;
            tBFechaSalida.Enabled = false;
            tBFechaLlegada.Enabled = false;
            tBHoraSalida.Enabled = false;
            tBHoraLlegada.Enabled = false;
            tBOrigen.Enabled = false;
            tBDestino.Enabled = false;
            tBPuerta.Enabled = false;
            tBAsientos.Enabled = false;
            bSeleccionar.Enabled = false;
            nUD1.Enabled = false;
            bAgregar.Enabled = false;
            tBTarjeta.Enabled = false;

            loadPasajeros();

            pPasaje.BackgroundImage = Properties.Resources.LightGrey;

            this.Location = new Point(350, 80);
        }

        void loadPasajeros()
        {
            try
            {
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
                        cBPasajero.Items.Add(reader.GetString(0));
                    }
                }
            }
            catch(Exception)
            {

            }

            
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();

                userExist = false;

                connection = new MySqlConnection(stringConnection);

                query = "SELECT id_pasajero FROM Pasajero WHERE Nombre = '" + tBNombre.Text + "'" +
                    " AND Apellido = '" + tBApellidos.Text + "'";

                command = new MySqlCommand(query, connection);
                command.CommandTimeout = 60;

                connection.Open();
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        id_pasajero = Convert.ToInt32(reader.GetString(0));
                        userExist = true;
                    }
                }

                connection.Close();

                if (userExist)
                {
                    MessageBox.Show("Pasajero ya existe en Base de Datos");
                }
                else
                {
                    if(tBNombre.Text != "" && tBApellidos.Text != "")
                    {
                        if (ComprobarFormatoEmail(tBCorreo.Text))
                        {
                            if ((tBTelefono.Text.ToString()).Length >= 8 || 
                                (tBTelefono.Text.ToString()).Length <= 10)
                            {
                                if (Convert.ToInt32(tBEdad.Text) < 110)
                                {
                                    query = "INSERT INTO Pasajero " +
                                            " VALUES (0, '" + tBNombre.Text + "', '" + tBApellidos.Text + "', '"
                                            + tBCorreo.Text + "', " + Convert.ToDouble(tBTelefono.Text) + ", " +
                                            Convert.ToInt32(tBEdad.Text) + ")";

                                    command = new MySqlCommand(query, connection);
                                    command.CommandTimeout = 60;

                                    connection.Open();
                                    reader = command.ExecuteReader();

                                    connection.Close();



                                    connection = new MySqlConnection(stringConnection);

                                    query = "SELECT id_pasajero FROM Pasajero WHERE Nombre = '" + tBNombre.Text + "'" +
                                        " AND Apellido = '" + tBApellidos.Text + "'";

                                    command = new MySqlCommand(query, connection);
                                    command.CommandTimeout = 60;

                                    connection.Open();
                                    reader = command.ExecuteReader();

                                    if (reader.HasRows)
                                    {
                                        while (reader.Read())
                                        {
                                            id_pasajero = Convert.ToInt32(reader.GetString(0));
                                        }
                                    }

                                    connection.Close();

                                    cBPasajero.Text = "";

                                    MessageBox.Show("Pasajero se ha dado de alta con exito");
                                }
                                else
                                {
                                    errorProvider1.SetError(tBEdad, "Ingresa una edad valida");
                                    throw new FormatException();
                                }
                            }
                            else
                            {
                                errorProvider1.SetError(tBTelefono, "Ingresa un numero telefono valido");
                                throw new FormatException();
                            }
                        }
                        else
                        {
                            errorProvider1.SetError(tBCorreo, "Ingresa un correo valido");
                            throw new FormatException();
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(tBNombre, "Ingresa nombre y apellidos");
                        throw new FormatException();
                    }
                }

                loadDataBill();

                
            }
            catch (FormatException)
            {

            }
            catch (Exception)
            {
                MessageBox.Show(this, "Favor de llenar bien todos lo campos", 
                    "DATA ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void loadDataBill()
        {
            connection = new MySqlConnection(stringConnection);

            tBAeropuerto.Enabled = true;
            tBNombrePasajero.Enabled = true;
            tBNumVuelo.Enabled = true;
            tBAerolinea.Enabled = true;
            tBClase.Enabled = true;
            tBFechaSalida.Enabled = true;
            tBFechaLlegada.Enabled = true;
            tBHoraSalida.Enabled = true;
            tBHoraLlegada.Enabled = true;
            tBOrigen.Enabled = true;
            tBDestino.Enabled = true;
            tBPuerta.Enabled = true;
            tBAsientos.Enabled = true;
            bSeleccionar.Enabled = true;
            nUD1.Enabled = true;
            bAgregar.Enabled = true;
            tBTarjeta.Enabled = true;

            query = "SELECT Aerolinea.Nombre, Vuelo.FechaSalida, Vuelo.FechaLlegada, Vuelo.HSalida, " +
                " Vuelo.HLlegada, E1.Nombre, E2.Nombre, " +
                " Vuelo.id_vuelo, Puerta.descripcion, " +
                " Clase.descripcion, Vuelo.PrecioUnitario FROM Vuelo" +
                " INNER JOIN Avion ON Avion.id_avion = Vuelo.id_avion" +
                " INNER JOIN Aerolinea ON Aerolinea.id_aerolinea = Avion.id_aerolinea" +
                " INNER JOIN Estado E1 ON E1.id_estado = Vuelo.id_EstadoOrigen" +
                " INNER JOIN Estado E2 ON E2.id_estado = Vuelo.id_EstadoDestino" +
                " INNER JOIN Puerta ON Puerta.id_puerta = Vuelo.id_puerta" +
                " INNER JOIN Clase ON Clase.id_clase = Vuelo.id_clase" +
                " WHERE Vuelo.id_vuelo = " + id_vuelo;

            command = new MySqlCommand(query, connection);
            command.CommandTimeout = 60;

            connection.Open();
            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    tBAerolinea.Text = reader.GetString(0);
                    tBAerolinea.Enabled = false;
                    String aux;
                    aux = reader.GetString(1);
                    tBFechaSalida.Text = Convert.ToDateTime(aux).ToString("yyyy/MM/dd", CultureInfo.InvariantCulture); ;
                    tBFechaSalida.Enabled = false;
                    aux = reader.GetString(2);
                    tBFechaLlegada.Text = Convert.ToDateTime(aux).ToString("yyyy/MM/dd", CultureInfo.InvariantCulture); ;
                    tBFechaLlegada.Enabled = false;
                    tBHoraSalida.Text = reader.GetString(3);
                    tBHoraSalida.Enabled = false;
                    tBHoraLlegada.Text = reader.GetString(4);
                    tBHoraLlegada.Enabled = false;
                    tBOrigen.Text = reader.GetString(5);
                    tBOrigen.Enabled = false;
                    tBDestino.Text = reader.GetString(6);
                    tBDestino.Enabled = false;
                    tBNumVuelo.Text = reader.GetString(7);
                    tBNumVuelo.Enabled = false;
                    tBPuerta.Text = reader.GetString(8);
                    tBPuerta.Enabled = false;
                    tBClase.Text = reader.GetString(9);
                    tBClase.Enabled = false;
                    lPrecioUnitario.Text = reader.GetString(10);
                }
            }

            connection.Close();

            tBAeropuerto.Text = "AeroMaya";
            tBAeropuerto.Enabled = false;

            tBNombrePasajero.Text = tBNombre.Text + " " + tBApellidos.Text;

            if(tBNombrePasajero.Text == " ")
            {
                tBNombrePasajero.Text = cBPasajero.Text;
            }

            tBNombrePasajero.Enabled = false;

            tBNombre.Enabled = false;
            tBApellidos.Enabled = false;
            tBCorreo.Enabled = false;
            tBTelefono.Enabled = false;
            tBEdad.Enabled = false;
            bBuscar.Enabled = false;
            cBPasajero.Enabled = false;
            bPasajero.Enabled = false;

            lPrecioTotal.Text = (Convert.ToDouble(nUD1.Value) * Convert.ToDouble(lPrecioUnitario.Text)).ToString();

            groupBox1.BackgroundImage = Properties.Resources.LightGrey;
            groupBox2.BackgroundImage = Properties.Resources.LightGrey;
            pPasaje.BackgroundImage = Properties.Resources.VerdeLima;
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

        private void bAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();

                if(tBAsientos.Text != "")
                {
                    if(lTarjeta.Text != "Tarjeta")
                    {
                        switch (MessageBox.Show(this, "Estas seguro de comprar los boletos?", "ARE U SURE?",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            case DialogResult.Yes:

                                connection = new MySqlConnection(stringConnection);

                                query = "INSERT INTO Factura VALUES(0," +
                                    id_pasajero + "," +
                                    "1," +
                                    id_vuelo + "," +
                                    id_tarjeta + "," +
                                    nUD1.Value + ",'" +
                                    tBAsientos.Text + "'," +
                                    Convert.ToDouble(lPrecioTotal.Text) + ")";
                                //Convert.ToInt32(lPrecioTotal.Text) + ")";

                                command = new MySqlCommand(query, connection);
                                command.CommandTimeout = 60;

                                connection.Open();
                                reader = command.ExecuteReader();

                                connection.Close();

                                MessageBox.Show(this, "Boleto(s) comprados", "BOLETOS BOUGHT",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                                this.Close();
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show(this, "Favor de ingresar numero de tarjeta valido",
                        "INCORRECT DATA CREDITCARD", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        errorProvider1.SetError(tBTarjeta, "Ingresar numero de tarjeta valido");
                    }
                }
                else
                {
                    MessageBox.Show(this, "Favor de seleccionar tu(s) asiento(s)",
                        "CHOOSE SEATS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    errorProvider1.SetError(bSeleccionar, "Favor de seleccionar tus asientos");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, "Favor de llenar bien todos lo campos",
                    "DATA ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Debug.WriteLine("ERROR: " + ex);
            }
        }

        private void nUD1_ValueChanged(object sender, EventArgs e)
        {
            if(boletos)
            {
                tBAsientos.Text = "";
                boletos = false;
            }

            checkOferta();

            if (nUD1.Value < 1)
            {
                nUD1.Value = 1;
            }
            else
            {
                lSubtotal.Text = (Convert.ToDouble(nUD1.Value) * Convert.ToDouble(lPrecioUnitario.Text)).ToString();

                lDescuento.Text = ((Convert.ToDouble(lSubtotal.Text) * Convert.ToDouble(lPorcentaje.Text))/100).ToString();
                
                lPrecioTotal.Text = (Convert.ToDouble(lSubtotal.Text) - Convert.ToDouble(lDescuento.Text)).ToString();
            }
        }

        void checkOferta()
        {
            connection = new MySqlConnection(stringConnection);

            query = "SELECT Porcentaje FROM Oferta WHERE NumBoletos <= " + nUD1.Value;

            command = new MySqlCommand(query, connection);
            command.CommandTimeout = 60;

            connection.Open();
            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    lPorcentaje.Text = reader.GetString(0);
                }
            }
            else
            {
                lPorcentaje.Text = "0";
            }

            connection.Close();
        }

        private void bPasajero_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();

                if(cBPasajero.Text != "")
                {
                    connection = new MySqlConnection(stringConnection);

                    query = "SELECT ID FROM ComboPasajero WHERE NombreCompleto = '" + cBPasajero.Text + "'";

                    command = new MySqlCommand(query, connection);
                    command.CommandTimeout = 60;

                    connection.Open();
                    reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            id_pasajero = Convert.ToInt32(reader.GetString(0));
                        }
                    }

                    connection.Close();

                    tBNombre.Text = "";
                    tBApellidos.Text = "";
                    tBCorreo.Text = "";
                    tBTelefono.Text = "";
                    tBEdad.Text = "";

                    loadDataBill();
                }
                else
                {
                    errorProvider1.SetError(cBPasajero, "Favor de seleccionar un pasajero");
                }
            }
            catch(Exception)
            {
                MessageBox.Show(this, "Seleccionar bien en combobox",
                    "COMBOBOX ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bPasajero_MouseHover(object sender, EventArgs e)
        {
            bPasajero.Image = Properties.Resources.Azul_Marino;
        }

        private void tBTarjeta_TextChanged(object sender, EventArgs e)
        {
            if(tBTarjeta.Text.Length == 16)
            {
                connection = new MySqlConnection(stringConnection);

                String aux = tBTarjeta.Text;

                String aux2 = aux.Substring(12);

                query = "SELECT id_tarjeta, Descripcion FROM TarjetaCredito " +
                    "WHERE Terminacion = '" + aux2 + "'";

                command = new MySqlCommand(query, connection);
                command.CommandTimeout = 60;

                connection.Open();
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        id_tarjeta = Convert.ToInt32(reader.GetString(0));
                        lTarjeta.Text = reader.GetString(1);
                    }
                }

                connection.Close();
                
            }
            else
            {
                id_tarjeta = 0;
                lTarjeta.Text = "Tarjeta";
            }
            
        }

        private void bPasajero_MouseLeave(object sender, EventArgs e)
        {
            bPasajero.Image = Properties.Resources.VerdeLima;
        }

        private void bSeleccionar_Click(object sender, EventArgs e)
        {
            Trabajador_SeleccionarAsientos newForm = new Trabajador_SeleccionarAsientos(id_vuelo);
            newForm.ShowDialog();
        }
        
        
    }
}
