namespace FeriaVirtual
{
    partial class RegistroAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroAdministrador));
            this.txtCorreoAdmin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRegistrarAdmin = new System.Windows.Forms.Button();
            this.comboBoxRol = new System.Windows.Forms.ComboBox();
            this.txtContraseñaAdmin = new System.Windows.Forms.TextBox();
            this.txtNumeroAdmin = new System.Windows.Forms.TextBox();
            this.txtApellidoMAdmin = new System.Windows.Forms.TextBox();
            this.txtApellidoPAdmin = new System.Windows.Forms.TextBox();
            this.txtNombreAdmin = new System.Windows.Forms.TextBox();
            this.txtRutAdmin = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCerrarUsuarioRegistro = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCorreoAdmin
            // 
            this.txtCorreoAdmin.Location = new System.Drawing.Point(308, 251);
            this.txtCorreoAdmin.Name = "txtCorreoAdmin";
            this.txtCorreoAdmin.Size = new System.Drawing.Size(238, 20);
            this.txtCorreoAdmin.TabIndex = 80;
            this.txtCorreoAdmin.TextChanged += new System.EventHandler(this.txtCorreoAdmin_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(222, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 79;
            this.label7.Text = "Correo";
            // 
            // btnRegistrarAdmin
            // 
            this.btnRegistrarAdmin.BackColor = System.Drawing.Color.YellowGreen;
            this.btnRegistrarAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarAdmin.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarAdmin.Image")));
            this.btnRegistrarAdmin.Location = new System.Drawing.Point(697, 387);
            this.btnRegistrarAdmin.Name = "btnRegistrarAdmin";
            this.btnRegistrarAdmin.Size = new System.Drawing.Size(91, 51);
            this.btnRegistrarAdmin.TabIndex = 78;
            this.btnRegistrarAdmin.Text = "Registrar";
            this.btnRegistrarAdmin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegistrarAdmin.UseVisualStyleBackColor = false;
            this.btnRegistrarAdmin.Click += new System.EventHandler(this.btnRegistrarAdmin_Click);
            // 
            // comboBoxRol
            // 
            this.comboBoxRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRol.FormattingEnabled = true;
            this.comboBoxRol.Items.AddRange(new object[] {
            "Administrador",
            "Consultor ",
            "Productor",
            "Transportista",
            "Cliente"});
            this.comboBoxRol.Location = new System.Drawing.Point(308, 328);
            this.comboBoxRol.Name = "comboBoxRol";
            this.comboBoxRol.Size = new System.Drawing.Size(238, 21);
            this.comboBoxRol.TabIndex = 77;
            this.comboBoxRol.SelectedIndexChanged += new System.EventHandler(this.comboBoxRol_SelectedIndexChanged);
            // 
            // txtContraseñaAdmin
            // 
            this.txtContraseñaAdmin.Location = new System.Drawing.Point(308, 288);
            this.txtContraseñaAdmin.Name = "txtContraseñaAdmin";
            this.txtContraseñaAdmin.Size = new System.Drawing.Size(238, 20);
            this.txtContraseñaAdmin.TabIndex = 75;
            this.txtContraseñaAdmin.TextChanged += new System.EventHandler(this.txtContraseñaAdmin_TextChanged);
            // 
            // txtNumeroAdmin
            // 
            this.txtNumeroAdmin.Location = new System.Drawing.Point(308, 217);
            this.txtNumeroAdmin.Name = "txtNumeroAdmin";
            this.txtNumeroAdmin.Size = new System.Drawing.Size(238, 20);
            this.txtNumeroAdmin.TabIndex = 74;
            this.txtNumeroAdmin.TextChanged += new System.EventHandler(this.txtNumeroAdmin_TextChanged);
            // 
            // txtApellidoMAdmin
            // 
            this.txtApellidoMAdmin.Location = new System.Drawing.Point(308, 182);
            this.txtApellidoMAdmin.Name = "txtApellidoMAdmin";
            this.txtApellidoMAdmin.Size = new System.Drawing.Size(238, 20);
            this.txtApellidoMAdmin.TabIndex = 73;
            this.txtApellidoMAdmin.TextChanged += new System.EventHandler(this.txtApellidoMAdmin_TextChanged);
            // 
            // txtApellidoPAdmin
            // 
            this.txtApellidoPAdmin.Location = new System.Drawing.Point(308, 153);
            this.txtApellidoPAdmin.Name = "txtApellidoPAdmin";
            this.txtApellidoPAdmin.Size = new System.Drawing.Size(238, 20);
            this.txtApellidoPAdmin.TabIndex = 72;
            this.txtApellidoPAdmin.TextChanged += new System.EventHandler(this.txtApellidoPAdmin_TextChanged);
            // 
            // txtNombreAdmin
            // 
            this.txtNombreAdmin.Location = new System.Drawing.Point(308, 123);
            this.txtNombreAdmin.Name = "txtNombreAdmin";
            this.txtNombreAdmin.Size = new System.Drawing.Size(238, 20);
            this.txtNombreAdmin.TabIndex = 71;
            this.txtNombreAdmin.TextChanged += new System.EventHandler(this.txtNombreAdmin_TextChanged);
            // 
            // txtRutAdmin
            // 
            this.txtRutAdmin.Location = new System.Drawing.Point(308, 93);
            this.txtRutAdmin.Name = "txtRutAdmin";
            this.txtRutAdmin.Size = new System.Drawing.Size(238, 20);
            this.txtRutAdmin.TabIndex = 70;
            this.txtRutAdmin.TextChanged += new System.EventHandler(this.txtRutAdmin_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(247, 328);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 20);
            this.label11.TabIndex = 69;
            this.label11.Text = "Rol";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(188, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 20);
            this.label10.TabIndex = 68;
            this.label10.Text = "Contraseña";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(137, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 20);
            this.label8.TabIndex = 67;
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
            this.btnCerrarUsuarioRegistro.TabIndex = 66;
            this.btnCerrarUsuarioRegistro.UseVisualStyleBackColor = true;
            this.btnCerrarUsuarioRegistro.Click += new System.EventHandler(this.btnCerrarUsuarioRegistro_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(146, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 65;
            this.label4.Text = "Apellido Materno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(152, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 64;
            this.label3.Text = "Apellido Paterno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 63;
            this.label2.Text = "Nombre Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 62;
            this.label1.Text = "Rut ";
            // 
            // RegistroAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCorreoAdmin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnRegistrarAdmin);
            this.Controls.Add(this.comboBoxRol);
            this.Controls.Add(this.txtContraseñaAdmin);
            this.Controls.Add(this.txtNumeroAdmin);
            this.Controls.Add(this.txtApellidoMAdmin);
            this.Controls.Add(this.txtApellidoPAdmin);
            this.Controls.Add(this.txtNombreAdmin);
            this.Controls.Add(this.txtRutAdmin);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCerrarUsuarioRegistro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroAdministrador";
            this.Text = "RegistroAdministrador";
            this.Load += new System.EventHandler(this.RegistroAdministrador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCorreoAdmin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRegistrarAdmin;
        private System.Windows.Forms.ComboBox comboBoxRol;
        private System.Windows.Forms.TextBox txtContraseñaAdmin;
        private System.Windows.Forms.TextBox txtNumeroAdmin;
        private System.Windows.Forms.TextBox txtApellidoMAdmin;
        private System.Windows.Forms.TextBox txtApellidoPAdmin;
        private System.Windows.Forms.TextBox txtNombreAdmin;
        private System.Windows.Forms.TextBox txtRutAdmin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCerrarUsuarioRegistro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}