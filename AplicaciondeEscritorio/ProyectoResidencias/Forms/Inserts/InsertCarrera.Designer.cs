namespace ProyectoResidencias
{

    partial class InsertCarrera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertCarrera));
            this.NombreCarrera = new System.Windows.Forms.TextBox();
            this.label178 = new System.Windows.Forms.Label();
            this.NivelCampo = new System.Windows.Forms.TextBox();
            this.label183 = new System.Windows.Forms.Label();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label175 = new System.Windows.Forms.Label();
            this.pictureBox150 = new System.Windows.Forms.PictureBox();
            this.ListaNivel = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox144 = new System.Windows.Forms.PictureBox();
            this.pictureBox145 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox150)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox144)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox145)).BeginInit();
            this.SuspendLayout();
            // 
            // NombreCarrera
            // 
            this.NombreCarrera.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.NombreCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreCarrera.Location = new System.Drawing.Point(143, 94);
            this.NombreCarrera.MaxLength = 100;
            this.NombreCarrera.Name = "NombreCarrera";
            this.NombreCarrera.Size = new System.Drawing.Size(457, 22);
            this.NombreCarrera.TabIndex = 1;
            this.NombreCarrera.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Sololetras);
            this.NombreCarrera.Leave += new System.EventHandler(this.NombreCarrera_Leave);
            this.NombreCarrera.Validating += new System.ComponentModel.CancelEventHandler(this.NombreCarrera_Validating);
            // 
            // label178
            // 
            this.label178.AutoSize = true;
            this.label178.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label178.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(92)))), ((int)(((byte)(77)))));
            this.label178.Location = new System.Drawing.Point(80, 96);
            this.label178.Name = "label178";
            this.label178.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label178.Size = new System.Drawing.Size(67, 16);
            this.label178.TabIndex = 225;
            this.label178.Text = "Nombre:";
            // 
            // NivelCampo
            // 
            this.NivelCampo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.NivelCampo.Enabled = false;
            this.NivelCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NivelCampo.Location = new System.Drawing.Point(144, 142);
            this.NivelCampo.MaxLength = 80;
            this.NivelCampo.Name = "NivelCampo";
            this.NivelCampo.Size = new System.Drawing.Size(231, 22);
            this.NivelCampo.TabIndex = 208;
            // 
            // label183
            // 
            this.label183.AutoSize = true;
            this.label183.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label183.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(92)))), ((int)(((byte)(77)))));
            this.label183.Location = new System.Drawing.Point(80, 145);
            this.label183.Name = "label183";
            this.label183.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label183.Size = new System.Drawing.Size(48, 16);
            this.label183.TabIndex = 215;
            this.label183.Text = "Nivel:";
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.Brown;
            this.Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Cancelar.Location = new System.Drawing.Point(381, 208);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(94, 39);
            this.Cancelar.TabIndex = 4;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Guardar
            // 
            this.Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(92)))), ((int)(((byte)(77)))));
            this.Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Guardar.Location = new System.Drawing.Point(171, 208);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(153, 39);
            this.Guardar.TabIndex = 3;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = false;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel14.Controls.Add(this.label175);
            this.panel14.Location = new System.Drawing.Point(5, 5);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(670, 36);
            this.panel14.TabIndex = 205;
            // 
            // label175
            // 
            this.label175.AutoSize = true;
            this.label175.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label175.ForeColor = System.Drawing.Color.White;
            this.label175.Location = new System.Drawing.Point(258, 9);
            this.label175.Name = "label175";
            this.label175.Size = new System.Drawing.Size(153, 20);
            this.label175.TabIndex = 1;
            this.label175.Text = "Registrar Carrera:";
            // 
            // pictureBox150
            // 
            this.pictureBox150.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox150.Image")));
            this.pictureBox150.Location = new System.Drawing.Point(-17, 284);
            this.pictureBox150.Name = "pictureBox150";
            this.pictureBox150.Size = new System.Drawing.Size(10, 14);
            this.pictureBox150.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox150.TabIndex = 224;
            this.pictureBox150.TabStop = false;
            // 
            // ListaNivel
            // 
            this.ListaNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListaNivel.FormattingEnabled = true;
            this.ListaNivel.Items.AddRange(new object[] {
            "Licenciatura",
            "Técnico"});
            this.ListaNivel.Location = new System.Drawing.Point(381, 143);
            this.ListaNivel.Name = "ListaNivel";
            this.ListaNivel.Size = new System.Drawing.Size(219, 21);
            this.ListaNivel.TabIndex = 2;
            this.ListaNivel.SelectedIndexChanged += new System.EventHandler(this.ListaNivel_SelectedIndexChanged);
            this.ListaNivel.Validating += new System.ComponentModel.CancelEventHandler(this.ListaNivel_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // pictureBox144
            // 
            this.pictureBox144.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox144.Image")));
            this.pictureBox144.Location = new System.Drawing.Point(64, 145);
            this.pictureBox144.Name = "pictureBox144";
            this.pictureBox144.Size = new System.Drawing.Size(10, 14);
            this.pictureBox144.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox144.TabIndex = 228;
            this.pictureBox144.TabStop = false;
            // 
            // pictureBox145
            // 
            this.pictureBox145.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox145.Image")));
            this.pictureBox145.Location = new System.Drawing.Point(64, 97);
            this.pictureBox145.Name = "pictureBox145";
            this.pictureBox145.Size = new System.Drawing.Size(10, 14);
            this.pictureBox145.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox145.TabIndex = 227;
            this.pictureBox145.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel4.Location = new System.Drawing.Point(5, 41);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(4, 243);
            this.panel4.TabIndex = 1017;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel1.Location = new System.Drawing.Point(671, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(4, 243);
            this.panel1.TabIndex = 1018;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel2.Location = new System.Drawing.Point(8, 280);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(665, 4);
            this.panel2.TabIndex = 1019;
            // 
            // InsertCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(681, 290);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox144);
            this.Controls.Add(this.pictureBox145);
            this.Controls.Add(this.ListaNivel);
            this.Controls.Add(this.NombreCarrera);
            this.Controls.Add(this.label178);
            this.Controls.Add(this.pictureBox150);
            this.Controls.Add(this.NivelCampo);
            this.Controls.Add(this.label183);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.panel14);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InsertCarrera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox150)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox144)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox145)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NombreCarrera;
        private System.Windows.Forms.Label label178;
        private System.Windows.Forms.PictureBox pictureBox150;
        private System.Windows.Forms.TextBox NivelCampo;
        private System.Windows.Forms.Label label183;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label175;
        private System.Windows.Forms.ComboBox ListaNivel;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.PictureBox pictureBox144;
        private System.Windows.Forms.PictureBox pictureBox145;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}