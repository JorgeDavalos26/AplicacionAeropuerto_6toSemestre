namespace _16100075_Jorge_AeroMaya_ProyectoFinal
{
    partial class Admin_AgregarModificarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_AgregarModificarEmpleado));
            this.pSuperior = new System.Windows.Forms.Panel();
            this.pBCancel = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tBContrasena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBPuesto = new System.Windows.Forms.ComboBox();
            this.tBCorreo = new System.Windows.Forms.TextBox();
            this.tBApellido = new System.Windows.Forms.TextBox();
            this.tBNombre = new System.Windows.Forms.TextBox();
            this.tBTelefono = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.pSuperior.Size = new System.Drawing.Size(712, 40);
            this.pSuperior.TabIndex = 5;
            this.pSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pSuperior_MouseDown);
            // 
            // pBCancel
            // 
            this.pBCancel.BackgroundImage = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.Azul_Marino;
            this.pBCancel.Image = ((System.Drawing.Image)(resources.GetObject("pBCancel.Image")));
            this.pBCancel.Location = new System.Drawing.Point(659, 3);
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
            this.panel2.Controls.Add(this.tBContrasena);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cBPuesto);
            this.panel2.Controls.Add(this.tBCorreo);
            this.panel2.Controls.Add(this.tBApellido);
            this.panel2.Controls.Add(this.tBNombre);
            this.panel2.Controls.Add(this.tBTelefono);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(675, 349);
            this.panel2.TabIndex = 6;
            // 
            // tBContrasena
            // 
            this.tBContrasena.Location = new System.Drawing.Point(329, 271);
            this.tBContrasena.Multiline = true;
            this.tBContrasena.Name = "tBContrasena";
            this.tBContrasena.Size = new System.Drawing.Size(318, 33);
            this.tBContrasena.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.VerdeLima;
            this.label1.Location = new System.Drawing.Point(324, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 27);
            this.label1.TabIndex = 21;
            this.label1.Text = "Password";
            // 
            // cBPuesto
            // 
            this.cBPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBPuesto.FormattingEnabled = true;
            this.cBPuesto.Location = new System.Drawing.Point(29, 271);
            this.cBPuesto.Name = "cBPuesto";
            this.cBPuesto.Size = new System.Drawing.Size(283, 33);
            this.cBPuesto.TabIndex = 20;
            // 
            // tBCorreo
            // 
            this.tBCorreo.Location = new System.Drawing.Point(329, 172);
            this.tBCorreo.Multiline = true;
            this.tBCorreo.Name = "tBCorreo";
            this.tBCorreo.Size = new System.Drawing.Size(318, 33);
            this.tBCorreo.TabIndex = 19;
            // 
            // tBApellido
            // 
            this.tBApellido.Location = new System.Drawing.Point(329, 65);
            this.tBApellido.Multiline = true;
            this.tBApellido.Name = "tBApellido";
            this.tBApellido.Size = new System.Drawing.Size(318, 33);
            this.tBApellido.TabIndex = 18;
            // 
            // tBNombre
            // 
            this.tBNombre.Location = new System.Drawing.Point(29, 65);
            this.tBNombre.Multiline = true;
            this.tBNombre.Name = "tBNombre";
            this.tBNombre.Size = new System.Drawing.Size(283, 33);
            this.tBNombre.TabIndex = 17;
            // 
            // tBTelefono
            // 
            this.tBTelefono.Location = new System.Drawing.Point(29, 172);
            this.tBTelefono.Multiline = true;
            this.tBTelefono.Name = "tBTelefono";
            this.tBTelefono.Size = new System.Drawing.Size(283, 33);
            this.tBTelefono.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Image = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.VerdeLima;
            this.label9.Location = new System.Drawing.Point(24, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 27);
            this.label9.TabIndex = 10;
            this.label9.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.VerdeLima;
            this.label6.Location = new System.Drawing.Point(324, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 27);
            this.label6.TabIndex = 7;
            this.label6.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.VerdeLima;
            this.label4.Location = new System.Drawing.Point(24, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Puesto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.VerdeLima;
            this.label3.Location = new System.Drawing.Point(324, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Correo";
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
            this.bConfirmar.Location = new System.Drawing.Point(12, 405);
            this.bConfirmar.Name = "bConfirmar";
            this.bConfirmar.Size = new System.Drawing.Size(675, 55);
            this.bConfirmar.TabIndex = 0;
            this.bConfirmar.Text = "Confirmar";
            this.bConfirmar.UseVisualStyleBackColor = false;
            this.bConfirmar.Click += new System.EventHandler(this.bConfirmar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.BackgroundImage = global::_16100075_Jorge_AeroMaya_ProyectoFinal.Properties.Resources.Azul_Marino;
            this.panel3.Location = new System.Drawing.Point(-2, 466);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(702, 22);
            this.panel3.TabIndex = 10;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Admin_AgregarModificarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 488);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pSuperior);
            this.Controls.Add(this.bConfirmar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin_AgregarModificarEmpleado";
            this.Text = "Admin_AgregarModificarEmpleado";
            this.Load += new System.EventHandler(this.Admin_AgregarModificarEmpleado_Load);
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
        private System.Windows.Forms.TextBox tBCorreo;
        private System.Windows.Forms.TextBox tBApellido;
        private System.Windows.Forms.TextBox tBNombre;
        private System.Windows.Forms.TextBox tBTelefono;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bConfirmar;
        private System.Windows.Forms.ComboBox cBPuesto;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tBContrasena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}