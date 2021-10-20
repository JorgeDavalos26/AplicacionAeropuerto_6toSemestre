namespace _16100075_Jorge_AeroMaya_ProyectoFinal
{
    partial class Admin_VerEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_VerEmpleados));
            this.pSuperior = new System.Windows.Forms.Panel();
            this.pBCancel = new System.Windows.Forms.PictureBox();
            this.dGV1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bAgregarEmpleado = new System.Windows.Forms.Button();
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
            this.pSuperior.Location = new System.Drawing.Point(-2, 0);
            this.pSuperior.Name = "pSuperior";
            this.pSuperior.Size = new System.Drawing.Size(1427, 40);
            this.pSuperior.TabIndex = 4;
            this.pSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pSuperior_MouseDown);
            // 
            // pBCancel
            // 
            this.pBCancel.BackgroundImage = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.Azul_Marino;
            this.pBCancel.Image = ((System.Drawing.Image)(resources.GetObject("pBCancel.Image")));
            this.pBCancel.Location = new System.Drawing.Point(1383, 0);
            this.pBCancel.Name = "pBCancel";
            this.pBCancel.Size = new System.Drawing.Size(30, 30);
            this.pBCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBCancel.TabIndex = 7;
            this.pBCancel.TabStop = false;
            this.pBCancel.Click += new System.EventHandler(this.pBCancel_Click_1);
            // 
            // dGV1
            // 
            this.dGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV1.BackgroundColor = System.Drawing.Color.Azure;
            this.dGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV1.Location = new System.Drawing.Point(12, 53);
            this.dGV1.Name = "dGV1";
            this.dGV1.RowTemplate.Height = 24;
            this.dGV1.Size = new System.Drawing.Size(1399, 574);
            this.dGV1.TabIndex = 5;
            this.dGV1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV1_CellClick_1);
            this.dGV1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dGV1_CellPainting_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.BackgroundImage = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.Azul_Marino;
            this.panel2.Location = new System.Drawing.Point(-2, 708);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1437, 22);
            this.panel2.TabIndex = 9;
            // 
            // bAgregarEmpleado
            // 
            this.bAgregarEmpleado.BackColor = System.Drawing.Color.YellowGreen;
            this.bAgregarEmpleado.BackgroundImage = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.Aquamarina;
            this.bAgregarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAgregarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAgregarEmpleado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bAgregarEmpleado.Location = new System.Drawing.Point(12, 644);
            this.bAgregarEmpleado.Name = "bAgregarEmpleado";
            this.bAgregarEmpleado.Size = new System.Drawing.Size(1399, 46);
            this.bAgregarEmpleado.TabIndex = 10;
            this.bAgregarEmpleado.Text = "Dar de alta un Empleado";
            this.bAgregarEmpleado.UseVisualStyleBackColor = false;
            this.bAgregarEmpleado.Click += new System.EventHandler(this.bAgregarEmpleado_Click);
            // 
            // Admin_VerEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 729);
            this.Controls.Add(this.bAgregarEmpleado);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dGV1);
            this.Controls.Add(this.pSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin_VerEmpleados";
            this.Text = "Admin_VerEmpleados";
            this.Load += new System.EventHandler(this.Admin_VerEmpleados_Load);
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
        private System.Windows.Forms.Button bAgregarEmpleado;
    }
}