namespace ProyectoResidencias.Forms.Curso
{
    partial class Programar_curso
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.Cerrar = new System.Windows.Forms.Button();
            this.label184 = new System.Windows.Forms.Label();
            this.dataGridViewCurso = new System.Windows.Forms.DataGridView();
            this.Programar = new System.Windows.Forms.Button();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel6.Location = new System.Drawing.Point(6, 480);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(920, 4);
            this.panel6.TabIndex = 1037;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel5.Location = new System.Drawing.Point(925, 27);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(4, 457);
            this.panel5.TabIndex = 1036;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel4.Location = new System.Drawing.Point(4, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(4, 457);
            this.panel4.TabIndex = 1035;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel16.Controls.Add(this.Cerrar);
            this.panel16.Controls.Add(this.label184);
            this.panel16.Location = new System.Drawing.Point(4, 5);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(925, 32);
            this.panel16.TabIndex = 1034;
            // 
            // Cerrar
            // 
            this.Cerrar.BackColor = System.Drawing.Color.Brown;
            this.Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cerrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Cerrar.Location = new System.Drawing.Point(882, 2);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(36, 30);
            this.Cerrar.TabIndex = 243;
            this.Cerrar.Text = "x";
            this.Cerrar.UseVisualStyleBackColor = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // label184
            // 
            this.label184.AutoSize = true;
            this.label184.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label184.ForeColor = System.Drawing.Color.White;
            this.label184.Location = new System.Drawing.Point(295, 8);
            this.label184.Name = "label184";
            this.label184.Size = new System.Drawing.Size(359, 20);
            this.label184.TabIndex = 1;
            this.label184.Text = "Lista de Estudiantes para programar Curso:";
            // 
            // dataGridViewCurso
            // 
            this.dataGridViewCurso.AllowUserToAddRows = false;
            this.dataGridViewCurso.AllowUserToDeleteRows = false;
            this.dataGridViewCurso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCurso.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewCurso.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewCurso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCurso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewCurso.ColumnHeadersHeight = 30;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCurso.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewCurso.EnableHeadersVisualStyles = false;
            this.dataGridViewCurso.Location = new System.Drawing.Point(62, 55);
            this.dataGridViewCurso.MaximumSize = new System.Drawing.Size(803, 426);
            this.dataGridViewCurso.Name = "dataGridViewCurso";
            this.dataGridViewCurso.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCurso.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewCurso.Size = new System.Drawing.Size(803, 403);
            this.dataGridViewCurso.TabIndex = 1033;
            // 
            // Programar
            // 
            this.Programar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(92)))), ((int)(((byte)(77)))));
            this.Programar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Programar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Programar.ForeColor = System.Drawing.Color.White;
            this.Programar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Programar.Location = new System.Drawing.Point(325, 491);
            this.Programar.Name = "Programar";
            this.Programar.Size = new System.Drawing.Size(206, 41);
            this.Programar.TabIndex = 1038;
            this.Programar.Text = "Programar Curso";
            this.Programar.UseVisualStyleBackColor = false;
            this.Programar.Click += new System.EventHandler(this.Programar_Click);
            // 
            // Programar_curso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 544);
            this.Controls.Add(this.Programar);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.dataGridViewCurso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Programar_curso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programar_curso";
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCurso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Button Cerrar;
        private System.Windows.Forms.Label label184;
        private System.Windows.Forms.DataGridView dataGridViewCurso;
        private System.Windows.Forms.Button Programar;
    }
}