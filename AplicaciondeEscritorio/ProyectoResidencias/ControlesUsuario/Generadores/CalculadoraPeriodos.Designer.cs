namespace ProyectoResidencias
{
    partial class CalculadoraPeriodos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculadoraPeriodos));
            this.DiasFestivos = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Calcular = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.HorasDiariasSV = new System.Windows.Forms.ComboBox();
            this.TextBoxPrograma = new System.Windows.Forms.TextBox();
            this.ProgramaNR = new System.Windows.Forms.ComboBox();
            this.FechaTermNR = new System.Windows.Forms.DateTimePicker();
            this.FechaInicioNR = new System.Windows.Forms.DateTimePicker();
            this.pictureBox124 = new System.Windows.Forms.PictureBox();
            this.label145 = new System.Windows.Forms.Label();
            this.pictureBox125 = new System.Windows.Forms.PictureBox();
            this.label146 = new System.Windows.Forms.Label();
            this.HorasDiariasNR = new System.Windows.Forms.TextBox();
            this.pictureBox126 = new System.Windows.Forms.PictureBox();
            this.label147 = new System.Windows.Forms.Label();
            this.HorasTotalesNR = new System.Windows.Forms.TextBox();
            this.pictureBox127 = new System.Windows.Forms.PictureBox();
            this.label148 = new System.Windows.Forms.Label();
            this.pictureBox128 = new System.Windows.Forms.PictureBox();
            this.label149 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox124)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox125)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox126)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox127)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox128)).BeginInit();
            this.SuspendLayout();
            // 
            // DiasFestivos
            // 
            this.DiasFestivos.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.DiasFestivos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DiasFestivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiasFestivos.ForeColor = System.Drawing.Color.White;
            this.DiasFestivos.Location = new System.Drawing.Point(650, 556);
            this.DiasFestivos.Name = "DiasFestivos";
            this.DiasFestivos.Size = new System.Drawing.Size(125, 38);
            this.DiasFestivos.TabIndex = 116;
            this.DiasFestivos.Text = "Dias Festivos";
            this.DiasFestivos.UseVisualStyleBackColor = false;
            this.DiasFestivos.Click += new System.EventHandler(this.DiasFestivos_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(224, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(551, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 132;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Calcular);
            this.panel1.Controls.Add(this.label33);
            this.panel1.Controls.Add(this.HorasDiariasSV);
            this.panel1.Controls.Add(this.TextBoxPrograma);
            this.panel1.Controls.Add(this.ProgramaNR);
            this.panel1.Controls.Add(this.FechaTermNR);
            this.panel1.Controls.Add(this.FechaInicioNR);
            this.panel1.Controls.Add(this.pictureBox124);
            this.panel1.Controls.Add(this.label145);
            this.panel1.Controls.Add(this.pictureBox125);
            this.panel1.Controls.Add(this.label146);
            this.panel1.Controls.Add(this.HorasDiariasNR);
            this.panel1.Controls.Add(this.pictureBox126);
            this.panel1.Controls.Add(this.label147);
            this.panel1.Controls.Add(this.HorasTotalesNR);
            this.panel1.Controls.Add(this.pictureBox127);
            this.panel1.Controls.Add(this.label148);
            this.panel1.Controls.Add(this.pictureBox128);
            this.panel1.Controls.Add(this.label149);
            this.panel1.Location = new System.Drawing.Point(224, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 384);
            this.panel1.TabIndex = 133;
            // 
            // Calcular
            // 
            this.Calcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(92)))), ((int)(((byte)(77)))));
            this.Calcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calcular.ForeColor = System.Drawing.Color.White;
            this.Calcular.Location = new System.Drawing.Point(177, 243);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(204, 38);
            this.Calcular.TabIndex = 136;
            this.Calcular.Text = "Calcular Periodo";
            this.Calcular.UseVisualStyleBackColor = false;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.Black;
            this.label33.Location = new System.Drawing.Point(283, 171);
            this.label33.Name = "label33";
            this.label33.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label33.Size = new System.Drawing.Size(36, 16);
            this.label33.TabIndex = 150;
            this.label33.Text = "Hrs.";
            // 
            // HorasDiariasSV
            // 
            this.HorasDiariasSV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HorasDiariasSV.FormattingEnabled = true;
            this.HorasDiariasSV.Items.AddRange(new object[] {
            "Seleccione",
            "4",
            "5",
            "6"});
            this.HorasDiariasSV.Location = new System.Drawing.Point(305, 76);
            this.HorasDiariasSV.Name = "HorasDiariasSV";
            this.HorasDiariasSV.Size = new System.Drawing.Size(103, 21);
            this.HorasDiariasSV.TabIndex = 133;
            this.HorasDiariasSV.TextChanged += new System.EventHandler(this.HorasDiariasSV_SelectedIndexChanged);
            this.HorasDiariasSV.Click += new System.EventHandler(this.HorasDiariasSV_SelectedIndexChanged);
            // 
            // TextBoxPrograma
            // 
            this.TextBoxPrograma.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TextBoxPrograma.Enabled = false;
            this.TextBoxPrograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPrograma.Location = new System.Drawing.Point(177, 35);
            this.TextBoxPrograma.Name = "TextBoxPrograma";
            this.TextBoxPrograma.ReadOnly = true;
            this.TextBoxPrograma.Size = new System.Drawing.Size(122, 22);
            this.TextBoxPrograma.TabIndex = 149;
            this.TextBoxPrograma.Click += new System.EventHandler(this.ProgramaNR_SelectedIndexChanged);
            this.TextBoxPrograma.TextChanged += new System.EventHandler(this.ProgramaNR_SelectedIndexChanged);
            // 
            // ProgramaNR
            // 
            this.ProgramaNR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProgramaNR.FormattingEnabled = true;
            this.ProgramaNR.Items.AddRange(new object[] {
            "Seleccione",
            "Servicio Social",
            "Prácticas Profesionales"});
            this.ProgramaNR.Location = new System.Drawing.Point(305, 35);
            this.ProgramaNR.Name = "ProgramaNR";
            this.ProgramaNR.Size = new System.Drawing.Size(148, 21);
            this.ProgramaNR.TabIndex = 132;
            this.ProgramaNR.TextChanged += new System.EventHandler(this.ProgramaNR_SelectedIndexChanged);
            this.ProgramaNR.Click += new System.EventHandler(this.ProgramaNR_SelectedIndexChanged);
            this.ProgramaNR.Validated += new System.EventHandler(this.ProgramaNR_SelectedIndexChanged);
            // 
            // FechaTermNR
            // 
            this.FechaTermNR.Location = new System.Drawing.Point(198, 330);
            this.FechaTermNR.Name = "FechaTermNR";
            this.FechaTermNR.Size = new System.Drawing.Size(210, 20);
            this.FechaTermNR.TabIndex = 137;
            // 
            // FechaInicioNR
            // 
            this.FechaInicioNR.Location = new System.Drawing.Point(182, 125);
            this.FechaInicioNR.Name = "FechaInicioNR";
            this.FechaInicioNR.Size = new System.Drawing.Size(226, 20);
            this.FechaInicioNR.TabIndex = 135;
            // 
            // pictureBox124
            // 
            this.pictureBox124.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox124.Image")));
            this.pictureBox124.Location = new System.Drawing.Point(35, 128);
            this.pictureBox124.Name = "pictureBox124";
            this.pictureBox124.Size = new System.Drawing.Size(10, 14);
            this.pictureBox124.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox124.TabIndex = 148;
            this.pictureBox124.TabStop = false;
            // 
            // label145
            // 
            this.label145.AutoSize = true;
            this.label145.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label145.ForeColor = System.Drawing.Color.Black;
            this.label145.Location = new System.Drawing.Point(60, 126);
            this.label145.Name = "label145";
            this.label145.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label145.Size = new System.Drawing.Size(118, 16);
            this.label145.TabIndex = 147;
            this.label145.Text = "Fecha de Inicio:";
            // 
            // pictureBox125
            // 
            this.pictureBox125.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox125.Image")));
            this.pictureBox125.Location = new System.Drawing.Point(35, 333);
            this.pictureBox125.Name = "pictureBox125";
            this.pictureBox125.Size = new System.Drawing.Size(10, 14);
            this.pictureBox125.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox125.TabIndex = 146;
            this.pictureBox125.TabStop = false;
            // 
            // label146
            // 
            this.label146.AutoSize = true;
            this.label146.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label146.ForeColor = System.Drawing.Color.Black;
            this.label146.Location = new System.Drawing.Point(60, 331);
            this.label146.Name = "label146";
            this.label146.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label146.Size = new System.Drawing.Size(138, 16);
            this.label146.TabIndex = 145;
            this.label146.Text = "Fecha de Término:";
            // 
            // HorasDiariasNR
            // 
            this.HorasDiariasNR.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.HorasDiariasNR.Enabled = false;
            this.HorasDiariasNR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HorasDiariasNR.Location = new System.Drawing.Point(177, 78);
            this.HorasDiariasNR.Name = "HorasDiariasNR";
            this.HorasDiariasNR.ReadOnly = true;
            this.HorasDiariasNR.Size = new System.Drawing.Size(122, 22);
            this.HorasDiariasNR.TabIndex = 144;
            this.HorasDiariasNR.Click += new System.EventHandler(this.HorasDiariasSV_SelectedIndexChanged);
            this.HorasDiariasNR.TextChanged += new System.EventHandler(this.HorasDiariasSV_SelectedIndexChanged);
            // 
            // pictureBox126
            // 
            this.pictureBox126.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox126.Image")));
            this.pictureBox126.Location = new System.Drawing.Point(35, 82);
            this.pictureBox126.Name = "pictureBox126";
            this.pictureBox126.Size = new System.Drawing.Size(10, 14);
            this.pictureBox126.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox126.TabIndex = 143;
            this.pictureBox126.TabStop = false;
            // 
            // label147
            // 
            this.label147.AutoSize = true;
            this.label147.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label147.ForeColor = System.Drawing.Color.Black;
            this.label147.Location = new System.Drawing.Point(60, 80);
            this.label147.Name = "label147";
            this.label147.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label147.Size = new System.Drawing.Size(108, 16);
            this.label147.TabIndex = 142;
            this.label147.Text = "Horas Diarias:";
            // 
            // HorasTotalesNR
            // 
            this.HorasTotalesNR.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.HorasTotalesNR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HorasTotalesNR.Location = new System.Drawing.Point(177, 167);
            this.HorasTotalesNR.MaxLength = 3;
            this.HorasTotalesNR.Name = "HorasTotalesNR";
            this.HorasTotalesNR.Size = new System.Drawing.Size(100, 22);
            this.HorasTotalesNR.TabIndex = 134;
            // 
            // pictureBox127
            // 
            this.pictureBox127.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox127.Image")));
            this.pictureBox127.Location = new System.Drawing.Point(35, 171);
            this.pictureBox127.Name = "pictureBox127";
            this.pictureBox127.Size = new System.Drawing.Size(10, 14);
            this.pictureBox127.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox127.TabIndex = 141;
            this.pictureBox127.TabStop = false;
            // 
            // label148
            // 
            this.label148.AutoSize = true;
            this.label148.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label148.ForeColor = System.Drawing.Color.Black;
            this.label148.Location = new System.Drawing.Point(60, 169);
            this.label148.Name = "label148";
            this.label148.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label148.Size = new System.Drawing.Size(111, 16);
            this.label148.TabIndex = 140;
            this.label148.Text = "Horas Totales:";
            // 
            // pictureBox128
            // 
            this.pictureBox128.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox128.Image")));
            this.pictureBox128.Location = new System.Drawing.Point(35, 40);
            this.pictureBox128.Name = "pictureBox128";
            this.pictureBox128.Size = new System.Drawing.Size(10, 14);
            this.pictureBox128.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox128.TabIndex = 139;
            this.pictureBox128.TabStop = false;
            // 
            // label149
            // 
            this.label149.AutoSize = true;
            this.label149.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label149.ForeColor = System.Drawing.Color.Black;
            this.label149.Location = new System.Drawing.Point(60, 38);
            this.label149.Name = "label149";
            this.label149.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label149.Size = new System.Drawing.Size(80, 16);
            this.label149.TabIndex = 138;
            this.label149.Text = "Programa:";
            // 
            // CalculadoraPeriodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DiasFestivos);
            this.Controls.Add(this.panel1);
            this.Name = "CalculadoraPeriodos";
            this.Size = new System.Drawing.Size(1010, 699);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox124)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox125)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox126)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox127)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox128)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DiasFestivos;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.ComboBox HorasDiariasSV;
        private System.Windows.Forms.TextBox TextBoxPrograma;
        private System.Windows.Forms.ComboBox ProgramaNR;
        private System.Windows.Forms.DateTimePicker FechaTermNR;
        private System.Windows.Forms.DateTimePicker FechaInicioNR;
        private System.Windows.Forms.PictureBox pictureBox124;
        private System.Windows.Forms.Label label145;
        private System.Windows.Forms.PictureBox pictureBox125;
        private System.Windows.Forms.Label label146;
        private System.Windows.Forms.TextBox HorasDiariasNR;
        private System.Windows.Forms.PictureBox pictureBox126;
        private System.Windows.Forms.Label label147;
        private System.Windows.Forms.TextBox HorasTotalesNR;
        private System.Windows.Forms.PictureBox pictureBox127;
        private System.Windows.Forms.Label label148;
        private System.Windows.Forms.PictureBox pictureBox128;
        private System.Windows.Forms.Label label149;
    }
}
