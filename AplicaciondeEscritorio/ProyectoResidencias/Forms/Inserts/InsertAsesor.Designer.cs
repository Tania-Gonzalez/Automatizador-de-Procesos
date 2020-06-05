namespace ProyectoResidencias
{
    partial class InsertAsesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertAsesor));
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.ExtensionNR = new System.Windows.Forms.TextBox();
            this.label170 = new System.Windows.Forms.Label();
            this.FichaAsesorNR = new System.Windows.Forms.TextBox();
            this.label171 = new System.Windows.Forms.Label();
            this.CargoAsesorNR = new System.Windows.Forms.TextBox();
            this.label172 = new System.Windows.Forms.Label();
            this.ApeAsesor2NR = new System.Windows.Forms.TextBox();
            this.ApeAsesorNR = new System.Windows.Forms.TextBox();
            this.NomAsesor2NR = new System.Windows.Forms.TextBox();
            this.NomAsesorNR = new System.Windows.Forms.TextBox();
            this.label173 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label175 = new System.Windows.Forms.Label();
            this.Guardar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.pictureBox143 = new System.Windows.Forms.PictureBox();
            this.pictureBox144 = new System.Windows.Forms.PictureBox();
            this.pictureBox145 = new System.Windows.Forms.PictureBox();
            this.pictureBox146 = new System.Windows.Forms.PictureBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox143)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox144)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox145)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox146)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DimGray;
            this.label17.Location = new System.Drawing.Point(723, 93);
            this.label17.Name = "label17";
            this.label17.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label17.Size = new System.Drawing.Size(132, 16);
            this.label17.TabIndex = 159;
            this.label17.Text = "Segundo Apellido";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.DimGray;
            this.label18.Location = new System.Drawing.Point(565, 93);
            this.label18.Name = "label18";
            this.label18.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label18.Size = new System.Drawing.Size(115, 16);
            this.label18.TabIndex = 158;
            this.label18.Text = "Primer Apellido";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.DimGray;
            this.label19.Location = new System.Drawing.Point(405, 93);
            this.label19.Name = "label19";
            this.label19.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label19.Size = new System.Drawing.Size(129, 16);
            this.label19.TabIndex = 157;
            this.label19.Text = "Segundo Nombre";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.DimGray;
            this.label20.Location = new System.Drawing.Point(254, 93);
            this.label20.Name = "label20";
            this.label20.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label20.Size = new System.Drawing.Size(112, 16);
            this.label20.TabIndex = 156;
            this.label20.Text = "Primer Nombre";
            // 
            // ExtensionNR
            // 
            this.ExtensionNR.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ExtensionNR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtensionNR.Location = new System.Drawing.Point(240, 190);
            this.ExtensionNR.MaxLength = 10;
            this.ExtensionNR.Name = "ExtensionNR";
            this.ExtensionNR.Size = new System.Drawing.Size(139, 22);
            this.ExtensionNR.TabIndex = 7;
            this.ExtensionNR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            this.ExtensionNR.Validating += new System.ComponentModel.CancelEventHandler(this.ExtensionNR_Validating);
            // 
            // label170
            // 
            this.label170.AutoSize = true;
            this.label170.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label170.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(92)))), ((int)(((byte)(77)))));
            this.label170.Location = new System.Drawing.Point(145, 193);
            this.label170.Name = "label170";
            this.label170.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label170.Size = new System.Drawing.Size(79, 16);
            this.label170.TabIndex = 154;
            this.label170.Text = "Extensión:";
            // 
            // FichaAsesorNR
            // 
            this.FichaAsesorNR.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.FichaAsesorNR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.FichaAsesorNR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FichaAsesorNR.Location = new System.Drawing.Point(240, 154);
            this.FichaAsesorNR.MaxLength = 20;
            this.FichaAsesorNR.Name = "FichaAsesorNR";
            this.FichaAsesorNR.Size = new System.Drawing.Size(139, 22);
            this.FichaAsesorNR.TabIndex = 5;
            this.FichaAsesorNR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // label171
            // 
            this.label171.AutoSize = true;
            this.label171.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label171.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(92)))), ((int)(((byte)(77)))));
            this.label171.Location = new System.Drawing.Point(145, 153);
            this.label171.Name = "label171";
            this.label171.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label171.Size = new System.Drawing.Size(50, 16);
            this.label171.TabIndex = 152;
            this.label171.Text = "Ficha:";
            // 
            // CargoAsesorNR
            // 
            this.CargoAsesorNR.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CargoAsesorNR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CargoAsesorNR.Location = new System.Drawing.Point(491, 154);
            this.CargoAsesorNR.MaxLength = 100;
            this.CargoAsesorNR.Name = "CargoAsesorNR";
            this.CargoAsesorNR.Size = new System.Drawing.Size(364, 22);
            this.CargoAsesorNR.TabIndex = 6;
            this.CargoAsesorNR.Leave += new System.EventHandler(this.CargoAsesorNR_Leave);
            this.CargoAsesorNR.Validating += new System.ComponentModel.CancelEventHandler(this.CargoAsesorNR_Validating);
            // 
            // label172
            // 
            this.label172.AutoSize = true;
            this.label172.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label172.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(92)))), ((int)(((byte)(77)))));
            this.label172.Location = new System.Drawing.Point(421, 155);
            this.label172.Name = "label172";
            this.label172.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label172.Size = new System.Drawing.Size(54, 16);
            this.label172.TabIndex = 150;
            this.label172.Text = "Cargo:";
            // 
            // ApeAsesor2NR
            // 
            this.ApeAsesor2NR.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ApeAsesor2NR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApeAsesor2NR.Location = new System.Drawing.Point(720, 111);
            this.ApeAsesor2NR.MaxLength = 50;
            this.ApeAsesor2NR.Name = "ApeAsesor2NR";
            this.ApeAsesor2NR.Size = new System.Drawing.Size(139, 22);
            this.ApeAsesor2NR.TabIndex = 4;
            this.ApeAsesor2NR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloLetras);
            this.ApeAsesor2NR.Leave += new System.EventHandler(this.ApeAsesor2NR_Leave);
            // 
            // ApeAsesorNR
            // 
            this.ApeAsesorNR.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ApeAsesorNR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApeAsesorNR.Location = new System.Drawing.Point(554, 111);
            this.ApeAsesorNR.MaxLength = 50;
            this.ApeAsesorNR.Name = "ApeAsesorNR";
            this.ApeAsesorNR.Size = new System.Drawing.Size(139, 22);
            this.ApeAsesorNR.TabIndex = 3;
            this.ApeAsesorNR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloLetras);
            this.ApeAsesorNR.Leave += new System.EventHandler(this.ApeAsesorNR_Leave);
            this.ApeAsesorNR.Validating += new System.ComponentModel.CancelEventHandler(this.ApeAsesorNR_Validating);
            // 
            // NomAsesor2NR
            // 
            this.NomAsesor2NR.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.NomAsesor2NR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomAsesor2NR.Location = new System.Drawing.Point(400, 111);
            this.NomAsesor2NR.MaxLength = 50;
            this.NomAsesor2NR.Name = "NomAsesor2NR";
            this.NomAsesor2NR.Size = new System.Drawing.Size(139, 22);
            this.NomAsesor2NR.TabIndex = 2;
            this.NomAsesor2NR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloLetras);
            this.NomAsesor2NR.Leave += new System.EventHandler(this.NomAsesor2NR_Leave);
            // 
            // NomAsesorNR
            // 
            this.NomAsesorNR.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.NomAsesorNR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomAsesorNR.Location = new System.Drawing.Point(240, 111);
            this.NomAsesorNR.MaxLength = 50;
            this.NomAsesorNR.Name = "NomAsesorNR";
            this.NomAsesorNR.Size = new System.Drawing.Size(139, 22);
            this.NomAsesorNR.TabIndex = 1;
            this.NomAsesorNR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloLetras);
            this.NomAsesorNR.Leave += new System.EventHandler(this.NomAsesorNR_Leave);
            this.NomAsesorNR.Validating += new System.ComponentModel.CancelEventHandler(this.NomAsesorNR_Validating);
            // 
            // label173
            // 
            this.label173.AutoSize = true;
            this.label173.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label173.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(92)))), ((int)(((byte)(77)))));
            this.label173.Location = new System.Drawing.Point(144, 114);
            this.label173.Name = "label173";
            this.label173.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label173.Size = new System.Drawing.Size(67, 16);
            this.label173.TabIndex = 148;
            this.label173.Text = "Nombre:";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel14.Controls.Add(this.label175);
            this.panel14.Location = new System.Drawing.Point(5, 5);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(981, 36);
            this.panel14.TabIndex = 160;
            // 
            // label175
            // 
            this.label175.AutoSize = true;
            this.label175.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label175.ForeColor = System.Drawing.Color.Gainsboro;
            this.label175.Location = new System.Drawing.Point(385, 6);
            this.label175.Name = "label175";
            this.label175.Size = new System.Drawing.Size(216, 20);
            this.label175.TabIndex = 1;
            this.label175.Text = "Registrar Asesor Técnico:";
            // 
            // Guardar
            // 
            this.Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(92)))), ((int)(((byte)(77)))));
            this.Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Guardar.Location = new System.Drawing.Point(262, 265);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(149, 44);
            this.Guardar.TabIndex = 8;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = false;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.Brown;
            this.Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Cancelar.Location = new System.Drawing.Point(566, 265);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(149, 44);
            this.Cancelar.TabIndex = 9;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // pictureBox143
            // 
            this.pictureBox143.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox143.Image")));
            this.pictureBox143.Location = new System.Drawing.Point(129, 193);
            this.pictureBox143.Name = "pictureBox143";
            this.pictureBox143.Size = new System.Drawing.Size(10, 14);
            this.pictureBox143.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox143.TabIndex = 155;
            this.pictureBox143.TabStop = false;
            // 
            // pictureBox144
            // 
            this.pictureBox144.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox144.Image")));
            this.pictureBox144.Location = new System.Drawing.Point(129, 154);
            this.pictureBox144.Name = "pictureBox144";
            this.pictureBox144.Size = new System.Drawing.Size(10, 14);
            this.pictureBox144.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox144.TabIndex = 153;
            this.pictureBox144.TabStop = false;
            // 
            // pictureBox145
            // 
            this.pictureBox145.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox145.Image")));
            this.pictureBox145.Location = new System.Drawing.Point(129, 113);
            this.pictureBox145.Name = "pictureBox145";
            this.pictureBox145.Size = new System.Drawing.Size(10, 14);
            this.pictureBox145.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox145.TabIndex = 151;
            this.pictureBox145.TabStop = false;
            // 
            // pictureBox146
            // 
            this.pictureBox146.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox146.Image")));
            this.pictureBox146.Location = new System.Drawing.Point(-16, 110);
            this.pictureBox146.Name = "pictureBox146";
            this.pictureBox146.Size = new System.Drawing.Size(10, 14);
            this.pictureBox146.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox146.TabIndex = 149;
            this.pictureBox146.TabStop = false;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel3.Location = new System.Drawing.Point(5, 350);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(980, 4);
            this.panel3.TabIndex = 1022;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel1.Location = new System.Drawing.Point(982, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(4, 317);
            this.panel1.TabIndex = 1021;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel4.Location = new System.Drawing.Point(5, 37);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(4, 317);
            this.panel4.TabIndex = 1020;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(405, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 14);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1023;
            this.pictureBox1.TabStop = false;
            // 
            // InsertAsesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(990, 360);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.ExtensionNR);
            this.Controls.Add(this.pictureBox143);
            this.Controls.Add(this.label170);
            this.Controls.Add(this.FichaAsesorNR);
            this.Controls.Add(this.pictureBox144);
            this.Controls.Add(this.label171);
            this.Controls.Add(this.CargoAsesorNR);
            this.Controls.Add(this.pictureBox145);
            this.Controls.Add(this.label172);
            this.Controls.Add(this.ApeAsesor2NR);
            this.Controls.Add(this.ApeAsesorNR);
            this.Controls.Add(this.NomAsesor2NR);
            this.Controls.Add(this.NomAsesorNR);
            this.Controls.Add(this.pictureBox146);
            this.Controls.Add(this.label173);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InsertAsesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox143)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox144)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox145)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox146)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox ExtensionNR;
        private System.Windows.Forms.PictureBox pictureBox143;
        private System.Windows.Forms.Label label170;
        private System.Windows.Forms.TextBox FichaAsesorNR;
        private System.Windows.Forms.PictureBox pictureBox144;
        private System.Windows.Forms.Label label171;
        private System.Windows.Forms.TextBox CargoAsesorNR;
        private System.Windows.Forms.PictureBox pictureBox145;
        private System.Windows.Forms.Label label172;
        private System.Windows.Forms.TextBox ApeAsesor2NR;
        private System.Windows.Forms.TextBox ApeAsesorNR;
        private System.Windows.Forms.TextBox NomAsesor2NR;
        private System.Windows.Forms.TextBox NomAsesorNR;
        private System.Windows.Forms.PictureBox pictureBox146;
        private System.Windows.Forms.Label label173;
        private System.Windows.Forms.Label label175;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
    }
}