﻿namespace ProyectoResidencias
{
    partial class Credenciales
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Cerrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSeleccionarRuta = new System.Windows.Forms.Button();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.GenerarEtiquetas = new System.Windows.Forms.Button();
            this.labelGenerando = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 75;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.Cerrar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 36);
            this.panel1.TabIndex = 74;
            // 
            // Cerrar
            // 
            this.Cerrar.BackColor = System.Drawing.Color.Brown;
            this.Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cerrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Cerrar.Location = new System.Drawing.Point(479, 3);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(36, 30);
            this.Cerrar.TabIndex = 238;
            this.Cerrar.Text = "x";
            this.Cerrar.UseVisualStyleBackColor = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(145, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 20);
            this.label3.TabIndex = 65;
            this.label3.Text = "Generador de Credenciales:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 73;
            this.label1.Text = "Guardar Documento:";
            // 
            // btnSeleccionarRuta
            // 
            this.btnSeleccionarRuta.BackColor = System.Drawing.Color.OliveDrab;
            this.btnSeleccionarRuta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeleccionarRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarRuta.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionarRuta.Location = new System.Drawing.Point(189, 140);
            this.btnSeleccionarRuta.Name = "btnSeleccionarRuta";
            this.btnSeleccionarRuta.Size = new System.Drawing.Size(141, 32);
            this.btnSeleccionarRuta.TabIndex = 72;
            this.btnSeleccionarRuta.Text = "Seleccionar Ruta";
            this.btnSeleccionarRuta.UseVisualStyleBackColor = false;
            this.btnSeleccionarRuta.Click += new System.EventHandler(this.btnSeleccionarRuta_Click);
            // 
            // txtRuta
            // 
            this.txtRuta.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtRuta.Enabled = false;
            this.txtRuta.Location = new System.Drawing.Point(63, 108);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(418, 20);
            this.txtRuta.TabIndex = 71;
            // 
            // GenerarEtiquetas
            // 
            this.GenerarEtiquetas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(92)))), ((int)(((byte)(77)))));
            this.GenerarEtiquetas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GenerarEtiquetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerarEtiquetas.ForeColor = System.Drawing.Color.White;
            this.GenerarEtiquetas.Location = new System.Drawing.Point(186, 232);
            this.GenerarEtiquetas.Name = "GenerarEtiquetas";
            this.GenerarEtiquetas.Size = new System.Drawing.Size(148, 58);
            this.GenerarEtiquetas.TabIndex = 70;
            this.GenerarEtiquetas.Text = "Generar";
            this.GenerarEtiquetas.UseVisualStyleBackColor = false;
            this.GenerarEtiquetas.Click += new System.EventHandler(this.GenerarEtiquetas_Click);
            // 
            // labelGenerando
            // 
            this.labelGenerando.AutoSize = true;
            this.labelGenerando.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenerando.Location = new System.Drawing.Point(212, 208);
            this.labelGenerando.Name = "labelGenerando";
            this.labelGenerando.Size = new System.Drawing.Size(102, 20);
            this.labelGenerando.TabIndex = 76;
            this.labelGenerando.Text = "Generando...";
            this.labelGenerando.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel3.Location = new System.Drawing.Point(9, 326);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(516, 4);
            this.panel3.TabIndex = 1015;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel2.Location = new System.Drawing.Point(525, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 293);
            this.panel2.TabIndex = 1014;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel4.Location = new System.Drawing.Point(5, 37);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(4, 293);
            this.panel4.TabIndex = 1013;
            // 
            // Credenciales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(534, 339);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.labelGenerando);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSeleccionarRuta);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.GenerarEtiquetas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Credenciales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSeleccionarRuta;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Button GenerarEtiquetas;
        private System.Windows.Forms.Label labelGenerando;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Cerrar;
    }
}