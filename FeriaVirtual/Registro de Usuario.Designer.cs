﻿namespace FeriaVirtual
{
    partial class Registro_de_Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_de_Usuario));
            this.label2 = new System.Windows.Forms.Label();
            this.btnCerrarUsuario = new System.Windows.Forms.Button();
            this.btnAdministrador = new System.Windows.Forms.Button();
            this.btnConsultor = new System.Windows.Forms.Button();
            this.panelRegistroUsuarios = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(363, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Registro de Usuario";
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
            // btnAdministrador
            // 
            this.btnAdministrador.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAdministrador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdministrador.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrador.Image = ((System.Drawing.Image)(resources.GetObject("btnAdministrador.Image")));
            this.btnAdministrador.Location = new System.Drawing.Point(33, 105);
            this.btnAdministrador.Name = "btnAdministrador";
            this.btnAdministrador.Size = new System.Drawing.Size(91, 60);
            this.btnAdministrador.TabIndex = 14;
            this.btnAdministrador.Text = "Administrador";
            this.btnAdministrador.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdministrador.UseVisualStyleBackColor = false;
            this.btnAdministrador.Click += new System.EventHandler(this.btnAdministrador_Click);
            // 
            // btnConsultor
            // 
            this.btnConsultor.BackColor = System.Drawing.Color.YellowGreen;
            this.btnConsultor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultor.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultor.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultor.Image")));
            this.btnConsultor.Location = new System.Drawing.Point(33, 171);
            this.btnConsultor.Name = "btnConsultor";
            this.btnConsultor.Size = new System.Drawing.Size(91, 60);
            this.btnConsultor.TabIndex = 13;
            this.btnConsultor.Text = "Consultores";
            this.btnConsultor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConsultor.UseVisualStyleBackColor = false;
            this.btnConsultor.Click += new System.EventHandler(this.btnConsultor_Click);
            // 
            // panelRegistroUsuarios
            // 
            this.panelRegistroUsuarios.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelRegistroUsuarios.Location = new System.Drawing.Point(183, 66);
            this.panelRegistroUsuarios.Name = "panelRegistroUsuarios";
            this.panelRegistroUsuarios.Size = new System.Drawing.Size(806, 489);
            this.panelRegistroUsuarios.TabIndex = 9;
            // 
            // Registro_de_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.btnAdministrador);
            this.Controls.Add(this.btnConsultor);
            this.Controls.Add(this.panelRegistroUsuarios);
            this.Controls.Add(this.btnCerrarUsuario);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registro_de_Usuario";
            this.Text = "Registro_de_Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCerrarUsuario;
        private System.Windows.Forms.Button btnAdministrador;
        private System.Windows.Forms.Button btnConsultor;
        private System.Windows.Forms.Panel panelRegistroUsuarios;
    }
}