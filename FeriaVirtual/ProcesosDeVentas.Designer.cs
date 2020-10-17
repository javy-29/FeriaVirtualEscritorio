namespace FeriaVirtual
{
    partial class ProcesosDeVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcesosDeVentas));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.btnCerrarUsuario = new System.Windows.Forms.Button();
            this.dataSetBDA = new FeriaVirtual.DataSetBDA();
            this.pROCESOVENTABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROCESO_VENTATableAdapter = new FeriaVirtual.DataSetBDATableAdapters.PROCESO_VENTATableAdapter();
            this.dataSetProcesosVenta = new FeriaVirtual.DataSetProcesosVenta();
            this.pROCESOVENTABindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pROCESO_VENTATableAdapter1 = new FeriaVirtual.DataSetProcesosVentaTableAdapters.PROCESO_VENTATableAdapter();
            this.iDPROCESODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNFORMACIONVENTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oFERTAPRODDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTORIDPRODUCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONTRATOVENTAIDCONTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBDA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROCESOVENTABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProcesosVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROCESOVENTABindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPROCESODataGridViewTextBoxColumn,
            this.iNFORMACIONVENTADataGridViewTextBoxColumn,
            this.oFERTAPRODDataGridViewTextBoxColumn,
            this.pRODUCTORIDPRODUCDataGridViewTextBoxColumn,
            this.cONTRATOVENTAIDCONTDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pROCESOVENTABindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(22, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(514, 421);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(597, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Proceso de Venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(597, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Infomacion de venta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(597, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Productos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(597, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Productor";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(376, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 33);
            this.label5.TabIndex = 62;
            this.label5.Text = "Procesos de Ventas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(597, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 17);
            this.label6.TabIndex = 63;
            this.label6.Text = "ID Contrato de venta";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(743, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 20);
            this.textBox1.TabIndex = 65;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(743, 182);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(227, 20);
            this.textBox2.TabIndex = 66;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(743, 155);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(227, 20);
            this.textBox3.TabIndex = 67;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(613, 254);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(387, 108);
            this.richTextBox1.TabIndex = 68;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(613, 385);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(387, 110);
            this.richTextBox2.TabIndex = 69;
            this.richTextBox2.Text = "";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.YellowGreen;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(612, 516);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 60);
            this.button4.TabIndex = 73;
            this.button4.Text = "Registrar";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.YellowGreen;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(709, 516);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 60);
            this.button3.TabIndex = 72;
            this.button3.Text = "Editar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.YellowGreen;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(811, 516);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 60);
            this.button2.TabIndex = 71;
            this.button2.Text = "Limpiar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(908, 516);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 60);
            this.button1.TabIndex = 70;
            this.button1.Text = "Eliminar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(119, 126);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(227, 20);
            this.textBox4.TabIndex = 74;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.YellowGreen;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(22, 124);
            this.button5.Name = "button5";
            this.button5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button5.Size = new System.Drawing.Size(91, 25);
            this.button5.TabIndex = 75;
            this.button5.Text = "Buscar";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // btnCerrarUsuario
            // 
            this.btnCerrarUsuario.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCerrarUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrarUsuario.BackgroundImage")));
            this.btnCerrarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrarUsuario.Location = new System.Drawing.Point(1015, 12);
            this.btnCerrarUsuario.Name = "btnCerrarUsuario";
            this.btnCerrarUsuario.Size = new System.Drawing.Size(23, 23);
            this.btnCerrarUsuario.TabIndex = 76;
            this.btnCerrarUsuario.UseVisualStyleBackColor = true;
            this.btnCerrarUsuario.Click += new System.EventHandler(this.btnCerrarUsuario_Click);
            // 
            // dataSetBDA
            // 
            this.dataSetBDA.DataSetName = "DataSetBDA";
            this.dataSetBDA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROCESOVENTABindingSource
            // 
            this.pROCESOVENTABindingSource.DataMember = "PROCESO_VENTA";
            this.pROCESOVENTABindingSource.DataSource = this.dataSetBDA;
            // 
            // pROCESO_VENTATableAdapter
            // 
            this.pROCESO_VENTATableAdapter.ClearBeforeFill = true;
            // 
            // dataSetProcesosVenta
            // 
            this.dataSetProcesosVenta.DataSetName = "DataSetProcesosVenta";
            this.dataSetProcesosVenta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROCESOVENTABindingSource1
            // 
            this.pROCESOVENTABindingSource1.DataMember = "PROCESO_VENTA";
            this.pROCESOVENTABindingSource1.DataSource = this.dataSetProcesosVenta;
            // 
            // pROCESO_VENTATableAdapter1
            // 
            this.pROCESO_VENTATableAdapter1.ClearBeforeFill = true;
            // 
            // iDPROCESODataGridViewTextBoxColumn
            // 
            this.iDPROCESODataGridViewTextBoxColumn.DataPropertyName = "ID_PROCESO";
            this.iDPROCESODataGridViewTextBoxColumn.HeaderText = "ID_PROCESO";
            this.iDPROCESODataGridViewTextBoxColumn.Name = "iDPROCESODataGridViewTextBoxColumn";
            // 
            // iNFORMACIONVENTADataGridViewTextBoxColumn
            // 
            this.iNFORMACIONVENTADataGridViewTextBoxColumn.DataPropertyName = "INFORMACION_VENTA";
            this.iNFORMACIONVENTADataGridViewTextBoxColumn.HeaderText = "INFORMACION_VENTA";
            this.iNFORMACIONVENTADataGridViewTextBoxColumn.Name = "iNFORMACIONVENTADataGridViewTextBoxColumn";
            // 
            // oFERTAPRODDataGridViewTextBoxColumn
            // 
            this.oFERTAPRODDataGridViewTextBoxColumn.DataPropertyName = "OFERTA_PROD";
            this.oFERTAPRODDataGridViewTextBoxColumn.HeaderText = "OFERTA_PROD";
            this.oFERTAPRODDataGridViewTextBoxColumn.Name = "oFERTAPRODDataGridViewTextBoxColumn";
            // 
            // pRODUCTORIDPRODUCDataGridViewTextBoxColumn
            // 
            this.pRODUCTORIDPRODUCDataGridViewTextBoxColumn.DataPropertyName = "PRODUCTOR_ID_PRODUC";
            this.pRODUCTORIDPRODUCDataGridViewTextBoxColumn.HeaderText = "PRODUCTOR_ID_PRODUC";
            this.pRODUCTORIDPRODUCDataGridViewTextBoxColumn.Name = "pRODUCTORIDPRODUCDataGridViewTextBoxColumn";
            // 
            // cONTRATOVENTAIDCONTDataGridViewTextBoxColumn
            // 
            this.cONTRATOVENTAIDCONTDataGridViewTextBoxColumn.DataPropertyName = "CONTRATO_VENTA_ID_CONT";
            this.cONTRATOVENTAIDCONTDataGridViewTextBoxColumn.HeaderText = "CONTRATO_VENTA_ID_CONT";
            this.cONTRATOVENTAIDCONTDataGridViewTextBoxColumn.Name = "cONTRATOVENTAIDCONTDataGridViewTextBoxColumn";
            // 
            // ProcesosDeVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.btnCerrarUsuario);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProcesosDeVentas";
            this.Text = "ProcesosDeVentas";
            this.Load += new System.EventHandler(this.ProcesosDeVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBDA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROCESOVENTABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProcesosVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROCESOVENTABindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnCerrarUsuario;
        private DataSetBDA dataSetBDA;
        private System.Windows.Forms.BindingSource pROCESOVENTABindingSource;
        private DataSetBDATableAdapters.PROCESO_VENTATableAdapter pROCESO_VENTATableAdapter;
        private DataSetProcesosVenta dataSetProcesosVenta;
        private System.Windows.Forms.BindingSource pROCESOVENTABindingSource1;
        private DataSetProcesosVentaTableAdapters.PROCESO_VENTATableAdapter pROCESO_VENTATableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPROCESODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNFORMACIONVENTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oFERTAPRODDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCTORIDPRODUCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONTRATOVENTAIDCONTDataGridViewTextBoxColumn;
    }
}