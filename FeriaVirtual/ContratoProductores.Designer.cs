namespace FeriaVirtual
{
    partial class ContratoProductores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContratoProductores));
            this.dgvContrato = new System.Windows.Forms.DataGridView();
            this.btnCerrarUsuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrarContrato = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dtpFechaTermino = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.txtNumeroContrato = new System.Windows.Forms.TextBox();
            this.txtIdContrato = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxVigencia = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtrutproductor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContrato)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvContrato
            // 
            this.dgvContrato.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvContrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContrato.Location = new System.Drawing.Point(27, 149);
            this.dgvContrato.Name = "dgvContrato";
            this.dgvContrato.Size = new System.Drawing.Size(489, 410);
            this.dgvContrato.TabIndex = 19;
            // 
            // btnCerrarUsuario
            // 
            this.btnCerrarUsuario.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCerrarUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrarUsuario.BackgroundImage")));
            this.btnCerrarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrarUsuario.Location = new System.Drawing.Point(1015, 12);
            this.btnCerrarUsuario.Name = "btnCerrarUsuario";
            this.btnCerrarUsuario.Size = new System.Drawing.Size(23, 23);
            this.btnCerrarUsuario.TabIndex = 18;
            this.btnCerrarUsuario.UseVisualStyleBackColor = true;
            this.btnCerrarUsuario.Click += new System.EventHandler(this.btnCerrarUsuario_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(378, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 33);
            this.label1.TabIndex = 17;
            this.label1.Text = "Contrato de Productores";
            // 
            // btnRegistrarContrato
            // 
            this.btnRegistrarContrato.BackColor = System.Drawing.Color.YellowGreen;
            this.btnRegistrarContrato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarContrato.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarContrato.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarContrato.Image")));
            this.btnRegistrarContrato.Location = new System.Drawing.Point(584, 497);
            this.btnRegistrarContrato.Name = "btnRegistrarContrato";
            this.btnRegistrarContrato.Size = new System.Drawing.Size(91, 60);
            this.btnRegistrarContrato.TabIndex = 71;
            this.btnRegistrarContrato.Text = "Registrar";
            this.btnRegistrarContrato.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegistrarContrato.UseVisualStyleBackColor = false;
            this.btnRegistrarContrato.Click += new System.EventHandler(this.btnRegistrarContrato_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(681, 497);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(91, 60);
            this.btnEditar.TabIndex = 70;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnActualizar.Location = new System.Drawing.Point(778, 497);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(91, 60);
            this.btnActualizar.TabIndex = 69;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.Location = new System.Drawing.Point(875, 497);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(91, 60);
            this.btnEliminar.TabIndex = 68;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.YellowGreen;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(27, 116);
            this.button5.Name = "button5";
            this.button5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button5.Size = new System.Drawing.Size(91, 25);
            this.button5.TabIndex = 77;
            this.button5.Text = "Buscar";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(124, 118);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(227, 20);
            this.textBox4.TabIndex = 76;
            // 
            // dtpFechaTermino
            // 
            this.dtpFechaTermino.Location = new System.Drawing.Point(745, 283);
            this.dtpFechaTermino.Name = "dtpFechaTermino";
            this.dtpFechaTermino.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaTermino.TabIndex = 99;
            this.dtpFechaTermino.Value = new System.DateTime(2020, 10, 9, 0, 23, 56, 0);
            this.dtpFechaTermino.ValueChanged += new System.EventHandler(this.dtpFechaTermino_ValueChanged);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(745, 248);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicio.TabIndex = 98;
            // 
            // txtNumeroContrato
            // 
            this.txtNumeroContrato.Location = new System.Drawing.Point(745, 213);
            this.txtNumeroContrato.Name = "txtNumeroContrato";
            this.txtNumeroContrato.Size = new System.Drawing.Size(244, 20);
            this.txtNumeroContrato.TabIndex = 97;
            // 
            // txtIdContrato
            // 
            this.txtIdContrato.Location = new System.Drawing.Point(745, 182);
            this.txtIdContrato.Name = "txtIdContrato";
            this.txtIdContrato.Size = new System.Drawing.Size(244, 20);
            this.txtIdContrato.TabIndex = 96;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(570, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 95;
            this.label6.Text = "Vigencia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(570, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 94;
            this.label5.Text = "Fecha de Termino";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(570, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 93;
            this.label4.Text = "Fecha de inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(570, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 92;
            this.label3.Text = "Numero de Contrato ";
            // 
            // comboBoxVigencia
            // 
            this.comboBoxVigencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVigencia.FormattingEnabled = true;
            this.comboBoxVigencia.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.comboBoxVigencia.Location = new System.Drawing.Point(745, 315);
            this.comboBoxVigencia.Name = "comboBoxVigencia";
            this.comboBoxVigencia.Size = new System.Drawing.Size(238, 21);
            this.comboBoxVigencia.TabIndex = 104;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(570, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 91;
            this.label2.Text = "ID Contrato";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(570, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 105;
            this.label7.Text = "Rut Productor";
            // 
            // txtrutproductor
            // 
            this.txtrutproductor.Location = new System.Drawing.Point(745, 355);
            this.txtrutproductor.Name = "txtrutproductor";
            this.txtrutproductor.Size = new System.Drawing.Size(244, 20);
            this.txtrutproductor.TabIndex = 106;
            this.txtrutproductor.TextChanged += new System.EventHandler(this.txtrutproductor_TextChanged);
            // 
            // ContratoProductores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.txtrutproductor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxVigencia);
            this.Controls.Add(this.dtpFechaTermino);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.txtNumeroContrato);
            this.Controls.Add(this.txtIdContrato);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.btnRegistrarContrato);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvContrato);
            this.Controls.Add(this.btnCerrarUsuario);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContratoProductores";
            this.Text = "ContratoProductores";
            this.Load += new System.EventHandler(this.ContratoProductores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContrato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvContrato;
        private System.Windows.Forms.Button btnCerrarUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrarContrato;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DateTimePicker dtpFechaTermino;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.TextBox txtNumeroContrato;
        private System.Windows.Forms.TextBox txtIdContrato;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxVigencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtrutproductor;
    }
}