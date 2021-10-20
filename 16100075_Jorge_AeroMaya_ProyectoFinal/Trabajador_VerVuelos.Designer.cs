namespace _16100075_Jorge_AeroMaya_ProyectoFinal
{
    partial class Trabajador_VerVuelos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trabajador_VerVuelos));
            this.pSuperior = new System.Windows.Forms.Panel();
            this.pBCancel = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bReset = new System.Windows.Forms.Button();
            this.bBuscar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cBClase = new System.Windows.Forms.ComboBox();
            this.cBAerolinea = new System.Windows.Forms.ComboBox();
            this.dTP1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBOrigen = new System.Windows.Forms.ComboBox();
            this.cBDestino = new System.Windows.Forms.ComboBox();
            this.dGV1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bAgregarVuelo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBCancel)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pSuperior
            // 
            this.pSuperior.BackColor = System.Drawing.Color.RoyalBlue;
            this.pSuperior.BackgroundImage = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.Azul_Marino;
            this.pSuperior.Controls.Add(this.pBCancel);
            this.pSuperior.Location = new System.Drawing.Point(0, 0);
            this.pSuperior.Name = "pSuperior";
            this.pSuperior.Size = new System.Drawing.Size(1392, 40);
            this.pSuperior.TabIndex = 1;
            this.pSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pSuperior_MouseDown);
            // 
            // pBCancel
            // 
            this.pBCancel.BackgroundImage = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.Azul_Marino;
            this.pBCancel.Image = ((System.Drawing.Image)(resources.GetObject("pBCancel.Image")));
            this.pBCancel.Location = new System.Drawing.Point(1345, 7);
            this.pBCancel.Name = "pBCancel";
            this.pBCancel.Size = new System.Drawing.Size(30, 30);
            this.pBCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBCancel.TabIndex = 7;
            this.pBCancel.TabStop = false;
            this.pBCancel.Click += new System.EventHandler(this.pBCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.YellowGreen;
            this.groupBox1.BackgroundImage = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.VerdeLima;
            this.groupBox1.Controls.Add(this.bReset);
            this.groupBox1.Controls.Add(this.bBuscar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cBClase);
            this.groupBox1.Controls.Add(this.cBAerolinea);
            this.groupBox1.Controls.Add(this.dTP1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cBOrigen);
            this.groupBox1.Controls.Add(this.cBDestino);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1189, 152);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar";
            // 
            // bReset
            // 
            this.bReset.BackgroundImage = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.Blanco;
            this.bReset.Location = new System.Drawing.Point(1007, 23);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(164, 52);
            this.bReset.TabIndex = 11;
            this.bReset.Text = "Reset";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // bBuscar
            // 
            this.bBuscar.BackgroundImage = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.Azul_Marino;
            this.bBuscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bBuscar.Location = new System.Drawing.Point(1007, 81);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(164, 54);
            this.bBuscar.TabIndex = 10;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Image = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.VerdeLima;
            this.label5.Location = new System.Drawing.Point(419, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 27);
            this.label5.TabIndex = 9;
            this.label5.Text = "Clase";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Image = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.VerdeLima;
            this.label4.Location = new System.Drawing.Point(419, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "Aerolinea";
            // 
            // cBClase
            // 
            this.cBClase.FormattingEnabled = true;
            this.cBClase.Location = new System.Drawing.Point(533, 47);
            this.cBClase.Name = "cBClase";
            this.cBClase.Size = new System.Drawing.Size(227, 35);
            this.cBClase.TabIndex = 7;
            // 
            // cBAerolinea
            // 
            this.cBAerolinea.FormattingEnabled = true;
            this.cBAerolinea.Location = new System.Drawing.Point(533, 100);
            this.cBAerolinea.Name = "cBAerolinea";
            this.cBAerolinea.Size = new System.Drawing.Size(227, 35);
            this.cBAerolinea.TabIndex = 6;
            // 
            // dTP1
            // 
            this.dTP1.CalendarFont = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTP1.CustomFormat = "yyyy/MM/dd";
            this.dTP1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTP1.Location = new System.Drawing.Point(810, 100);
            this.dTP1.Name = "dTP1";
            this.dTP1.Size = new System.Drawing.Size(166, 34);
            this.dTP1.TabIndex = 5;
            this.dTP1.Value = new System.DateTime(2019, 5, 28, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Image = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.VerdeLima;
            this.label3.Location = new System.Drawing.Point(827, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha Salida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Image = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.VerdeLima;
            this.label2.Location = new System.Drawing.Point(23, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destino";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.VerdeLima;
            this.label1.Location = new System.Drawing.Point(23, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Origen";
            // 
            // cBOrigen
            // 
            this.cBOrigen.FormattingEnabled = true;
            this.cBOrigen.Location = new System.Drawing.Point(123, 50);
            this.cBOrigen.Name = "cBOrigen";
            this.cBOrigen.Size = new System.Drawing.Size(261, 35);
            this.cBOrigen.TabIndex = 1;
            // 
            // cBDestino
            // 
            this.cBDestino.FormattingEnabled = true;
            this.cBDestino.Location = new System.Drawing.Point(123, 100);
            this.cBDestino.Name = "cBDestino";
            this.cBDestino.Size = new System.Drawing.Size(261, 35);
            this.cBDestino.TabIndex = 0;
            // 
            // dGV1
            // 
            this.dGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGV1.BackgroundColor = System.Drawing.Color.Azure;
            this.dGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV1.Location = new System.Drawing.Point(12, 242);
            this.dGV1.Name = "dGV1";
            this.dGV1.RowTemplate.Height = 24;
            this.dGV1.Size = new System.Drawing.Size(1363, 578);
            this.dGV1.TabIndex = 3;
            this.dGV1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV1_CellClick);
            this.dGV1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dGV1_CellPainting);
            this.dGV1.Sorted += new System.EventHandler(this.dGV1_Sorted);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.BackgroundImage = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.Azul_Marino;
            this.panel2.Location = new System.Drawing.Point(0, 838);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1392, 17);
            this.panel2.TabIndex = 8;
            // 
            // bAgregarVuelo
            // 
            this.bAgregarVuelo.BackgroundImage = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.Azul_Marino;
            this.bAgregarVuelo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bAgregarVuelo.Location = new System.Drawing.Point(17, 23);
            this.bAgregarVuelo.Name = "bAgregarVuelo";
            this.bAgregarVuelo.Size = new System.Drawing.Size(136, 112);
            this.bAgregarVuelo.TabIndex = 11;
            this.bAgregarVuelo.Text = "Crear Vuelo";
            this.bAgregarVuelo.UseVisualStyleBackColor = true;
            this.bAgregarVuelo.Click += new System.EventHandler(this.bAgregarVuelo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.YellowGreen;
            this.groupBox2.BackgroundImage = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.VerdeLima;
            this.groupBox2.Controls.Add(this.bAgregarVuelo);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1207, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 152);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // Trabajador_VerVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 850);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dGV1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Trabajador_VerVuelos";
            this.Text = "Trabajador_VerVuelos";
            this.Load += new System.EventHandler(this.Trabajador_VerVuelos_Load);
            this.pSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBCancel)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pSuperior;
        private System.Windows.Forms.PictureBox pBCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cBDestino;
        private System.Windows.Forms.DataGridView dGV1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBOrigen;
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBClase;
        private System.Windows.Forms.ComboBox cBAerolinea;
        private System.Windows.Forms.DateTimePicker dTP1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bAgregarVuelo;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}