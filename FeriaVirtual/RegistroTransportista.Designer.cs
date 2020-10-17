namespace FeriaVirtual
{
    partial class RegistroTransportista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroTransportista));
            this.btnRegistrarTransportista = new System.Windows.Forms.Button();
            this.comboBoxRol = new System.Windows.Forms.ComboBox();
            this.txtContraseñaTransp = new System.Windows.Forms.TextBox();
            this.txtTelefonoTransp = new System.Windows.Forms.TextBox();
            this.txtCorreoTranps = new System.Windows.Forms.TextBox();
            this.txtApellidoMaternoTransp = new System.Windows.Forms.TextBox();
            this.txtApellidoPaternoTransp = new System.Windows.Forms.TextBox();
            this.txtNombreTransportista = new System.Windows.Forms.TextBox();
            this.txtRutTransportista = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCerrarUsuarioRegistro = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPatenteTransp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCapacidadCarga = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBoxRefrigeracion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdTransportista = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRegistrarTransportista
            // 
            this.btnRegistrarTransportista.BackColor = System.Drawing.Color.YellowGreen;
            this.btnRegistrarTransportista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarTransportista.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarTransportista.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarTransportista.Image")));
            this.btnRegistrarTransportista.Location = new System.Drawing.Point(697, 387);
            this.btnRegistrarTransportista.Name = "btnRegistrarTransportista";
            this.btnRegistrarTransportista.Size = new System.Drawing.Size(91, 51);
            this.btnRegistrarTransportista.TabIndex = 56;
            this.btnRegistrarTransportista.Text = "Registrar";
            this.btnRegistrarTransportista.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegistrarTransportista.UseVisualStyleBackColor = false;
            this.btnRegistrarTransportista.Click += new System.EventHandler(this.btnRegistrarTransportista_Click);
            // 
            // comboBoxRol
            // 
            this.comboBoxRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRol.FormattingEnabled = true;
            this.comboBoxRol.Items.AddRange(new object[] {
            "Administrador ",
            "Cliente",
            "Consultor",
            "Productor",
            "Transportista"});
            this.comboBoxRol.Location = new System.Drawing.Point(303, 387);
            this.comboBoxRol.Name = "comboBoxRol";
            this.comboBoxRol.Size = new System.Drawing.Size(238, 21);
            this.comboBoxRol.TabIndex = 55;
            this.comboBoxRol.SelectedIndexChanged += new System.EventHandler(this.comboBoxRol_SelectedIndexChanged);
            // 
            // txtContraseñaTransp
            // 
            this.txtContraseñaTransp.Location = new System.Drawing.Point(303, 355);
            this.txtContraseñaTransp.Name = "txtContraseñaTransp";
            this.txtContraseñaTransp.Size = new System.Drawing.Size(238, 20);
            this.txtContraseñaTransp.TabIndex = 52;
            this.txtContraseñaTransp.TextChanged += new System.EventHandler(this.txtContraseñaTransp_TextChanged);
            // 
            // txtTelefonoTransp
            // 
            this.txtTelefonoTransp.Location = new System.Drawing.Point(303, 214);
            this.txtTelefonoTransp.Name = "txtTelefonoTransp";
            this.txtTelefonoTransp.Size = new System.Drawing.Size(238, 20);
            this.txtTelefonoTransp.TabIndex = 51;
            this.txtTelefonoTransp.TextChanged += new System.EventHandler(this.txtTelefonoTransp_TextChanged);
            // 
            // txtCorreoTranps
            // 
            this.txtCorreoTranps.Location = new System.Drawing.Point(303, 180);
            this.txtCorreoTranps.Name = "txtCorreoTranps";
            this.txtCorreoTranps.Size = new System.Drawing.Size(238, 20);
            this.txtCorreoTranps.TabIndex = 50;
            this.txtCorreoTranps.TextChanged += new System.EventHandler(this.txtCorreoTranps_TextChanged);
            // 
            // txtApellidoMaternoTransp
            // 
            this.txtApellidoMaternoTransp.Location = new System.Drawing.Point(303, 147);
            this.txtApellidoMaternoTransp.Name = "txtApellidoMaternoTransp";
            this.txtApellidoMaternoTransp.Size = new System.Drawing.Size(238, 20);
            this.txtApellidoMaternoTransp.TabIndex = 48;
            this.txtApellidoMaternoTransp.TextChanged += new System.EventHandler(this.txtApellidoMaternoTransp_TextChanged);
            // 
            // txtApellidoPaternoTransp
            // 
            this.txtApellidoPaternoTransp.Location = new System.Drawing.Point(303, 118);
            this.txtApellidoPaternoTransp.Name = "txtApellidoPaternoTransp";
            this.txtApellidoPaternoTransp.Size = new System.Drawing.Size(238, 20);
            this.txtApellidoPaternoTransp.TabIndex = 47;
            this.txtApellidoPaternoTransp.TextChanged += new System.EventHandler(this.txtApellidoPaternoTransp_TextChanged);
            // 
            // txtNombreTransportista
            // 
            this.txtNombreTransportista.Location = new System.Drawing.Point(303, 88);
            this.txtNombreTransportista.Name = "txtNombreTransportista";
            this.txtNombreTransportista.Size = new System.Drawing.Size(238, 20);
            this.txtNombreTransportista.TabIndex = 46;
            this.txtNombreTransportista.TextChanged += new System.EventHandler(this.txtNombreTransportista_TextChanged);
            // 
            // txtRutTransportista
            // 
            this.txtRutTransportista.Location = new System.Drawing.Point(303, 58);
            this.txtRutTransportista.Name = "txtRutTransportista";
            this.txtRutTransportista.Size = new System.Drawing.Size(238, 20);
            this.txtRutTransportista.TabIndex = 45;
            this.txtRutTransportista.TextChanged += new System.EventHandler(this.txtRutTransportista_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(242, 387);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 20);
            this.label11.TabIndex = 44;
            this.label11.Text = "Rol";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(183, 353);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 20);
            this.label10.TabIndex = 43;
            this.label10.Text = "Contraseña";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(132, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 20);
            this.label8.TabIndex = 42;
            this.label8.Text = "Numero Telefonico";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(217, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 41;
            this.label7.Text = "Correo";
            // 
            // btnCerrarUsuarioRegistro
            // 
            this.btnCerrarUsuarioRegistro.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCerrarUsuarioRegistro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrarUsuarioRegistro.BackgroundImage")));
            this.btnCerrarUsuarioRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrarUsuarioRegistro.Location = new System.Drawing.Point(765, 12);
            this.btnCerrarUsuarioRegistro.Name = "btnCerrarUsuarioRegistro";
            this.btnCerrarUsuarioRegistro.Size = new System.Drawing.Size(23, 23);
            this.btnCerrarUsuarioRegistro.TabIndex = 40;
            this.btnCerrarUsuarioRegistro.UseVisualStyleBackColor = true;
            this.btnCerrarUsuarioRegistro.Click += new System.EventHandler(this.btnCerrarUsuarioRegistro_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(141, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Apellido Materno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(147, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Apellido Paterno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Nombre Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Rut ";
            // 
            // txtPatenteTransp
            // 
            this.txtPatenteTransp.Location = new System.Drawing.Point(303, 248);
            this.txtPatenteTransp.Name = "txtPatenteTransp";
            this.txtPatenteTransp.Size = new System.Drawing.Size(238, 20);
            this.txtPatenteTransp.TabIndex = 58;
            this.txtPatenteTransp.TextChanged += new System.EventHandler(this.txtPatenteTransp_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(142, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 20);
            this.label9.TabIndex = 57;
            this.label9.Text = "Patente Vehiculo";
            // 
            // txtCapacidadCarga
            // 
            this.txtCapacidadCarga.Location = new System.Drawing.Point(303, 282);
            this.txtCapacidadCarga.Name = "txtCapacidadCarga";
            this.txtCapacidadCarga.Size = new System.Drawing.Size(238, 20);
            this.txtCapacidadCarga.TabIndex = 60;
            this.txtCapacidadCarga.TextChanged += new System.EventHandler(this.txtCapacidadCarga_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(109, 282);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(169, 20);
            this.label13.TabIndex = 59;
            this.label13.Text = "Capacidad de Carga";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(170, 317);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 20);
            this.label14.TabIndex = 61;
            this.label14.Text = "Refrigeracion";
            // 
            // comboBoxRefrigeracion
            // 
            this.comboBoxRefrigeracion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRefrigeracion.FormattingEnabled = true;
            this.comboBoxRefrigeracion.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.comboBoxRefrigeracion.Location = new System.Drawing.Point(303, 319);
            this.comboBoxRefrigeracion.Name = "comboBoxRefrigeracion";
            this.comboBoxRefrigeracion.Size = new System.Drawing.Size(238, 21);
            this.comboBoxRefrigeracion.TabIndex = 62;
            this.comboBoxRefrigeracion.SelectedIndexChanged += new System.EventHandler(this.comboBoxRefrigeracion_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(161, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 63;
            this.label5.Text = "ID Transportista";
            // 
            // txtIdTransportista
            // 
            this.txtIdTransportista.Location = new System.Drawing.Point(303, 32);
            this.txtIdTransportista.Name = "txtIdTransportista";
            this.txtIdTransportista.Size = new System.Drawing.Size(238, 20);
            this.txtIdTransportista.TabIndex = 64;
            this.txtIdTransportista.TextChanged += new System.EventHandler(this.txtIdTransportista_TextChanged);
            // 
            // RegistroTransportista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIdTransportista);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxRefrigeracion);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtCapacidadCarga);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtPatenteTransp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnRegistrarTransportista);
            this.Controls.Add(this.comboBoxRol);
            this.Controls.Add(this.txtContraseñaTransp);
            this.Controls.Add(this.txtTelefonoTransp);
            this.Controls.Add(this.txtCorreoTranps);
            this.Controls.Add(this.txtApellidoMaternoTransp);
            this.Controls.Add(this.txtApellidoPaternoTransp);
            this.Controls.Add(this.txtNombreTransportista);
            this.Controls.Add(this.txtRutTransportista);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCerrarUsuarioRegistro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroTransportista";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "RegistroTransportista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarTransportista;
        private System.Windows.Forms.ComboBox comboBoxRol;
        private System.Windows.Forms.TextBox txtContraseñaTransp;
        private System.Windows.Forms.TextBox txtTelefonoTransp;
        private System.Windows.Forms.TextBox txtCorreoTranps;
        private System.Windows.Forms.TextBox txtApellidoMaternoTransp;
        private System.Windows.Forms.TextBox txtApellidoPaternoTransp;
        private System.Windows.Forms.TextBox txtNombreTransportista;
        private System.Windows.Forms.TextBox txtRutTransportista;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCerrarUsuarioRegistro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPatenteTransp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCapacidadCarga;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBoxRefrigeracion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdTransportista;
    }
}