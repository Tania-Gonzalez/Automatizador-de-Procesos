﻿namespace ProyectoResidencias
{
    partial class CredencialesDisponibles
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Titulo1 = new System.Windows.Forms.Panel();
            this.Titulo1Texto = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.folioCredencialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaSolicitudDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDisponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credencialesDisponiblesclsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Titulo1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.credencialesDisponiblesclsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Titulo1
            // 
            this.Titulo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Titulo1.Controls.Add(this.Titulo1Texto);
            this.Titulo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Titulo1.Location = new System.Drawing.Point(0, 0);
            this.Titulo1.Name = "Titulo1";
            this.Titulo1.Size = new System.Drawing.Size(970, 32);
            this.Titulo1.TabIndex = 103;
            // 
            // Titulo1Texto
            // 
            this.Titulo1Texto.AutoSize = true;
            this.Titulo1Texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo1Texto.ForeColor = System.Drawing.Color.Gainsboro;
            this.Titulo1Texto.Location = new System.Drawing.Point(372, 6);
            this.Titulo1Texto.Name = "Titulo1Texto";
            this.Titulo1Texto.Size = new System.Drawing.Size(216, 20);
            this.Titulo1Texto.TabIndex = 66;
            this.Titulo1Texto.Text = "Credenciales Disponibles:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.folioCredencialDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.fechaSolicitudDataGridViewTextBoxColumn,
            this.FechaDisponible});
            this.dataGridView1.DataSource = this.credencialesDisponiblesclsBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(970, 468);
            this.dataGridView1.TabIndex = 104;
            // 
            // folioCredencialDataGridViewTextBoxColumn
            // 
            this.folioCredencialDataGridViewTextBoxColumn.DataPropertyName = "FolioCredencial";
            this.folioCredencialDataGridViewTextBoxColumn.HeaderText = "Folio Credencial";
            this.folioCredencialDataGridViewTextBoxColumn.Name = "folioCredencialDataGridViewTextBoxColumn";
            this.folioCredencialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre Estudiante";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaSolicitudDataGridViewTextBoxColumn
            // 
            this.fechaSolicitudDataGridViewTextBoxColumn.DataPropertyName = "FechaSolicitud";
            this.fechaSolicitudDataGridViewTextBoxColumn.HeaderText = "Fecha Solicitud";
            this.fechaSolicitudDataGridViewTextBoxColumn.Name = "fechaSolicitudDataGridViewTextBoxColumn";
            this.fechaSolicitudDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FechaDisponible
            // 
            this.FechaDisponible.DataPropertyName = "FechaDisponible";
            this.FechaDisponible.HeaderText = "Fecha Disponible";
            this.FechaDisponible.Name = "FechaDisponible";
            this.FechaDisponible.ReadOnly = true;
            // 
            // credencialesDisponiblesclsBindingSource
            // 
            this.credencialesDisponiblesclsBindingSource.DataSource = typeof(ProyectoResidencias.CredencialesDisponiblescls);
            // 
            // CredencialesDisponibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Titulo1);
            this.Name = "CredencialesDisponibles";
            this.Size = new System.Drawing.Size(970, 500);
            this.Titulo1.ResumeLayout(false);
            this.Titulo1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.credencialesDisponiblesclsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Titulo1;
        private System.Windows.Forms.Label Titulo1Texto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource credencialesDisponiblesclsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn folioCredencialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaSolicitudDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDisponible;
    }
}
