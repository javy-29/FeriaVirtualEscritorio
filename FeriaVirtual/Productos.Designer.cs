namespace FeriaVirtual
{
    partial class Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.button5 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCerrarUsuario = new System.Windows.Forms.Button();
            this.btnActualizarProductos = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.YellowGreen;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(30, 121);
            this.button5.Name = "button5";
            this.button5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button5.Size = new System.Drawing.Size(91, 25);
            this.button5.TabIndex = 77;
            this.button5.Text = "Buscar";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(127, 123);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(227, 20);
            this.textBox4.TabIndex = 76;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(347, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(318, 33);
            this.label5.TabIndex = 78;
            this.label5.Text = "Almacen de Productos";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(759, 511);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 60);
            this.button1.TabIndex = 91;
            this.button1.Text = "Eliminar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnCerrarUsuario
            // 
            this.btnCerrarUsuario.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCerrarUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrarUsuario.BackgroundImage")));
            this.btnCerrarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrarUsuario.Location = new System.Drawing.Point(1015, 12);
            this.btnCerrarUsuario.Name = "btnCerrarUsuario";
            this.btnCerrarUsuario.Size = new System.Drawing.Size(23, 23);
            this.btnCerrarUsuario.TabIndex = 94;
            this.btnCerrarUsuario.UseVisualStyleBackColor = true;
            this.btnCerrarUsuario.Click += new System.EventHandler(this.btnCerrarUsuario_Click);
            // 
            // btnActualizarProductos
            // 
            this.btnActualizarProductos.BackColor = System.Drawing.Color.YellowGreen;
            this.btnActualizarProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarProductos.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarProductos.Image")));
            this.btnActualizarProductos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnActualizarProductos.Location = new System.Drawing.Point(638, 511);
            this.btnActualizarProductos.Name = "btnActualizarProductos";
            this.btnActualizarProductos.Size = new System.Drawing.Size(91, 60);
            this.btnActualizarProductos.TabIndex = 97;
            this.btnActualizarProductos.Text = "Actualizar";
            this.btnActualizarProductos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnActualizarProductos.UseVisualStyleBackColor = false;
            this.btnActualizarProductos.Click += new System.EventHandler(this.btnActualizarProductos_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(30, 152);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(566, 419);
            this.dgvProductos.TabIndex = 98;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.btnActualizarProductos);
            this.Controls.Add(this.btnCerrarUsuario);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCerrarUsuario;
        private System.Windows.Forms.Button btnActualizarProductos;
        private System.Windows.Forms.DataGridView dgvProductos;
    }
}