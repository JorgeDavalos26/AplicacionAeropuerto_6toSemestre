namespace _16100075_Jorge_AeroMaya_ProyectoFinal
{
    partial class Admin_AgregarVuelo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_AgregarVuelo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pBCancel = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dTP2 = new System.Windows.Forms.DateTimePicker();
            this.dTPLlegada = new System.Windows.Forms.DateTimePicker();
            this.dTPSalida = new System.Windows.Forms.DateTimePicker();
            this.dTP1 = new System.Windows.Forms.DateTimePicker();
            this.cBDestino = new System.Windows.Forms.ComboBox();
            this.tBPrecioUnitario = new System.Windows.Forms.TextBox();
            this.cBPuerta = new System.Windows.Forms.ComboBox();
            this.cBClase = new System.Windows.Forms.ComboBox();
            this.cBAvion = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cBTripulantes = new System.Windows.Forms.ComboBox();
            this.bConfirmar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBCancel)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.BackgroundImage = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.Azul_Marino;
            this.panel1.Controls.Add(this.pBCancel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 40);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pBCancel
            // 
            this.pBCancel.BackgroundImage = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.Azul_Marino;
            this.pBCancel.Image = ((System.Drawing.Image)(resources.GetObject("pBCancel.Image")));
            this.pBCancel.Location = new System.Drawing.Point(954, 3);
            this.pBCancel.Name = "pBCancel";
            this.pBCancel.Size = new System.Drawing.Size(30, 30);
            this.pBCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBCancel.TabIndex = 7;
            this.pBCancel.TabStop = false;
            this.pBCancel.Click += new System.EventHandler(this.pBCancel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.YellowGreen;
            this.panel2.BackgroundImage = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.VerdeLima;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dTP2);
            this.panel2.Controls.Add(this.dTPLlegada);
            this.panel2.Controls.Add(this.dTPSalida);
            this.panel2.Controls.Add(this.dTP1);
            this.panel2.Controls.Add(this.cBDestino);
            this.panel2.Controls.Add(this.tBPrecioUnitario);
            this.panel2.Controls.Add(this.cBPuerta);
            this.panel2.Controls.Add(this.cBClase);
            this.panel2.Controls.Add(this.cBAvion);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cBTripulantes);
            this.panel2.Location = new System.Drawing.Point(12, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(971, 357);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.VerdeLima;
            this.label1.Location = new System.Drawing.Point(818, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 27);
            this.label1.TabIndex = 22;
            this.label1.Text = "Fecha Llegada";
            // 
            // dTP2
            // 
            this.dTP2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTP2.Location = new System.Drawing.Point(823, 65);
            this.dTP2.Name = "dTP2";
            this.dTP2.Size = new System.Drawing.Size(121, 22);
            this.dTP2.TabIndex = 21;
            // 
            // dTPLlegada
            // 
            this.dTPLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dTPLlegada.Location = new System.Drawing.Point(671, 271);
            this.dTPLlegada.Name = "dTPLlegada";
            this.dTPLlegada.Size = new System.Drawing.Size(134, 22);
            this.dTPLlegada.TabIndex = 20;
            // 
            // dTPSalida
            // 
            this.dTPSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dTPSalida.Location = new System.Drawing.Point(671, 165);
            this.dTPSalida.Name = "dTPSalida";
            this.dTPSalida.Size = new System.Drawing.Size(134, 22);
            this.dTPSalida.TabIndex = 19;
            // 
            // dTP1
            // 
            this.dTP1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTP1.Location = new System.Drawing.Point(671, 65);
            this.dTP1.Name = "dTP1";
            this.dTP1.Size = new System.Drawing.Size(125, 22);
            this.dTP1.TabIndex = 18;
            // 
            // cBDestino
            // 
            this.cBDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBDestino.FormattingEnabled = true;
            this.cBDestino.Location = new System.Drawing.Point(386, 165);
            this.cBDestino.Name = "cBDestino";
            this.cBDestino.Size = new System.Drawing.Size(221, 33);
            this.cBDestino.TabIndex = 17;
            // 
            // tBPrecioUnitario
            // 
            this.tBPrecioUnitario.Location = new System.Drawing.Point(386, 273);
            this.tBPrecioUnitario.Multiline = true;
            this.tBPrecioUnitario.Name = "tBPrecioUnitario";
            this.tBPrecioUnitario.Size = new System.Drawing.Size(221, 33);
            this.tBPrecioUnitario.TabIndex = 16;
            this.tBPrecioUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBPrecioUnitario_KeyPress);
            // 
            // cBPuerta
            // 
            this.cBPuerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBPuerta.FormattingEnabled = true;
            this.cBPuerta.Location = new System.Drawing.Point(386, 65);
            this.cBPuerta.Name = "cBPuerta";
            this.cBPuerta.Size = new System.Drawing.Size(221, 33);
            this.cBPuerta.TabIndex = 15;
            // 
            // cBClase
            // 
            this.cBClase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBClase.FormattingEnabled = true;
            this.cBClase.Location = new System.Drawing.Point(35, 271);
            this.cBClase.Name = "cBClase";
            this.cBClase.Size = new System.Drawing.Size(266, 33);
            this.cBClase.TabIndex = 14;
            // 
            // cBAvion
            // 
            this.cBAvion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBAvion.FormattingEnabled = true;
            this.cBAvion.Location = new System.Drawing.Point(29, 167);
            this.cBAvion.Name = "cBAvion";
            this.cBAvion.Size = new System.Drawing.Size(272, 33);
            this.cBAvion.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Image = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.VerdeLima;
            this.label11.Location = new System.Drawing.Point(381, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 27);
            this.label11.TabIndex = 12;
            this.label11.Text = "Destino";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Image = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.VerdeLima;
            this.label10.Location = new System.Drawing.Point(666, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 27);
            this.label10.TabIndex = 11;
            this.label10.Text = "Fecha Salida";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Image = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.VerdeLima;
            this.label9.Location = new System.Drawing.Point(381, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 27);
            this.label9.TabIndex = 10;
            this.label9.Text = "Precio p/u";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Image = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.VerdeLima;
            this.label8.Location = new System.Drawing.Point(666, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 27);
            this.label8.TabIndex = 9;
            this.label8.Text = "Hora Llegada";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Image = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.VerdeLima;
            this.label7.Location = new System.Drawing.Point(666, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 27);
            this.label7.TabIndex = 8;
            this.label7.Text = "Hora Salida";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.VerdeLima;
            this.label6.Location = new System.Drawing.Point(381, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 27);
            this.label6.TabIndex = 7;
            this.label6.Text = "Puerta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.VerdeLima;
            this.label4.Location = new System.Drawing.Point(30, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Clase";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.VerdeLima;
            this.label3.Location = new System.Drawing.Point(24, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Avion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.VerdeLima;
            this.label2.Location = new System.Drawing.Point(24, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Num. Equipo de Tripulantes";
            // 
            // cBTripulantes
            // 
            this.cBTripulantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBTripulantes.FormattingEnabled = true;
            this.cBTripulantes.Location = new System.Drawing.Point(29, 65);
            this.cBTripulantes.Name = "cBTripulantes";
            this.cBTripulantes.Size = new System.Drawing.Size(272, 33);
            this.cBTripulantes.TabIndex = 1;
            // 
            // bConfirmar
            // 
            this.bConfirmar.BackColor = System.Drawing.Color.PaleGreen;
            this.bConfirmar.BackgroundImage = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.Aquamarina;
            this.bConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bConfirmar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bConfirmar.Location = new System.Drawing.Point(12, 417);
            this.bConfirmar.Name = "bConfirmar";
            this.bConfirmar.Size = new System.Drawing.Size(971, 55);
            this.bConfirmar.TabIndex = 0;
            this.bConfirmar.Text = "Confirmar";
            this.bConfirmar.UseVisualStyleBackColor = false;
            this.bConfirmar.Click += new System.EventHandler(this.bConfirmar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.BackgroundImage = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.Azul_Marino;
            this.panel3.Location = new System.Drawing.Point(0, 489);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1010, 16);
            this.panel3.TabIndex = 8;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Admin_AgregarVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 504);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bConfirmar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin_AgregarVuelo";
            this.Text = "Admin_AgregarModificarVuelo";
            this.Load += new System.EventHandler(this.Admin_AgregarVuelo_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBCancel)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pBCancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bConfirmar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cBTripulantes;
        private System.Windows.Forms.DateTimePicker dTPLlegada;
        private System.Windows.Forms.DateTimePicker dTPSalida;
        private System.Windows.Forms.DateTimePicker dTP1;
        private System.Windows.Forms.ComboBox cBDestino;
        private System.Windows.Forms.TextBox tBPrecioUnitario;
        private System.Windows.Forms.ComboBox cBPuerta;
        private System.Windows.Forms.ComboBox cBClase;
        private System.Windows.Forms.ComboBox cBAvion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dTP2;
    }
}