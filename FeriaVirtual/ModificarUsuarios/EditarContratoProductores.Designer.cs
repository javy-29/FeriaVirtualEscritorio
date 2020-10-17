namespace FeriaVirtual.ModificarUsuarios
{
    partial class EditarContratoProductores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarContratoProductores));
            this.comboBoxEditarVigencia = new System.Windows.Forms.ComboBox();
            this.dtpEditarFechaTermino = new System.Windows.Forms.DateTimePicker();
            this.dtpEditarFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.txtEditarNumeroContrato = new System.Windows.Forms.TextBox();
            this.txtEditarIdContrato = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistrarContrato = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxEditarVigencia
            // 
            this.comboBoxEditarVigencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEditarVigencia.FormattingEnabled = true;
            this.comboBoxEditarVigencia.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.comboBoxEditarVigencia.Location = new System.Drawing.Point(265, 239);
            this.comboBoxEditarVigencia.Name = "comboBoxEditarVigencia";
            this.comboBoxEditarVigencia.Size = new System.Drawing.Size(244, 21);
            this.comboBoxEditarVigencia.TabIndex = 115;
            // 
            // dtpEditarFechaTermino
            // 
            this.dtpEditarFechaTermino.Location = new System.Drawing.Point(265, 207);
            this.dtpEditarFechaTermino.Name = "dtpEditarFechaTermino";
            this.dtpEditarFechaTermino.Size = new System.Drawing.Size(244, 20);
            this.dtpEditarFechaTermino.TabIndex = 114;
            this.dtpEditarFechaTermino.Value = new System.DateTime(2020, 10, 9, 0, 23, 56, 0);
            // 
            // dtpEditarFechaInicio
            // 
            this.dtpEditarFechaInicio.Location = new System.Drawing.Point(265, 172);
            this.dtpEditarFechaInicio.Name = "dtpEditarFechaInicio";
            this.dtpEditarFechaInicio.Size = new System.Drawing.Size(244, 20);
            this.dtpEditarFechaInicio.TabIndex = 113;
            // 
            // txtEditarNumeroContrato
            // 
            this.txtEditarNumeroContrato.Location = new System.Drawing.Point(265, 137);
            this.txtEditarNumeroContrato.Name = "txtEditarNumeroContrato";
            this.txtEditarNumeroContrato.Size = new System.Drawing.Size(244, 20);
            this.txtEditarNumeroContrato.TabIndex = 112;
            // 
            // txtEditarIdContrato
            // 
            this.txtEditarIdContrato.Location = new System.Drawing.Point(265, 106);
            this.txtEditarIdContrato.Name = "txtEditarIdContrato";
            this.txtEditarIdContrato.Size = new System.Drawing.Size(244, 20);
            this.txtEditarIdContrato.TabIndex = 111;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(90, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 110;
            this.label6.Text = "Vigencia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(90, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 109;
            this.label5.Text = "Fecha de Termino";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 108;
            this.label4.Text = "Fecha de inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 107;
            this.label3.Text = "Numero de Contrato ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 106;
            this.label2.Text = "ID Contrato";
            // 
            // btnRegistrarContrato
            // 
            this.btnRegistrarContrato.BackColor = System.Drawing.Color.YellowGreen;
            this.btnRegistrarContrato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarContrato.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarContrato.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarContrato.Image")));
            this.btnRegistrarContrato.Location = new System.Drawing.Point(436, 307);
            this.btnRegistrarContrato.Name = "btnRegistrarContrato";
            this.btnRegistrarContrato.Size = new System.Drawing.Size(73, 70);
            this.btnRegistrarContrato.TabIndex = 105;
            this.btnRegistrarContrato.Text = "Guardar";
            this.btnRegistrarContrato.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegistrarContrato.UseVisualStyleBackColor = false;
            this.btnRegistrarContrato.Click += new System.EventHandler(this.btnRegistrarContrato_Click);
            // 
            // EditarContratoProductores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 450);
            this.Controls.Add(this.comboBoxEditarVigencia);
            this.Controls.Add(this.dtpEditarFechaTermino);
            this.Controls.Add(this.dtpEditarFechaInicio);
            this.Controls.Add(this.txtEditarNumeroContrato);
            this.Controls.Add(this.txtEditarIdContrato);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegistrarContrato);
            this.Name = "EditarContratoProductores";
            this.Text = "EditarContratoProductores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegistrarContrato;
        public System.Windows.Forms.ComboBox comboBoxEditarVigencia;
        public System.Windows.Forms.DateTimePicker dtpEditarFechaTermino;
        public System.Windows.Forms.DateTimePicker dtpEditarFechaInicio;
        public System.Windows.Forms.TextBox txtEditarNumeroContrato;
        public System.Windows.Forms.TextBox txtEditarIdContrato;
    }
}