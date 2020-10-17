namespace FeriaVirtual
{
    partial class SolicitudVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolicitudVentas));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCerrarUsuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSetSolicitudVentas = new FeriaVirtual.DataSetSolicitudVentas();
            this.sOLICITUDVENTABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sOLICITUD_VENTATableAdapter = new FeriaVirtual.DataSetSolicitudVentasTableAdapters.SOLICITUD_VENTATableAdapter();
            this.iDSOLIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMEROSOLIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPCIONSOLIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIRECCIONENTREGADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTEIDCLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSolicitudVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOLICITUDVENTABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.YellowGreen;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(52, 394);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 60);
            this.button2.TabIndex = 16;
            this.button2.Text = "Imprimir";
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
            this.button1.Location = new System.Drawing.Point(52, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 60);
            this.button1.TabIndex = 15;
            this.button1.Text = "Eliminar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSOLIDataGridViewTextBoxColumn,
            this.nUMEROSOLIDataGridViewTextBoxColumn,
            this.dESCRIPCIONSOLIDataGridViewTextBoxColumn,
            this.dIRECCIONENTREGADataGridViewTextBoxColumn,
            this.cLIENTEIDCLIENTEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sOLICITUDVENTABindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(198, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(741, 437);
            this.dataGridView1.TabIndex = 14;
            // 
            // btnCerrarUsuario
            // 
            this.btnCerrarUsuario.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCerrarUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrarUsuario.BackgroundImage")));
            this.btnCerrarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrarUsuario.Location = new System.Drawing.Point(1015, 12);
            this.btnCerrarUsuario.Name = "btnCerrarUsuario";
            this.btnCerrarUsuario.Size = new System.Drawing.Size(23, 23);
            this.btnCerrarUsuario.TabIndex = 13;
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
            this.label1.Size = new System.Drawing.Size(268, 33);
            this.label1.TabIndex = 12;
            this.label1.Text = "Solicitud de Ventas";
            // 
            // dataSetSolicitudVentas
            // 
            this.dataSetSolicitudVentas.DataSetName = "DataSetSolicitudVentas";
            this.dataSetSolicitudVentas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sOLICITUDVENTABindingSource
            // 
            this.sOLICITUDVENTABindingSource.DataMember = "SOLICITUD_VENTA";
            this.sOLICITUDVENTABindingSource.DataSource = this.dataSetSolicitudVentas;
            // 
            // sOLICITUD_VENTATableAdapter
            // 
            this.sOLICITUD_VENTATableAdapter.ClearBeforeFill = true;
            // 
            // iDSOLIDataGridViewTextBoxColumn
            // 
            this.iDSOLIDataGridViewTextBoxColumn.DataPropertyName = "ID_SOLI";
            this.iDSOLIDataGridViewTextBoxColumn.HeaderText = "ID_SOLI";
            this.iDSOLIDataGridViewTextBoxColumn.Name = "iDSOLIDataGridViewTextBoxColumn";
            // 
            // nUMEROSOLIDataGridViewTextBoxColumn
            // 
            this.nUMEROSOLIDataGridViewTextBoxColumn.DataPropertyName = "NUMERO_SOLI";
            this.nUMEROSOLIDataGridViewTextBoxColumn.HeaderText = "NUMERO_SOLI";
            this.nUMEROSOLIDataGridViewTextBoxColumn.Name = "nUMEROSOLIDataGridViewTextBoxColumn";
            // 
            // dESCRIPCIONSOLIDataGridViewTextBoxColumn
            // 
            this.dESCRIPCIONSOLIDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPCION_SOLI";
            this.dESCRIPCIONSOLIDataGridViewTextBoxColumn.HeaderText = "DESCRIPCION_SOLI";
            this.dESCRIPCIONSOLIDataGridViewTextBoxColumn.Name = "dESCRIPCIONSOLIDataGridViewTextBoxColumn";
            // 
            // dIRECCIONENTREGADataGridViewTextBoxColumn
            // 
            this.dIRECCIONENTREGADataGridViewTextBoxColumn.DataPropertyName = "DIRECCION_ENTREGA";
            this.dIRECCIONENTREGADataGridViewTextBoxColumn.HeaderText = "DIRECCION_ENTREGA";
            this.dIRECCIONENTREGADataGridViewTextBoxColumn.Name = "dIRECCIONENTREGADataGridViewTextBoxColumn";
            // 
            // cLIENTEIDCLIENTEDataGridViewTextBoxColumn
            // 
            this.cLIENTEIDCLIENTEDataGridViewTextBoxColumn.DataPropertyName = "CLIENTE_ID_CLIENTE";
            this.cLIENTEIDCLIENTEDataGridViewTextBoxColumn.HeaderText = "CLIENTE_ID_CLIENTE";
            this.cLIENTEIDCLIENTEDataGridViewTextBoxColumn.Name = "cLIENTEIDCLIENTEDataGridViewTextBoxColumn";
            // 
            // SolicitudVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCerrarUsuario);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SolicitudVentas";
            this.Text = "SolicitudVentas";
            this.Load += new System.EventHandler(this.SolicitudVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSolicitudVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOLICITUDVENTABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCerrarUsuario;
        private System.Windows.Forms.Label label1;
        private DataSetSolicitudVentas dataSetSolicitudVentas;
        private System.Windows.Forms.BindingSource sOLICITUDVENTABindingSource;
        private DataSetSolicitudVentasTableAdapters.SOLICITUD_VENTATableAdapter sOLICITUD_VENTATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSOLIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMEROSOLIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPCIONSOLIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIRECCIONENTREGADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTEIDCLIENTEDataGridViewTextBoxColumn;
    }
}