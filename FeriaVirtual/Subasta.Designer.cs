namespace FeriaVirtual
{
    partial class Subasta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Subasta));
            this.button5 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCerrarUsuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnActualizarSubasta = new System.Windows.Forms.Button();
            this.dgvSubasta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubasta)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.YellowGreen;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(29, 114);
            this.button5.Name = "button5";
            this.button5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button5.Size = new System.Drawing.Size(91, 25);
            this.button5.TabIndex = 94;
            this.button5.Text = "Buscar";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(126, 116);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(227, 20);
            this.textBox4.TabIndex = 93;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(714, 493);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 60);
            this.button1.TabIndex = 89;
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
            this.btnCerrarUsuario.TabIndex = 87;
            this.btnCerrarUsuario.UseVisualStyleBackColor = true;
            this.btnCerrarUsuario.Click += new System.EventHandler(this.btnCerrarUsuario_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 33);
            this.label1.TabIndex = 86;
            this.label1.Text = "Gestion de Subastas";
            // 
            // btnActualizarSubasta
            // 
            this.btnActualizarSubasta.BackColor = System.Drawing.Color.YellowGreen;
            this.btnActualizarSubasta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarSubasta.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarSubasta.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarSubasta.Image")));
            this.btnActualizarSubasta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnActualizarSubasta.Location = new System.Drawing.Point(601, 493);
            this.btnActualizarSubasta.Name = "btnActualizarSubasta";
            this.btnActualizarSubasta.Size = new System.Drawing.Size(91, 60);
            this.btnActualizarSubasta.TabIndex = 105;
            this.btnActualizarSubasta.Text = "Actualizar";
            this.btnActualizarSubasta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnActualizarSubasta.UseVisualStyleBackColor = false;
            this.btnActualizarSubasta.Click += new System.EventHandler(this.btnActualizarSubasta_Click);
            // 
            // dgvSubasta
            // 
            this.dgvSubasta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubasta.Location = new System.Drawing.Point(29, 159);
            this.dgvSubasta.Name = "dgvSubasta";
            this.dgvSubasta.Size = new System.Drawing.Size(514, 407);
            this.dgvSubasta.TabIndex = 106;
            // 
            // Subasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.dgvSubasta);
            this.Controls.Add(this.btnActualizarSubasta);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCerrarUsuario);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Subasta";
            this.Text = "Subasta";
            this.Load += new System.EventHandler(this.Subasta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubasta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCerrarUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnActualizarSubasta;
        private System.Windows.Forms.DataGridView dgvSubasta;
    }
}