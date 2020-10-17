namespace FeriaVirtual
{
    partial class RegistroProductores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroProductores));
            this.btnRegistrarProductor = new System.Windows.Forms.Button();
            this.comboBoxRol = new System.Windows.Forms.ComboBox();
            this.txtContraseñaProductor = new System.Windows.Forms.TextBox();
            this.txtTelefonoProductor = new System.Windows.Forms.TextBox();
            this.txtApellidoMProductor = new System.Windows.Forms.TextBox();
            this.txtApellidoPProductor = new System.Windows.Forms.TextBox();
            this.txtNombreProductor = new System.Windows.Forms.TextBox();
            this.txtRutProductor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCerrarUsuarioRegistro = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCorreoProductor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDireccionProductor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdUsuarioProductor = new System.Windows.Forms.TextBox();
            this.txtCiudadProductor = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtContratoProductor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRegistrarProductor
            // 
            this.btnRegistrarProductor.BackColor = System.Drawing.Color.YellowGreen;
            this.btnRegistrarProductor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarProductor.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarProductor.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarProductor.Image")));
            this.btnRegistrarProductor.Location = new System.Drawing.Point(697, 387);
            this.btnRegistrarProductor.Name = "btnRegistrarProductor";
            this.btnRegistrarProductor.Size = new System.Drawing.Size(91, 51);
            this.btnRegistrarProductor.TabIndex = 59;
            this.btnRegistrarProductor.Text = "Registrar";
            this.btnRegistrarProductor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegistrarProductor.UseVisualStyleBackColor = false;
            this.btnRegistrarProductor.Click += new System.EventHandler(this.btnRegistrarProductor_Click);
            // 
            // comboBoxRol
            // 
            this.comboBoxRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRol.FormattingEnabled = true;
            this.comboBoxRol.Items.AddRange(new object[] {
            "Administrador ",
            "Consultor ",
            "Productor",
            "Transportista",
            "Cliente"});
            this.comboBoxRol.Location = new System.Drawing.Point(312, 349);
            this.comboBoxRol.Name = "comboBoxRol";
            this.comboBoxRol.Size = new System.Drawing.Size(238, 21);
            this.comboBoxRol.TabIndex = 56;
            this.comboBoxRol.SelectedIndexChanged += new System.EventHandler(this.comboBoxRol_SelectedIndexChanged);
            // 
            // txtContraseñaProductor
            // 
            this.txtContraseñaProductor.Location = new System.Drawing.Point(312, 317);
            this.txtContraseñaProductor.Name = "txtContraseñaProductor";
            this.txtContraseñaProductor.Size = new System.Drawing.Size(238, 20);
            this.txtContraseñaProductor.TabIndex = 53;
            this.txtContraseñaProductor.TextChanged += new System.EventHandler(this.txtContraseñaProductor_TextChanged);
            // 
            // txtTelefonoProductor
            // 
            this.txtTelefonoProductor.Location = new System.Drawing.Point(312, 248);
            this.txtTelefonoProductor.Name = "txtTelefonoProductor";
            this.txtTelefonoProductor.Size = new System.Drawing.Size(238, 20);
            this.txtTelefonoProductor.TabIndex = 52;
            this.txtTelefonoProductor.TextChanged += new System.EventHandler(this.txtTelefonoProductor_TextChanged);
            // 
            // txtApellidoMProductor
            // 
            this.txtApellidoMProductor.Location = new System.Drawing.Point(312, 157);
            this.txtApellidoMProductor.Name = "txtApellidoMProductor";
            this.txtApellidoMProductor.Size = new System.Drawing.Size(238, 20);
            this.txtApellidoMProductor.TabIndex = 49;
            this.txtApellidoMProductor.TextChanged += new System.EventHandler(this.txtApellidoMProductor_TextChanged);
            // 
            // txtApellidoPProductor
            // 
            this.txtApellidoPProductor.Location = new System.Drawing.Point(312, 128);
            this.txtApellidoPProductor.Name = "txtApellidoPProductor";
            this.txtApellidoPProductor.Size = new System.Drawing.Size(238, 20);
            this.txtApellidoPProductor.TabIndex = 48;
            this.txtApellidoPProductor.TextChanged += new System.EventHandler(this.txtApellidoPProductor_TextChanged);
            // 
            // txtNombreProductor
            // 
            this.txtNombreProductor.Location = new System.Drawing.Point(312, 98);
            this.txtNombreProductor.Name = "txtNombreProductor";
            this.txtNombreProductor.Size = new System.Drawing.Size(238, 20);
            this.txtNombreProductor.TabIndex = 47;
            this.txtNombreProductor.TextChanged += new System.EventHandler(this.txtNombreProductor_TextChanged);
            // 
            // txtRutProductor
            // 
            this.txtRutProductor.Location = new System.Drawing.Point(312, 68);
            this.txtRutProductor.Name = "txtRutProductor";
            this.txtRutProductor.Size = new System.Drawing.Size(238, 20);
            this.txtRutProductor.TabIndex = 46;
            this.txtRutProductor.TextChanged += new System.EventHandler(this.txtRutProductor_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(251, 349);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 20);
            this.label11.TabIndex = 45;
            this.label11.Text = "Rol";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(192, 315);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 20);
            this.label10.TabIndex = 44;
            this.label10.Text = "Contraseña";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(141, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 20);
            this.label8.TabIndex = 42;
            this.label8.Text = "Numero Telefonico";
            // 
            // btnCerrarUsuarioRegistro
            // 
            this.btnCerrarUsuarioRegistro.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCerrarUsuarioRegistro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrarUsuarioRegistro.BackgroundImage")));
            this.btnCerrarUsuarioRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrarUsuarioRegistro.Location = new System.Drawing.Point(764, 12);
            this.btnCerrarUsuarioRegistro.Name = "btnCerrarUsuarioRegistro";
            this.btnCerrarUsuarioRegistro.Size = new System.Drawing.Size(23, 23);
            this.btnCerrarUsuarioRegistro.TabIndex = 40;
            this.btnCerrarUsuarioRegistro.UseVisualStyleBackColor = true;
            this.btnCerrarUsuarioRegistro.Click += new System.EventHandler(this.btnCerrarUsuarioRegistro_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(224, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 39;
            this.label6.Text = "Ciudad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(150, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Apellido Materno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(156, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Apellido Paterno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(163, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Nombre Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Rut ";
            // 
            // txtCorreoProductor
            // 
            this.txtCorreoProductor.Location = new System.Drawing.Point(312, 282);
            this.txtCorreoProductor.Name = "txtCorreoProductor";
            this.txtCorreoProductor.Size = new System.Drawing.Size(238, 20);
            this.txtCorreoProductor.TabIndex = 61;
            this.txtCorreoProductor.TextChanged += new System.EventHandler(this.txtCorreoProductor_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(226, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 60;
            this.label7.Text = "Correo";
            // 
            // txtDireccionProductor
            // 
            this.txtDireccionProductor.Location = new System.Drawing.Point(312, 217);
            this.txtDireccionProductor.Name = "txtDireccionProductor";
            this.txtDireccionProductor.Size = new System.Drawing.Size(238, 20);
            this.txtDireccionProductor.TabIndex = 63;
            this.txtDireccionProductor.TextChanged += new System.EventHandler(this.txtDireccionProductor_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(203, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 62;
            this.label5.Text = "Direccion ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(205, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 64;
            this.label9.Text = "Id Usuario";
            // 
            // txtIdUsuarioProductor
            // 
            this.txtIdUsuarioProductor.Location = new System.Drawing.Point(312, 35);
            this.txtIdUsuarioProductor.Name = "txtIdUsuarioProductor";
            this.txtIdUsuarioProductor.Size = new System.Drawing.Size(238, 20);
            this.txtIdUsuarioProductor.TabIndex = 65;
            this.txtIdUsuarioProductor.TextChanged += new System.EventHandler(this.txtIdUsuarioProductor_TextChanged);
            // 
            // txtCiudadProductor
            // 
            this.txtCiudadProductor.Location = new System.Drawing.Point(312, 191);
            this.txtCiudadProductor.Name = "txtCiudadProductor";
            this.txtCiudadProductor.Size = new System.Drawing.Size(238, 20);
            this.txtCiudadProductor.TabIndex = 66;
            this.txtCiudadProductor.TextChanged += new System.EventHandler(this.txtCiudadProductor_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(212, 387);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 20);
            this.label12.TabIndex = 67;
            this.label12.Text = "Contrato";
            // 
            // txtContratoProductor
            // 
            this.txtContratoProductor.Location = new System.Drawing.Point(312, 389);
            this.txtContratoProductor.Name = "txtContratoProductor";
            this.txtContratoProductor.Size = new System.Drawing.Size(238, 20);
            this.txtContratoProductor.TabIndex = 68;
            this.txtContratoProductor.TextChanged += new System.EventHandler(this.txtContratoProductor_TextChanged);
            // 
            // RegistroProductores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtContratoProductor);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCiudadProductor);
            this.Controls.Add(this.txtIdUsuarioProductor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDireccionProductor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCorreoProductor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnRegistrarProductor);
            this.Controls.Add(this.comboBoxRol);
            this.Controls.Add(this.txtContraseñaProductor);
            this.Controls.Add(this.txtTelefonoProductor);
            this.Controls.Add(this.txtApellidoMProductor);
            this.Controls.Add(this.txtApellidoPProductor);
            this.Controls.Add(this.txtNombreProductor);
            this.Controls.Add(this.txtRutProductor);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCerrarUsuarioRegistro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroProductores";
            this.Text = "RegistroProductores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarProductor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCerrarUsuarioRegistro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxRol;
        private System.Windows.Forms.TextBox txtContraseñaProductor;
        private System.Windows.Forms.TextBox txtTelefonoProductor;
        private System.Windows.Forms.TextBox txtApellidoMProductor;
        private System.Windows.Forms.TextBox txtApellidoPProductor;
        private System.Windows.Forms.TextBox txtNombreProductor;
        private System.Windows.Forms.TextBox txtRutProductor;
        private System.Windows.Forms.TextBox txtCorreoProductor;
        private System.Windows.Forms.TextBox txtDireccionProductor;
        private System.Windows.Forms.TextBox txtIdUsuarioProductor;
        private System.Windows.Forms.TextBox txtCiudadProductor;
        private System.Windows.Forms.TextBox txtContratoProductor;
    }
}