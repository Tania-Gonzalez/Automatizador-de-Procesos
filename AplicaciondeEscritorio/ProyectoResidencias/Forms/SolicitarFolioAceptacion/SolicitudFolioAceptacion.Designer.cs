﻿namespace ProyectoResidencias
{
    partial class SolicitudFolioAceptacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asuntoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinatarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solicitudFolioAceptacionListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel16 = new System.Windows.Forms.Panel();
            this.Cerrar = new System.Windows.Forms.Button();
            this.label184 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRegistrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudFolioAceptacionListBindingSource)).BeginInit();
            this.panel16.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.ColumnHeadersHeight = 30;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroDataGridViewTextBoxColumn,
            this.asuntoDataGridViewTextBoxColumn,
            this.destinatarioDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.solicitudFolioAceptacionListBindingSource;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(63, 55);
            this.dataGridView2.MaximumSize = new System.Drawing.Size(803, 426);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(803, 403);
            this.dataGridView2.TabIndex = 85;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // asuntoDataGridViewTextBoxColumn
            // 
            this.asuntoDataGridViewTextBoxColumn.DataPropertyName = "Asunto";
            this.asuntoDataGridViewTextBoxColumn.HeaderText = "Asunto";
            this.asuntoDataGridViewTextBoxColumn.Name = "asuntoDataGridViewTextBoxColumn";
            this.asuntoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // destinatarioDataGridViewTextBoxColumn
            // 
            this.destinatarioDataGridViewTextBoxColumn.DataPropertyName = "Destinatario";
            this.destinatarioDataGridViewTextBoxColumn.HeaderText = "Dirigido A:";
            this.destinatarioDataGridViewTextBoxColumn.Name = "destinatarioDataGridViewTextBoxColumn";
            this.destinatarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // solicitudFolioAceptacionListBindingSource
            // 
            this.solicitudFolioAceptacionListBindingSource.DataSource = typeof(ProyectoResidencias.SolicitudFolioAceptacionList);
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel16.Controls.Add(this.Cerrar);
            this.panel16.Controls.Add(this.label184);
            this.panel16.Location = new System.Drawing.Point(5, 5);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(925, 32);
            this.panel16.TabIndex = 174;
            // 
            // Cerrar
            // 
            this.Cerrar.BackColor = System.Drawing.Color.Brown;
            this.Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cerrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Cerrar.Location = new System.Drawing.Point(881, 2);
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
            this.label184.ForeColor = System.Drawing.Color.Gainsboro;
            this.label184.Location = new System.Drawing.Point(289, 6);
            this.label184.Name = "label184";
            this.label184.Size = new System.Drawing.Size(342, 20);
            this.label184.TabIndex = 1;
            this.label184.Text = "Lista de solicitud de folios de Aceptación:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel6.Location = new System.Drawing.Point(7, 481);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(920, 4);
            this.panel6.TabIndex = 1032;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel5.Location = new System.Drawing.Point(926, 28);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(4, 457);
            this.panel5.TabIndex = 1031;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel4.Location = new System.Drawing.Point(5, 28);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(4, 457);
            this.panel4.TabIndex = 1030;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(92)))), ((int)(((byte)(77)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRegistrar.Location = new System.Drawing.Point(379, 491);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(156, 41);
            this.btnRegistrar.TabIndex = 1033;
            this.btnRegistrar.Text = "Registrar Solicitud Folios de Aceptacion";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // SolicitudFolioAceptacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(935, 544);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.dataGridView2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SolicitudFolioAceptacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudFolioAceptacionListBindingSource)).EndInit();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource solicitudFolioAceptacionListBindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asuntoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinatarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label label184;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Cerrar;
        private System.Windows.Forms.Button btnRegistrar;
    }
}