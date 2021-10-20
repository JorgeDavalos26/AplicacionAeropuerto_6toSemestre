namespace _16100075_Jorge_AeroMaya_ProyectoFinal
{
    partial class Admin_VerPasajeros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_VerPasajeros));
            this.pSuperior = new System.Windows.Forms.Panel();
            this.pBCancel = new System.Windows.Forms.PictureBox();
            this.dGV1 = new System.Windows.Forms.DataGridView();
            this.bAgregarPasajero = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // pSuperior
            // 
            this.pSuperior.BackColor = System.Drawing.Color.RoyalBlue;
            this.pSuperior.BackgroundImage = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.Azul_Marino;
            this.pSuperior.Controls.Add(this.pBCancel);
            this.pSuperior.Location = new System.Drawing.Point(0, 0);
            this.pSuperior.Name = "pSuperior";
            this.pSuperior.Size = new System.Drawing.Size(1423, 40);
            this.pSuperior.TabIndex = 2;
            this.pSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pSuperior_MouseDown_1);
            // 
            // pBCancel
            // 
            this.pBCancel.BackgroundImage = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.Azul_Marino;
            this.pBCancel.Image = ((System.Drawing.Image)(resources.GetObject("pBCancel.Image")));
            this.pBCancel.Location = new System.Drawing.Point(1375, 0);
            this.pBCancel.Name = "pBCancel";
            this.pBCancel.Size = new System.Drawing.Size(30, 30);
            this.pBCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBCancel.TabIndex = 7;
            this.pBCancel.TabStop = false;
            this.pBCancel.Click += new System.EventHandler(this.pBCancel_Click);
            // 
            // dGV1
            // 
            this.dGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV1.BackgroundColor = System.Drawing.Color.Azure;
            this.dGV1.ColumnHeadersHeight = 30;
            this.dGV1.Location = new System.Drawing.Point(12, 53);
            this.dGV1.Name = "dGV1";
            this.dGV1.RowHeadersWidth = 70;
            this.dGV1.RowTemplate.Height = 24;
            this.dGV1.Size = new System.Drawing.Size(1393, 535);
            this.dGV1.TabIndex = 3;
            this.dGV1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV1_CellClick);
            this.dGV1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dGV1_CellPainting);
            // 
            // bAgregarPasajero
            // 
            this.bAgregarPasajero.BackColor = System.Drawing.Color.YellowGreen;
            this.bAgregarPasajero.BackgroundImage = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.Aquamarina;
            this.bAgregarPasajero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAgregarPasajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAgregarPasajero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bAgregarPasajero.Location = new System.Drawing.Point(12, 606);
            this.bAgregarPasajero.Name = "bAgregarPasajero";
            this.bAgregarPasajero.Size = new System.Drawing.Size(1393, 46);
            this.bAgregarPasajero.TabIndex = 4;
            this.bAgregarPasajero.Text = "Dar de alta un Pasajero";
            this.bAgregarPasajero.UseVisualStyleBackColor = false;
            this.bAgregarPasajero.Click += new System.EventHandler(this.bAgregarPasajero_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.BackgroundImage = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.Azul_Marino;
            this.panel1.Location = new System.Drawing.Point(0, 669);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1423, 22);
            this.panel1.TabIndex = 8;
            // 
            // Admin_VerPasajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 689);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bAgregarPasajero);
            this.Controls.Add(this.dGV1);
            this.Controls.Add(this.pSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin_VerPasajeros";
            this.Text = "Admin_VerPasajeros";
            this.Load += new System.EventHandler(this.Admin_VerPasajeros_Load);
            this.pSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pSuperior;
        private System.Windows.Forms.PictureBox pBCancel;
        private System.Windows.Forms.DataGridView dGV1;
        private System.Windows.Forms.Button bAgregarPasajero;
        private System.Windows.Forms.Panel panel1;
    }
}