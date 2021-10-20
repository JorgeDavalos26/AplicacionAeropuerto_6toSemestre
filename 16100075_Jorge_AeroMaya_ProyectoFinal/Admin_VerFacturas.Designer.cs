namespace _16100075_Jorge_AeroMaya_ProyectoFinal
{
    partial class Admin_VerFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_VerFacturas));
            this.dGV1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bReset = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cBAerolinea = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBNombreCompleto = new System.Windows.Forms.ComboBox();
            this.cBClase = new System.Windows.Forms.ComboBox();
            this.pSuperior = new System.Windows.Forms.Panel();
            this.pBCancel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBCancel)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV1
            // 
            this.dGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV1.BackgroundColor = System.Drawing.Color.Azure;
            this.dGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dGV1.Location = new System.Drawing.Point(13, 170);
            this.dGV1.Name = "dGV1";
            this.dGV1.RowTemplate.Height = 24;
            this.dGV1.Size = new System.Drawing.Size(1917, 702);
            this.dGV1.TabIndex = 2;
            this.dGV1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV1_CellClick);
            this.dGV1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dGV1_CellPainting);
            this.dGV1.Sorted += new System.EventHandler(this.dGV1_Sorted_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.BackgroundImage = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.Azul_Marino;
            this.panel2.Location = new System.Drawing.Point(-2, 878);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1946, 24);
            this.panel2.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.YellowGreen;
            this.groupBox1.BackgroundImage = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.VerdeLima;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.bReset);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cBAerolinea);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cBNombreCompleto);
            this.groupBox1.Controls.Add(this.cBClase);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1918, 111);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.Azul_Marino;
            this.button1.Location = new System.Drawing.Point(1190, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 65);
            this.button1.TabIndex = 12;
            this.button1.Text = "Aplicar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bReset
            // 
            this.bReset.Image = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.Blanco;
            this.bReset.Location = new System.Drawing.Point(1353, 33);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(142, 65);
            this.bReset.TabIndex = 11;
            this.bReset.Text = "Reset";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Image = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.VerdeLima;
            this.label4.Location = new System.Drawing.Point(859, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "Aerolinea";
            // 
            // cBAerolinea
            // 
            this.cBAerolinea.FormattingEnabled = true;
            this.cBAerolinea.Location = new System.Drawing.Point(864, 60);
            this.cBAerolinea.Name = "cBAerolinea";
            this.cBAerolinea.Size = new System.Drawing.Size(269, 35);
            this.cBAerolinea.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Image = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.VerdeLima;
            this.label2.Location = new System.Drawing.Point(523, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Clase";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.VerdeLima;
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre Completo";
            // 
            // cBNombreCompleto
            // 
            this.cBNombreCompleto.FormattingEnabled = true;
            this.cBNombreCompleto.Location = new System.Drawing.Point(34, 60);
            this.cBNombreCompleto.Name = "cBNombreCompleto";
            this.cBNombreCompleto.Size = new System.Drawing.Size(382, 35);
            this.cBNombreCompleto.TabIndex = 1;
            // 
            // cBClase
            // 
            this.cBClase.FormattingEnabled = true;
            this.cBClase.Location = new System.Drawing.Point(528, 60);
            this.cBClase.Name = "cBClase";
            this.cBClase.Size = new System.Drawing.Size(235, 35);
            this.cBClase.TabIndex = 0;
            // 
            // pSuperior
            // 
            this.pSuperior.BackColor = System.Drawing.Color.RoyalBlue;
            this.pSuperior.BackgroundImage = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.Azul_Marino;
            this.pSuperior.Controls.Add(this.pBCancel);
            this.pSuperior.Location = new System.Drawing.Point(-2, -1);
            this.pSuperior.Name = "pSuperior";
            this.pSuperior.Size = new System.Drawing.Size(1954, 40);
            this.pSuperior.TabIndex = 4;
            this.pSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pSuperior_MouseDown);
            // 
            // pBCancel
            // 
            this.pBCancel.BackgroundImage = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.Azul_Marino;
            this.pBCancel.Image = ((System.Drawing.Image)(resources.GetObject("pBCancel.Image")));
            this.pBCancel.Location = new System.Drawing.Point(1902, 3);
            this.pBCancel.Name = "pBCancel";
            this.pBCancel.Size = new System.Drawing.Size(30, 30);
            this.pBCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBCancel.TabIndex = 7;
            this.pBCancel.TabStop = false;
            this.pBCancel.Click += new System.EventHandler(this.pBCancel_Click);
            // 
            // Admin_VerFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1942, 897);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dGV1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin_VerFacturas";
            this.Text = "Admin_VerFacturas";
            this.Load += new System.EventHandler(this.Admin_VerFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBCancel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pSuperior;
        private System.Windows.Forms.PictureBox pBCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBAerolinea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBNombreCompleto;
        private System.Windows.Forms.ComboBox cBClase;
        private System.Windows.Forms.DataGridView dGV1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.Button button1;
    }
}