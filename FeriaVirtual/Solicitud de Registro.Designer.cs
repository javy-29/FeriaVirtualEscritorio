namespace FeriaVirtual
{
    partial class Solicitud_de_Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Solicitud_de_Registro));
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrarUsuario = new System.Windows.Forms.Button();
            this.dgvSolicitudRegistro = new System.Windows.Forms.DataGridView();
            this.mOSTRARREGISTROBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSolicitudRegistro = new FeriaVirtual.DataSetSolicitudRegistro();
            this.btnEliminarSolicitud = new System.Windows.Forms.Button();
            this.btnActualizarRegistro = new System.Windows.Forms.Button();
            this.mOSTRARREGISTROTableAdapter = new FeriaVirtual.DataSetSolicitudRegistroTableAdapters.MOSTRARREGISTROTableAdapter();
            this.RUT_PERSONA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPELLIDOPATERNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPELLIDOMATERNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIRECCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIUDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cORREODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEFONODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pASSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOLPERSONADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNFORMACIONEXTRADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudRegistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOSTRARREGISTROBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSolicitudRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Solicitud de Registro";
            // 
            // btnCerrarUsuario
            // 
            this.btnCerrarUsuario.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCerrarUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrarUsuario.BackgroundImage")));
            this.btnCerrarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrarUsuario.Location = new System.Drawing.Point(1015, 9);
            this.btnCerrarUsuario.Name = "btnCerrarUsuario";
            this.btnCerrarUsuario.Size = new System.Drawing.Size(23, 23);
            this.btnCerrarUsuario.TabIndex = 8;
            this.btnCerrarUsuario.UseVisualStyleBackColor = true;
            this.btnCerrarUsuario.Click += new System.EventHandler(this.btnCerrarUsuario_Click);
            // 
            // dgvSolicitudRegistro
            // 
            this.dgvSolicitudRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSolicitudRegistro.AutoGenerateColumns = false;
            this.dgvSolicitudRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitudRegistro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RUT_PERSONA,
            this.nOMBREDataGridViewTextBoxColumn,
            this.aPELLIDOPATERNODataGridViewTextBoxColumn,
            this.aPELLIDOMATERNODataGridViewTextBoxColumn,
            this.dIRECCIONDataGridViewTextBoxColumn,
            this.cIUDADDataGridViewTextBoxColumn,
            this.cORREODataGridViewTextBoxColumn,
            this.tELEFONODataGridViewTextBoxColumn,
            this.pASSDataGridViewTextBoxColumn,
            this.rOLPERSONADataGridViewTextBoxColumn,
            this.iNFORMACIONEXTRADataGridViewTextBoxColumn});
            this.dgvSolicitudRegistro.DataSource = this.mOSTRARREGISTROBindingSource;
            this.dgvSolicitudRegistro.Location = new System.Drawing.Point(197, 91);
            this.dgvSolicitudRegistro.Name = "dgvSolicitudRegistro";
            this.dgvSolicitudRegistro.Size = new System.Drawing.Size(781, 437);
            this.dgvSolicitudRegistro.TabIndex = 9;
            this.dgvSolicitudRegistro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSolicitudRegistro_CellContentClick);
            // 
            // mOSTRARREGISTROBindingSource
            // 
            this.mOSTRARREGISTROBindingSource.DataMember = "MOSTRARREGISTRO";
            this.mOSTRARREGISTROBindingSource.DataSource = this.dataSetSolicitudRegistro;
            // 
            // dataSetSolicitudRegistro
            // 
            this.dataSetSolicitudRegistro.DataSetName = "DataSetSolicitudRegistro";
            this.dataSetSolicitudRegistro.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnEliminarSolicitud
            // 
            this.btnEliminarSolicitud.BackColor = System.Drawing.Color.YellowGreen;
            this.btnEliminarSolicitud.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarSolicitud.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarSolicitud.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarSolicitud.Image")));
            this.btnEliminarSolicitud.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminarSolicitud.Location = new System.Drawing.Point(50, 468);
            this.btnEliminarSolicitud.Name = "btnEliminarSolicitud";
            this.btnEliminarSolicitud.Size = new System.Drawing.Size(91, 60);
            this.btnEliminarSolicitud.TabIndex = 10;
            this.btnEliminarSolicitud.Text = "Eliminar";
            this.btnEliminarSolicitud.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminarSolicitud.UseVisualStyleBackColor = false;
            this.btnEliminarSolicitud.Click += new System.EventHandler(this.btnEliminarSolicitud_Click);
            // 
            // btnActualizarRegistro
            // 
            this.btnActualizarRegistro.BackColor = System.Drawing.Color.YellowGreen;
            this.btnActualizarRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarRegistro.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarRegistro.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarRegistro.Image")));
            this.btnActualizarRegistro.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnActualizarRegistro.Location = new System.Drawing.Point(50, 391);
            this.btnActualizarRegistro.Name = "btnActualizarRegistro";
            this.btnActualizarRegistro.Size = new System.Drawing.Size(91, 60);
            this.btnActualizarRegistro.TabIndex = 11;
            this.btnActualizarRegistro.Text = "Actualizar";
            this.btnActualizarRegistro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnActualizarRegistro.UseVisualStyleBackColor = false;
            this.btnActualizarRegistro.Click += new System.EventHandler(this.btnActualizarRegistro_Click);
            // 
            // mOSTRARREGISTROTableAdapter
            // 
            this.mOSTRARREGISTROTableAdapter.ClearBeforeFill = true;
            // 
            // RUT_PERSONA
            // 
            this.RUT_PERSONA.DataPropertyName = "RUT_PERSONA";
            this.RUT_PERSONA.HeaderText = "RUT_PERSONA";
            this.RUT_PERSONA.Name = "RUT_PERSONA";
            // 
            // nOMBREDataGridViewTextBoxColumn
            // 
            this.nOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.Name = "nOMBREDataGridViewTextBoxColumn";
            // 
            // aPELLIDOPATERNODataGridViewTextBoxColumn
            // 
            this.aPELLIDOPATERNODataGridViewTextBoxColumn.DataPropertyName = "APELLIDO_PATERNO";
            this.aPELLIDOPATERNODataGridViewTextBoxColumn.HeaderText = "APELLIDO_PATERNO";
            this.aPELLIDOPATERNODataGridViewTextBoxColumn.Name = "aPELLIDOPATERNODataGridViewTextBoxColumn";
            // 
            // aPELLIDOMATERNODataGridViewTextBoxColumn
            // 
            this.aPELLIDOMATERNODataGridViewTextBoxColumn.DataPropertyName = "APELLIDO_MATERNO";
            this.aPELLIDOMATERNODataGridViewTextBoxColumn.HeaderText = "APELLIDO_MATERNO";
            this.aPELLIDOMATERNODataGridViewTextBoxColumn.Name = "aPELLIDOMATERNODataGridViewTextBoxColumn";
            // 
            // dIRECCIONDataGridViewTextBoxColumn
            // 
            this.dIRECCIONDataGridViewTextBoxColumn.DataPropertyName = "DIRECCION";
            this.dIRECCIONDataGridViewTextBoxColumn.HeaderText = "DIRECCION";
            this.dIRECCIONDataGridViewTextBoxColumn.Name = "dIRECCIONDataGridViewTextBoxColumn";
            // 
            // cIUDADDataGridViewTextBoxColumn
            // 
            this.cIUDADDataGridViewTextBoxColumn.DataPropertyName = "CIUDAD";
            this.cIUDADDataGridViewTextBoxColumn.HeaderText = "CIUDAD";
            this.cIUDADDataGridViewTextBoxColumn.Name = "cIUDADDataGridViewTextBoxColumn";
            // 
            // cORREODataGridViewTextBoxColumn
            // 
            this.cORREODataGridViewTextBoxColumn.DataPropertyName = "CORREO";
            this.cORREODataGridViewTextBoxColumn.HeaderText = "CORREO";
            this.cORREODataGridViewTextBoxColumn.Name = "cORREODataGridViewTextBoxColumn";
            // 
            // tELEFONODataGridViewTextBoxColumn
            // 
            this.tELEFONODataGridViewTextBoxColumn.DataPropertyName = "TELEFONO";
            this.tELEFONODataGridViewTextBoxColumn.HeaderText = "TELEFONO";
            this.tELEFONODataGridViewTextBoxColumn.Name = "tELEFONODataGridViewTextBoxColumn";
            // 
            // pASSDataGridViewTextBoxColumn
            // 
            this.pASSDataGridViewTextBoxColumn.DataPropertyName = "PASS";
            this.pASSDataGridViewTextBoxColumn.HeaderText = "PASS";
            this.pASSDataGridViewTextBoxColumn.Name = "pASSDataGridViewTextBoxColumn";
            // 
            // rOLPERSONADataGridViewTextBoxColumn
            // 
            this.rOLPERSONADataGridViewTextBoxColumn.DataPropertyName = "ROL_PERSONA";
            this.rOLPERSONADataGridViewTextBoxColumn.HeaderText = "ROL_PERSONA";
            this.rOLPERSONADataGridViewTextBoxColumn.Name = "rOLPERSONADataGridViewTextBoxColumn";
            // 
            // iNFORMACIONEXTRADataGridViewTextBoxColumn
            // 
            this.iNFORMACIONEXTRADataGridViewTextBoxColumn.DataPropertyName = "INFORMACION_EXTRA";
            this.iNFORMACIONEXTRADataGridViewTextBoxColumn.HeaderText = "INFORMACION_EXTRA";
            this.iNFORMACIONEXTRADataGridViewTextBoxColumn.Name = "iNFORMACIONEXTRADataGridViewTextBoxColumn";
            // 
            // Solicitud_de_Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.btnActualizarRegistro);
            this.Controls.Add(this.btnEliminarSolicitud);
            this.Controls.Add(this.dgvSolicitudRegistro);
            this.Controls.Add(this.btnCerrarUsuario);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Solicitud_de_Registro";
            this.Text = "Solicitud_de_Registro";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudRegistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOSTRARREGISTROBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSolicitudRegistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrarUsuario;
        private System.Windows.Forms.DataGridView dgvSolicitudRegistro;
        private System.Windows.Forms.Button btnEliminarSolicitud;
        private System.Windows.Forms.Button btnActualizarRegistro;
        private DataSetSolicitudRegistroTableAdapters.MOSTRARREGISTROTableAdapter mOSTRARREGISTROTableAdapter;
        private System.Windows.Forms.BindingSource mOSTRARREGISTROBindingSource;
        private DataSetSolicitudRegistro dataSetSolicitudRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn RUT_PERSONA;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPELLIDOPATERNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPELLIDOMATERNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIRECCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIUDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cORREODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEFONODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pASSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOLPERSONADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNFORMACIONEXTRADataGridViewTextBoxColumn;
    }
}