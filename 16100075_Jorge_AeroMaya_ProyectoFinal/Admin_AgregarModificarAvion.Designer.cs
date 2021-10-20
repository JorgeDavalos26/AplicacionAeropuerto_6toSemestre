namespace _16100075_Jorge_AeroMaya_ProyectoFinal
{
    partial class Admin_AgregarModificarAvion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_AgregarModificarAvion));
            this.pSuperior = new System.Windows.Forms.Panel();
            this.pBCancel = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cBAerolinea = new System.Windows.Forms.ComboBox();
            this.tBNombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bConfirmar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBCancel)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pSuperior
            // 
            this.pSuperior.BackColor = System.Drawing.Color.RoyalBlue;
            this.pSuperior.BackgroundImage = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.Azul_Marino;
            this.pSuperior.Controls.Add(this.pBCancel);
            this.pSuperior.Location = new System.Drawing.Point(-2, -2);
            this.pSuperior.Name = "pSuperior";
            this.pSuperior.Size = new System.Drawing.Size(387, 40);
            this.pSuperior.TabIndex = 4;
            this.pSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pSuperior_MouseDown);
            // 
            // pBCancel
            // 
            this.pBCancel.BackgroundImage = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.Azul_Marino;
            this.pBCancel.Image = ((System.Drawing.Image)(resources.GetObject("pBCancel.Image")));
            this.pBCancel.Location = new System.Drawing.Point(325, 3);
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
            this.panel2.Controls.Add(this.cBAerolinea);
            this.panel2.Controls.Add(this.tBNombre);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(341, 245);
            this.panel2.TabIndex = 6;
            // 
            // cBAerolinea
            // 
            this.cBAerolinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBAerolinea.FormattingEnabled = true;
            this.cBAerolinea.Location = new System.Drawing.Point(29, 177);
            this.cBAerolinea.Name = "cBAerolinea";
            this.cBAerolinea.Size = new System.Drawing.Size(283, 33);
            this.cBAerolinea.TabIndex = 21;
            // 
            // tBNombre
            // 
            this.tBNombre.Location = new System.Drawing.Point(29, 65);
            this.tBNombre.Multiline = true;
            this.tBNombre.Name = "tBNombre";
            this.tBNombre.Size = new System.Drawing.Size(283, 33);
            this.tBNombre.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Image = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.VerdeLima;
            this.label9.Location = new System.Drawing.Point(24, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 27);
            this.label9.TabIndex = 10;
            this.label9.Text = "Aerolinea";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.VerdeLima;
            this.label2.Location = new System.Drawing.Point(24, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // bConfirmar
            // 
            this.bConfirmar.BackColor = System.Drawing.Color.PaleGreen;
            this.bConfirmar.BackgroundImage = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.Aquamarina;
            this.bConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bConfirmar.Location = new System.Drawing.Point(12, 302);
            this.bConfirmar.Name = "bConfirmar";
            this.bConfirmar.Size = new System.Drawing.Size(341, 55);
            this.bConfirmar.TabIndex = 0;
            this.bConfirmar.Text = "Confirmar";
            this.bConfirmar.UseVisualStyleBackColor = false;
            this.bConfirmar.Click += new System.EventHandler(this.bConfirmar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.BackgroundImage = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.Azul_Marino;
            this.panel3.Location = new System.Drawing.Point(-2, 363);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(368, 23);
            this.panel3.TabIndex = 8;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Admin_AgregarModificarAvion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 380);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pSuperior);
            this.Controls.Add(this.bConfirmar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin_AgregarModificarAvion";
            this.Text = "Admin_AgregarModificarAvion";
            this.Load += new System.EventHandler(this.Admin_AgregarModificarAvion_Load);
            this.pSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBCancel)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pSuperior;
        private System.Windows.Forms.PictureBox pBCancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tBNombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bConfirmar;
        private System.Windows.Forms.ComboBox cBAerolinea;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}