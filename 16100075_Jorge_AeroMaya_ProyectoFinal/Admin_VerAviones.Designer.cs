namespace _16100075_Jorge_AeroMaya_ProyectoFinal
{
    partial class Admin_VerAviones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_VerAviones));
            this.pSuperior = new System.Windows.Forms.Panel();
            this.pBCancel = new System.Windows.Forms.PictureBox();
            this.dGV1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bAgregarAvion = new System.Windows.Forms.Button();
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
            this.pSuperior.Location = new System.Drawing.Point(0, -1);
            this.pSuperior.Name = "pSuperior";
            this.pSuperior.Size = new System.Drawing.Size(583, 40);
            this.pSuperior.TabIndex = 5;
            this.pSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pSuperior_MouseDown);
            // 
            // pBCancel
            // 
            this.pBCancel.BackgroundImage = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.Azul_Marino;
            this.pBCancel.Image = ((System.Drawing.Image)(resources.GetObject("pBCancel.Image")));
            this.pBCancel.Location = new System.Drawing.Point(529, 3);
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
            this.dGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV1.Location = new System.Drawing.Point(12, 53);
            this.dGV1.Name = "dGV1";
            this.dGV1.RowTemplate.Height = 24;
            this.dGV1.Size = new System.Drawing.Size(547, 400);
            this.dGV1.TabIndex = 6;
            this.dGV1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV1_CellClick);
            this.dGV1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dGV1_CellPainting);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.BackgroundImage = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.Azul_Marino;
            this.panel2.Location = new System.Drawing.Point(0, 511);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(607, 22);
            this.panel2.TabIndex = 8;
            // 
            // bAgregarAvion
            // 
            this.bAgregarAvion.BackColor = System.Drawing.Color.YellowGreen;
            this.bAgregarAvion.BackgroundImage = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.Aquamarina;
            this.bAgregarAvion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAgregarAvion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAgregarAvion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bAgregarAvion.Location = new System.Drawing.Point(11, 459);
            this.bAgregarAvion.Name = "bAgregarAvion";
            this.bAgregarAvion.Size = new System.Drawing.Size(548, 46);
            this.bAgregarAvion.TabIndex = 11;
            this.bAgregarAvion.Text = "Agregar un nuevo Avion";
            this.bAgregarAvion.UseVisualStyleBackColor = false;
            this.bAgregarAvion.Click += new System.EventHandler(this.bAgregarAvion_Click);
            // 
            // Admin_VerAviones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 525);
            this.Controls.Add(this.bAgregarAvion);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dGV1);
            this.Controls.Add(this.pSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin_VerAviones";
            this.Text = "Admin_VerAviones";
            this.Load += new System.EventHandler(this.Admin_VerAviones_Load);
            this.pSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pSuperior;
        private System.Windows.Forms.PictureBox pBCancel;
        private System.Windows.Forms.DataGridView dGV1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bAgregarAvion;
    }
}