﻿namespace ProyectoResidencias
{
    partial class EliminarReporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarReporte));
            this.btnDatosPersonales = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.Cerrar = new System.Windows.Forms.Button();
            this.label184 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.x49 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.p63 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p63)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDatosPersonales
            // 
            this.btnDatosPersonales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(92)))), ((int)(((byte)(77)))));
            this.btnDatosPersonales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDatosPersonales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatosPersonales.ForeColor = System.Drawing.Color.White;
            this.btnDatosPersonales.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDatosPersonales.Location = new System.Drawing.Point(192, 243);
            this.btnDatosPersonales.Name = "btnDatosPersonales";
            this.btnDatosPersonales.Size = new System.Drawing.Size(120, 39);
            this.btnDatosPersonales.TabIndex = 199;
            this.btnDatosPersonales.Text = "Eliminar";
            this.btnDatosPersonales.UseVisualStyleBackColor = false;
            this.btnDatosPersonales.Click += new System.EventHandler(this.BtnDatosPersonales_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(219, 164);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 21);
            this.comboBox1.TabIndex = 198;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(92)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(151, 165);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 197;
            this.label1.Text = "Mes :";
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel16.Controls.Add(this.Cerrar);
            this.panel16.Controls.Add(this.label184);
            this.panel16.Location = new System.Drawing.Point(5, 5);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(524, 38);
            this.panel16.TabIndex = 196;
            // 
            // Cerrar
            // 
            this.Cerrar.BackColor = System.Drawing.Color.Brown;
            this.Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cerrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Cerrar.Location = new System.Drawing.Point(481, 5);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(36, 30);
            this.Cerrar.TabIndex = 235;
            this.Cerrar.Text = "x";
            this.Cerrar.UseVisualStyleBackColor = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // label184
            // 
            this.label184.AutoSize = true;
            this.label184.BackColor = System.Drawing.Color.Transparent;
            this.label184.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label184.ForeColor = System.Drawing.Color.Gainsboro;
            this.label184.Location = new System.Drawing.Point(173, 10);
            this.label184.Name = "label184";
            this.label184.Size = new System.Drawing.Size(148, 20);
            this.label184.TabIndex = 1;
            this.label184.Text = "Eliminar Reporte:";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.ForeColor = System.Drawing.Color.Black;
            this.Nombre.Location = new System.Drawing.Point(216, 124);
            this.Nombre.Name = "Nombre";
            this.Nombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Nombre.Size = new System.Drawing.Size(126, 16);
            this.Nombre.TabIndex = 195;
            this.Nombre.Text = "DepartamnetoBA";
            // 
            // x49
            // 
            this.x49.AutoSize = true;
            this.x49.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x49.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(92)))), ((int)(((byte)(77)))));
            this.x49.Location = new System.Drawing.Point(151, 123);
            this.x49.Name = "x49";
            this.x49.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.x49.Size = new System.Drawing.Size(67, 16);
            this.x49.TabIndex = 194;
            this.x49.Text = "Nombre:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(126, 167);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 14);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 202;
            this.pictureBox1.TabStop = false;
            // 
            // p63
            // 
            this.p63.Image = ((System.Drawing.Image)(resources.GetObject("p63.Image")));
            this.p63.Location = new System.Drawing.Point(126, 123);
            this.p63.Name = "p63";
            this.p63.Size = new System.Drawing.Size(10, 14);
            this.p63.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p63.TabIndex = 201;
            this.p63.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel3.Location = new System.Drawing.Point(9, 328);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(516, 4);
            this.panel3.TabIndex = 1009;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel1.Location = new System.Drawing.Point(525, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(4, 293);
            this.panel1.TabIndex = 1008;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel2.Location = new System.Drawing.Point(5, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 293);
            this.panel2.TabIndex = 1007;
            // 
            // EliminarReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(534, 339);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.p63);
            this.Controls.Add(this.btnDatosPersonales);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.x49);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EliminarReporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p63)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDatosPersonales;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label label184;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label x49;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox p63;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Cerrar;
    }
}