namespace FeriaVirtual
{
    partial class Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCliente = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrarUsuario = new System.Windows.Forms.Button();
            this.mOSTRARCLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new FeriaVirtual.DataSet1();
            this.mOSTRARCLIENTETableAdapter = new FeriaVirtual.DataSet1TableAdapters.MOSTRARCLIENTETableAdapter();
            this.dgvListar = new System.Windows.Forms.DataGridView();
            this.btnEliminarAdministrador = new System.Windows.Forms.Button();
            this.btnModificarConsultor = new System.Windows.Forms.Button();
            this.btnModificarAdmin = new System.Windows.Forms.Button();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnEliminarProductor = new System.Windows.Forms.Button();
            this.btnEliminarTrasnportista = new System.Windows.Forms.Button();
            this.btnEliminarConsultor = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnClienteIn = new System.Windows.Forms.Button();
            this.btnEliminarCliLocal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mOSTRARCLIENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.YellowGreen;
            this.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCliente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.Image")));
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCliente.Location = new System.Drawing.Point(42, 186);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(100, 61);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "Cliente Externo";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.YellowGreen;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(42, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 61);
            this.button2.TabIndex = 1;
            this.button2.Text = "Productores";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.YellowGreen;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(42, 320);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 61);
            this.button3.TabIndex = 2;
            this.button3.Text = "Transportistas";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.YellowGreen;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(42, 387);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 61);
            this.button4.TabIndex = 3;
            this.button4.Text = "Consultores";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.YellowGreen;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(42, 454);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 61);
            this.button5.TabIndex = 4;
            this.button5.Text = "Administrador";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(475, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Usuario";
            // 
            // btnCerrarUsuario
            // 
            this.btnCerrarUsuario.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCerrarUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrarUsuario.BackgroundImage")));
            this.btnCerrarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrarUsuario.Location = new System.Drawing.Point(1015, 9);
            this.btnCerrarUsuario.Name = "btnCerrarUsuario";
            this.btnCerrarUsuario.Size = new System.Drawing.Size(23, 23);
            this.btnCerrarUsuario.TabIndex = 7;
            this.btnCerrarUsuario.UseVisualStyleBackColor = true;
            this.btnCerrarUsuario.Click += new System.EventHandler(this.btnCerrarUsuario_Click);
            // 
            // mOSTRARCLIENTEBindingSource
            // 
            this.mOSTRARCLIENTEBindingSource.DataMember = "MOSTRARCLIENTE";
            this.mOSTRARCLIENTEBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mOSTRARCLIENTETableAdapter
            // 
            this.mOSTRARCLIENTETableAdapter.ClearBeforeFill = true;
            // 
            // dgvListar
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvListar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListar.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.dgvListar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListar.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListar.EnableHeadersVisualStyles = false;
            this.dgvListar.Location = new System.Drawing.Point(232, 71);
            this.dgvListar.Name = "dgvListar";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListar.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvListar.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListar.Size = new System.Drawing.Size(733, 473);
            this.dgvListar.TabIndex = 8;
            // 
            // btnEliminarAdministrador
            // 
            this.btnEliminarAdministrador.BackColor = System.Drawing.Color.YellowGreen;
            this.btnEliminarAdministrador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarAdministrador.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAdministrador.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminarAdministrador.Location = new System.Drawing.Point(148, 460);
            this.btnEliminarAdministrador.Name = "btnEliminarAdministrador";
            this.btnEliminarAdministrador.Size = new System.Drawing.Size(56, 26);
            this.btnEliminarAdministrador.TabIndex = 74;
            this.btnEliminarAdministrador.Text = "Eliminar";
            this.btnEliminarAdministrador.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminarAdministrador.UseVisualStyleBackColor = false;
            this.btnEliminarAdministrador.Click += new System.EventHandler(this.btnEliminarAdministrador_Click);
            // 
            // btnModificarConsultor
            // 
            this.btnModificarConsultor.BackColor = System.Drawing.Color.YellowGreen;
            this.btnModificarConsultor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarConsultor.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarConsultor.Location = new System.Drawing.Point(148, 425);
            this.btnModificarConsultor.Name = "btnModificarConsultor";
            this.btnModificarConsultor.Size = new System.Drawing.Size(56, 23);
            this.btnModificarConsultor.TabIndex = 76;
            this.btnModificarConsultor.Text = "Editar";
            this.btnModificarConsultor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificarConsultor.UseVisualStyleBackColor = false;
            this.btnModificarConsultor.Click += new System.EventHandler(this.btnModificarConsultor_Click);
            // 
            // btnModificarAdmin
            // 
            this.btnModificarAdmin.BackColor = System.Drawing.Color.YellowGreen;
            this.btnModificarAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarAdmin.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarAdmin.Location = new System.Drawing.Point(148, 492);
            this.btnModificarAdmin.Name = "btnModificarAdmin";
            this.btnModificarAdmin.Size = new System.Drawing.Size(56, 23);
            this.btnModificarAdmin.TabIndex = 77;
            this.btnModificarAdmin.Text = "Editar";
            this.btnModificarAdmin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificarAdmin.UseVisualStyleBackColor = false;
            this.btnModificarAdmin.Click += new System.EventHandler(this.btnModificarAdmin_Click);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.BackColor = System.Drawing.Color.YellowGreen;
            this.btnEliminarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarCliente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminarCliente.Location = new System.Drawing.Point(148, 221);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(56, 26);
            this.btnEliminarCliente.TabIndex = 80;
            this.btnEliminarCliente.Text = "Eliminar";
            this.btnEliminarCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminarCliente.UseVisualStyleBackColor = false;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // btnEliminarProductor
            // 
            this.btnEliminarProductor.BackColor = System.Drawing.Color.YellowGreen;
            this.btnEliminarProductor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarProductor.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProductor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminarProductor.Location = new System.Drawing.Point(148, 288);
            this.btnEliminarProductor.Name = "btnEliminarProductor";
            this.btnEliminarProductor.Size = new System.Drawing.Size(56, 26);
            this.btnEliminarProductor.TabIndex = 81;
            this.btnEliminarProductor.Text = "Eliminar";
            this.btnEliminarProductor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminarProductor.UseVisualStyleBackColor = false;
            this.btnEliminarProductor.Click += new System.EventHandler(this.btnEliminarProductor_Click);
            // 
            // btnEliminarTrasnportista
            // 
            this.btnEliminarTrasnportista.BackColor = System.Drawing.Color.YellowGreen;
            this.btnEliminarTrasnportista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarTrasnportista.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTrasnportista.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminarTrasnportista.Location = new System.Drawing.Point(148, 355);
            this.btnEliminarTrasnportista.Name = "btnEliminarTrasnportista";
            this.btnEliminarTrasnportista.Size = new System.Drawing.Size(56, 26);
            this.btnEliminarTrasnportista.TabIndex = 82;
            this.btnEliminarTrasnportista.Text = "Eliminar";
            this.btnEliminarTrasnportista.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminarTrasnportista.UseVisualStyleBackColor = false;
            this.btnEliminarTrasnportista.Click += new System.EventHandler(this.btnEliminarTrasnportista_Click);
            // 
            // btnEliminarConsultor
            // 
            this.btnEliminarConsultor.BackColor = System.Drawing.Color.YellowGreen;
            this.btnEliminarConsultor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarConsultor.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarConsultor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminarConsultor.Location = new System.Drawing.Point(148, 393);
            this.btnEliminarConsultor.Name = "btnEliminarConsultor";
            this.btnEliminarConsultor.Size = new System.Drawing.Size(56, 26);
            this.btnEliminarConsultor.TabIndex = 83;
            this.btnEliminarConsultor.Text = "Eliminar";
            this.btnEliminarConsultor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminarConsultor.UseVisualStyleBackColor = false;
            this.btnEliminarConsultor.Click += new System.EventHandler(this.btnEliminarConsultor_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.YellowGreen;
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(24, 21);
            this.button11.Name = "button11";
            this.button11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button11.Size = new System.Drawing.Size(91, 25);
            this.button11.TabIndex = 84;
            this.button11.Text = "Buscar";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(121, 23);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(227, 20);
            this.textBox4.TabIndex = 85;
            // 
            // btnClienteIn
            // 
            this.btnClienteIn.BackColor = System.Drawing.Color.YellowGreen;
            this.btnClienteIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClienteIn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienteIn.Image = ((System.Drawing.Image)(resources.GetObject("btnClienteIn.Image")));
            this.btnClienteIn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClienteIn.Location = new System.Drawing.Point(42, 119);
            this.btnClienteIn.Name = "btnClienteIn";
            this.btnClienteIn.Size = new System.Drawing.Size(100, 61);
            this.btnClienteIn.TabIndex = 86;
            this.btnClienteIn.Text = "Cliente Interno";
            this.btnClienteIn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClienteIn.UseVisualStyleBackColor = false;
            this.btnClienteIn.Click += new System.EventHandler(this.btnClienteIn_Click);
            // 
            // btnEliminarCliLocal
            // 
            this.btnEliminarCliLocal.BackColor = System.Drawing.Color.YellowGreen;
            this.btnEliminarCliLocal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarCliLocal.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCliLocal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminarCliLocal.Location = new System.Drawing.Point(148, 154);
            this.btnEliminarCliLocal.Name = "btnEliminarCliLocal";
            this.btnEliminarCliLocal.Size = new System.Drawing.Size(56, 26);
            this.btnEliminarCliLocal.TabIndex = 87;
            this.btnEliminarCliLocal.Text = "Eliminar";
            this.btnEliminarCliLocal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminarCliLocal.UseVisualStyleBackColor = false;
            this.btnEliminarCliLocal.Click += new System.EventHandler(this.btnEliminarCliLocal_Click);
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.btnEliminarCliLocal);
            this.Controls.Add(this.btnClienteIn);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.btnEliminarConsultor);
            this.Controls.Add(this.btnEliminarTrasnportista);
            this.Controls.Add(this.btnEliminarProductor);
            this.Controls.Add(this.btnEliminarCliente);
            this.Controls.Add(this.btnModificarAdmin);
            this.Controls.Add(this.btnModificarConsultor);
            this.Controls.Add(this.btnEliminarAdministrador);
            this.Controls.Add(this.dgvListar);
            this.Controls.Add(this.btnCerrarUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Usuario";
            this.Text = "Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.mOSTRARCLIENTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrarUsuario;
        private System.Windows.Forms.BindingSource mOSTRARCLIENTEBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.MOSTRARCLIENTETableAdapter mOSTRARCLIENTETableAdapter;
        private System.Windows.Forms.DataGridView dgvListar;
        private System.Windows.Forms.Button btnEliminarAdministrador;
        private System.Windows.Forms.Button btnModificarConsultor;
        private System.Windows.Forms.Button btnModificarAdmin;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Button btnEliminarProductor;
        private System.Windows.Forms.Button btnEliminarTrasnportista;
        private System.Windows.Forms.Button btnEliminarConsultor;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnClienteIn;
        private System.Windows.Forms.Button btnEliminarCliLocal;
    }
}