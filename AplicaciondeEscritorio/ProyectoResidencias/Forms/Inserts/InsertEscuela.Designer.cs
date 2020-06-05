namespace ProyectoResidencias
{
    partial class InsertEscuela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertEscuela));
            this.NombreEsc = new System.Windows.Forms.TextBox();
            this.Guardar = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label175 = new System.Windows.Forms.Label();
            this.pictureBox145 = new System.Windows.Forms.PictureBox();
            this.label173 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Cerrar = new System.Windows.Forms.Button();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox145)).BeginInit();
            this.SuspendLayout();
            // 
            // NombreEsc
            // 
            this.NombreEsc.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.NombreEsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreEsc.Location = new System.Drawing.Point(172, 95);
            this.NombreEsc.MaxLength = 100;
            this.NombreEsc.Name = "NombreEsc";
            this.NombreEsc.Size = new System.Drawing.Size(518, 22);
            this.NombreEsc.TabIndex = 1;
            this.NombreEsc.Leave += new System.EventHandler(this.NombreEsc_Leave);
            // 
            // Guardar
            // 
            this.Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(92)))), ((int)(((byte)(77)))));
            this.Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Guardar.Location = new System.Drawing.Point(326, 180);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(107, 39);
            this.Guardar.TabIndex = 2;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = false;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel14.Controls.Add(this.Cerrar);
            this.panel14.Controls.Add(this.label175);
            this.panel14.Location = new System.Drawing.Point(5, 5);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(747, 36);
            this.panel14.TabIndex = 228;
            // 
            // label175
            // 
            this.label175.AutoSize = true;
            this.label175.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label175.ForeColor = System.Drawing.Color.Gainsboro;
            this.label175.Location = new System.Drawing.Point(297, 6);
            this.label175.Name = "label175";
            this.label175.Size = new System.Drawing.Size(157, 20);
            this.label175.TabIndex = 1;
            this.label175.Text = "Registrar Escuela:";
            // 
            // pictureBox145
            // 
            this.pictureBox145.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox145.Image")));
            this.pictureBox145.Location = new System.Drawing.Point(72, 97);
            this.pictureBox145.Name = "pictureBox145";
            this.pictureBox145.Size = new System.Drawing.Size(10, 14);
            this.pictureBox145.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox145.TabIndex = 236;
            this.pictureBox145.TabStop = false;
            // 
            // label173
            // 
            this.label173.AutoSize = true;
            this.label173.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label173.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(92)))), ((int)(((byte)(77)))));
            this.label173.Location = new System.Drawing.Point(87, 98);
            this.label173.Name = "label173";
            this.label173.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label173.Size = new System.Drawing.Size(67, 16);
            this.label173.TabIndex = 235;
            this.label173.Text = "Nombre:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel4.Location = new System.Drawing.Point(5, 34);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(4, 210);
            this.panel4.TabIndex = 1017;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel1.Location = new System.Drawing.Point(748, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(4, 210);
            this.panel1.TabIndex = 1018;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel3.Location = new System.Drawing.Point(6, 241);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(745, 4);
            this.panel3.TabIndex = 1019;
            // 
            // Cerrar
            // 
            this.Cerrar.BackColor = System.Drawing.Color.Brown;
            this.Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cerrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Cerrar.Location = new System.Drawing.Point(701, 3);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(36, 30);
            this.Cerrar.TabIndex = 240;
            this.Cerrar.Text = "x";
            this.Cerrar.UseVisualStyleBackColor = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // InsertEscuela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(758, 251);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox145);
            this.Controls.Add(this.label173);
            this.Controls.Add(this.NombreEsc);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.panel14);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InsertEscuela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox145)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NombreEsc;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label175;
        private System.Windows.Forms.PictureBox pictureBox145;
        private System.Windows.Forms.Label label173;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Cerrar;
    }
}