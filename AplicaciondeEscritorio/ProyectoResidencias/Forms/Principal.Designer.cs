using System;
using System.Runtime.InteropServices;

namespace ProyectoResidencias
{
    partial class Principal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.BarraControl = new System.Windows.Forms.Panel();
            this.BotonMinimizar = new System.Windows.Forms.PictureBox();
            this.BotonCerrar = new System.Windows.Forms.PictureBox();
            this.PanelPrincipalIzquierdo = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnInicio = new System.Windows.Forms.Button();
            this.PanelOpcion1 = new System.Windows.Forms.Panel();
            this.Btn1_5 = new System.Windows.Forms.Button();
            this.Btn1_4 = new System.Windows.Forms.Button();
            this.Btn1_3 = new System.Windows.Forms.Button();
            this.Btn1_2 = new System.Windows.Forms.Button();
            this.Btn1_1 = new System.Windows.Forms.Button();
            this.BotonOpc1 = new System.Windows.Forms.Button();
            this.PanelOpcion2 = new System.Windows.Forms.Panel();
            this.Btn2_4 = new System.Windows.Forms.Button();
            this.Btn2_3 = new System.Windows.Forms.Button();
            this.Btn2_1 = new System.Windows.Forms.Button();
            this.BotonOpc2 = new System.Windows.Forms.Button();
            this.PanelOpcion3 = new System.Windows.Forms.Panel();
            this.Btn3_5 = new System.Windows.Forms.Button();
            this.Btn3_4 = new System.Windows.Forms.Button();
            this.Btn3_3 = new System.Windows.Forms.Button();
            this.Btn3_2 = new System.Windows.Forms.Button();
            this.Btn3_1_2 = new System.Windows.Forms.Button();
            this.Btn3_1 = new System.Windows.Forms.Button();
            this.BotonOpc3 = new System.Windows.Forms.Button();
            this.PanelOpcion4 = new System.Windows.Forms.Panel();
            this.Btn4_4 = new System.Windows.Forms.Button();
            this.Btn4_3 = new System.Windows.Forms.Button();
            this.Btn4_2 = new System.Windows.Forms.Button();
            this.Btn4_1 = new System.Windows.Forms.Button();
            this.BotonOpc4 = new System.Windows.Forms.Button();
            this.GenerarReporte = new System.Windows.Forms.Button();
            this.PanelSaludoCases = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TimerOpcion1 = new System.Windows.Forms.Timer(this.components);
            this.TimerOpcion2 = new System.Windows.Forms.Timer(this.components);
            this.TimerOpcion3 = new System.Windows.Forms.Timer(this.components);
            this.TimerOpcion4 = new System.Windows.Forms.Timer(this.components);
            this.TimerOpcion5 = new System.Windows.Forms.Timer(this.components);
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.bienvenida1 = new ProyectoResidencias.Bienvenida();
            this.calculadoraPeriodos1 = new ProyectoResidencias.CalculadoraPeriodos();
            this.consultasEstablecidas1 = new ProyectoResidencias.ConsultasEstablecidas();
            this.bajaPrincipal1 = new ProyectoResidencias.BajaPrincipal();
            this.busquedaPrincipal1 = new ProyectoResidencias.BusquedaPrincipal();
            this.nuevoRegistro1 = new ProyectoResidencias.NuevoRegistro();
            this.programarCurso1 = new ProyectoResidencias.ProgramarCurso();
            this.registrarAsistencia1 = new ProyectoResidencias.RegistrarAsistencia();
            this.registroEstadoDocumento1 = new ProyectoResidencias.RegistroEstadoDocumento();
            this.registroFolio1 = new ProyectoResidencias.RegistroFolio();
            this.registroProcesoPrincipal1 = new ProyectoResidencias.RegistroProcesoPrincipal();
            this.solicitarFolio1 = new ProyectoResidencias.SolicitarFolio();
            this.ucCartaAceptacion1 = new ProyectoResidencias.UCCartaAceptacion();
            this.ucCartaTerminacion1 = new ProyectoResidencias.UCCartaTerminacion();
            this.ucGeneradorCredenciales1 = new ProyectoResidencias.UCGeneradorCredenciales();
            this.ucGeneradorEtiquetas1 = new ProyectoResidencias.UCGeneradorEtiquetas();
            this.BarraControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BotonMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonCerrar)).BeginInit();
            this.PanelPrincipalIzquierdo.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.PanelOpcion1.SuspendLayout();
            this.PanelOpcion2.SuspendLayout();
            this.PanelOpcion3.SuspendLayout();
            this.PanelOpcion4.SuspendLayout();
            this.PanelSaludoCases.SuspendLayout();
            this.PanelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraControl
            // 
            this.BarraControl.BackColor = System.Drawing.Color.Black;
            this.BarraControl.Controls.Add(this.BotonMinimizar);
            this.BarraControl.Controls.Add(this.BotonCerrar);
            this.BarraControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraControl.Location = new System.Drawing.Point(0, 0);
            this.BarraControl.Name = "BarraControl";
            this.BarraControl.Size = new System.Drawing.Size(1200, 30);
            this.BarraControl.TabIndex = 0;
            this.BarraControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraControl_MouseMove);
            // 
            // BotonMinimizar
            // 
            this.BotonMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BotonMinimizar.Image = global::ProyectoResidencias.Properties.Resources.IconoMinimizarVentana3;
            this.BotonMinimizar.Location = new System.Drawing.Point(1130, 0);
            this.BotonMinimizar.Name = "BotonMinimizar";
            this.BotonMinimizar.Size = new System.Drawing.Size(35, 30);
            this.BotonMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BotonMinimizar.TabIndex = 1;
            this.BotonMinimizar.TabStop = false;
            this.BotonMinimizar.Click += new System.EventHandler(this.BotonMinimizar_Click);
            this.BotonMinimizar.MouseLeave += new System.EventHandler(this.BotonMinimizar_MouseLeave);
            this.BotonMinimizar.MouseHover += new System.EventHandler(this.BotonMinimizar_MouseHover);
            // 
            // BotonCerrar
            // 
            this.BotonCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BotonCerrar.Image = global::ProyectoResidencias.Properties.Resources.IconoCerrarVentana1;
            this.BotonCerrar.Location = new System.Drawing.Point(1165, 0);
            this.BotonCerrar.Name = "BotonCerrar";
            this.BotonCerrar.Size = new System.Drawing.Size(35, 30);
            this.BotonCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BotonCerrar.TabIndex = 0;
            this.BotonCerrar.TabStop = false;
            this.BotonCerrar.Click += new System.EventHandler(this.BotonCerrar_Click);
            this.BotonCerrar.MouseLeave += new System.EventHandler(this.BotonCerrar_MouseLeave);
            this.BotonCerrar.MouseHover += new System.EventHandler(this.BotonCerrar_MouseHover);
            // 
            // PanelPrincipalIzquierdo
            // 
            this.PanelPrincipalIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PanelPrincipalIzquierdo.Controls.Add(this.flowLayoutPanel1);
            this.PanelPrincipalIzquierdo.Controls.Add(this.PanelSaludoCases);
            this.PanelPrincipalIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelPrincipalIzquierdo.Location = new System.Drawing.Point(0, 30);
            this.PanelPrincipalIzquierdo.Name = "PanelPrincipalIzquierdo";
            this.PanelPrincipalIzquierdo.Size = new System.Drawing.Size(190, 695);
            this.PanelPrincipalIzquierdo.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.flowLayoutPanel1.Controls.Add(this.BtnInicio);
            this.flowLayoutPanel1.Controls.Add(this.PanelOpcion1);
            this.flowLayoutPanel1.Controls.Add(this.PanelOpcion2);
            this.flowLayoutPanel1.Controls.Add(this.PanelOpcion3);
            this.flowLayoutPanel1.Controls.Add(this.PanelOpcion4);
            this.flowLayoutPanel1.Controls.Add(this.GenerarReporte);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 140);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(184, 568);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // BtnInicio
            // 
            this.BtnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BtnInicio.FlatAppearance.BorderSize = 0;
            this.BtnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInicio.ForeColor = System.Drawing.Color.Silver;
            this.BtnInicio.Image = global::ProyectoResidencias.Properties.Resources.home2;
            this.BtnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnInicio.Location = new System.Drawing.Point(3, 3);
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.Size = new System.Drawing.Size(187, 53);
            this.BtnInicio.TabIndex = 6;
            this.BtnInicio.Text = "  Inicio";
            this.BtnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInicio.UseVisualStyleBackColor = false;
            this.BtnInicio.Click += new System.EventHandler(this.BtnInicio_Click);
            // 
            // PanelOpcion1
            // 
            this.PanelOpcion1.Controls.Add(this.Btn1_5);
            this.PanelOpcion1.Controls.Add(this.Btn1_4);
            this.PanelOpcion1.Controls.Add(this.Btn1_3);
            this.PanelOpcion1.Controls.Add(this.Btn1_2);
            this.PanelOpcion1.Controls.Add(this.Btn1_1);
            this.PanelOpcion1.Controls.Add(this.BotonOpc1);
            this.PanelOpcion1.Location = new System.Drawing.Point(3, 62);
            this.PanelOpcion1.MaximumSize = new System.Drawing.Size(187, 194);
            this.PanelOpcion1.MinimumSize = new System.Drawing.Size(187, 47);
            this.PanelOpcion1.Name = "PanelOpcion1";
            this.PanelOpcion1.Size = new System.Drawing.Size(187, 47);
            this.PanelOpcion1.TabIndex = 0;
            // 
            // Btn1_5
            // 
            this.Btn1_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn1_5.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn1_5.FlatAppearance.BorderSize = 0;
            this.Btn1_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1_5.ForeColor = System.Drawing.Color.Silver;
            this.Btn1_5.Image = ((System.Drawing.Image)(resources.GetObject("Btn1_5.Image")));
            this.Btn1_5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn1_5.Location = new System.Drawing.Point(0, 163);
            this.Btn1_5.Name = "Btn1_5";
            this.Btn1_5.Size = new System.Drawing.Size(187, 29);
            this.Btn1_5.TabIndex = 6;
            this.Btn1_5.Text = "      Bajas";
            this.Btn1_5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn1_5.UseVisualStyleBackColor = false;
            this.Btn1_5.Click += new System.EventHandler(this.Btn1_5_Click);
            // 
            // Btn1_4
            // 
            this.Btn1_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn1_4.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn1_4.FlatAppearance.BorderSize = 0;
            this.Btn1_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1_4.ForeColor = System.Drawing.Color.Silver;
            this.Btn1_4.Image = ((System.Drawing.Image)(resources.GetObject("Btn1_4.Image")));
            this.Btn1_4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn1_4.Location = new System.Drawing.Point(0, 134);
            this.Btn1_4.Name = "Btn1_4";
            this.Btn1_4.Size = new System.Drawing.Size(187, 29);
            this.Btn1_4.TabIndex = 4;
            this.Btn1_4.Text = "      Estados";
            this.Btn1_4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn1_4.UseVisualStyleBackColor = false;
            this.Btn1_4.Click += new System.EventHandler(this.Btn1_4_Click);
            // 
            // Btn1_3
            // 
            this.Btn1_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn1_3.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn1_3.FlatAppearance.BorderSize = 0;
            this.Btn1_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1_3.ForeColor = System.Drawing.Color.Silver;
            this.Btn1_3.Image = ((System.Drawing.Image)(resources.GetObject("Btn1_3.Image")));
            this.Btn1_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn1_3.Location = new System.Drawing.Point(0, 105);
            this.Btn1_3.Name = "Btn1_3";
            this.Btn1_3.Size = new System.Drawing.Size(187, 29);
            this.Btn1_3.TabIndex = 3;
            this.Btn1_3.Text = "      Folios";
            this.Btn1_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn1_3.UseVisualStyleBackColor = false;
            this.Btn1_3.Click += new System.EventHandler(this.Btn1_3_Click);
            // 
            // Btn1_2
            // 
            this.Btn1_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn1_2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn1_2.FlatAppearance.BorderSize = 0;
            this.Btn1_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1_2.ForeColor = System.Drawing.Color.Silver;
            this.Btn1_2.Image = ((System.Drawing.Image)(resources.GetObject("Btn1_2.Image")));
            this.Btn1_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn1_2.Location = new System.Drawing.Point(0, 76);
            this.Btn1_2.Name = "Btn1_2";
            this.Btn1_2.Size = new System.Drawing.Size(187, 29);
            this.Btn1_2.TabIndex = 2;
            this.Btn1_2.Text = "      Entregas";
            this.Btn1_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn1_2.UseVisualStyleBackColor = false;
            this.Btn1_2.Click += new System.EventHandler(this.Btn1_2_Click);
            // 
            // Btn1_1
            // 
            this.Btn1_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn1_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn1_1.FlatAppearance.BorderSize = 0;
            this.Btn1_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1_1.ForeColor = System.Drawing.Color.Silver;
            this.Btn1_1.Image = ((System.Drawing.Image)(resources.GetObject("Btn1_1.Image")));
            this.Btn1_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn1_1.Location = new System.Drawing.Point(0, 47);
            this.Btn1_1.Name = "Btn1_1";
            this.Btn1_1.Size = new System.Drawing.Size(187, 29);
            this.Btn1_1.TabIndex = 1;
            this.Btn1_1.Text = "      Nuevo Registro";
            this.Btn1_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn1_1.UseVisualStyleBackColor = false;
            this.Btn1_1.Click += new System.EventHandler(this.Btn1_1_Click);
            // 
            // BotonOpc1
            // 
            this.BotonOpc1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BotonOpc1.Dock = System.Windows.Forms.DockStyle.Top;
            this.BotonOpc1.FlatAppearance.BorderSize = 0;
            this.BotonOpc1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonOpc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonOpc1.ForeColor = System.Drawing.Color.Silver;
            this.BotonOpc1.Image = global::ProyectoResidencias.Properties.Resources.IconoAbajo;
            this.BotonOpc1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BotonOpc1.Location = new System.Drawing.Point(0, 0);
            this.BotonOpc1.Name = "BotonOpc1";
            this.BotonOpc1.Size = new System.Drawing.Size(187, 47);
            this.BotonOpc1.TabIndex = 5;
            this.BotonOpc1.Text = "  Registros";
            this.BotonOpc1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotonOpc1.UseVisualStyleBackColor = false;
            this.BotonOpc1.Click += new System.EventHandler(this.BotonOpc1_Click);
            // 
            // PanelOpcion2
            // 
            this.PanelOpcion2.Controls.Add(this.Btn2_4);
            this.PanelOpcion2.Controls.Add(this.Btn2_3);
            this.PanelOpcion2.Controls.Add(this.Btn2_1);
            this.PanelOpcion2.Controls.Add(this.BotonOpc2);
            this.PanelOpcion2.Location = new System.Drawing.Point(3, 115);
            this.PanelOpcion2.MaximumSize = new System.Drawing.Size(187, 130);
            this.PanelOpcion2.MinimumSize = new System.Drawing.Size(187, 47);
            this.PanelOpcion2.Name = "PanelOpcion2";
            this.PanelOpcion2.Size = new System.Drawing.Size(187, 129);
            this.PanelOpcion2.TabIndex = 5;
            // 
            // Btn2_4
            // 
            this.Btn2_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(69)))), ((int)(((byte)(49)))));
            this.Btn2_4.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn2_4.FlatAppearance.BorderSize = 0;
            this.Btn2_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn2_4.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2_4.ForeColor = System.Drawing.Color.White;
            this.Btn2_4.Image = global::ProyectoResidencias.Properties.Resources.iconopruebamenu;
            this.Btn2_4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn2_4.Location = new System.Drawing.Point(0, 129);
            this.Btn2_4.Name = "Btn2_4";
            this.Btn2_4.Size = new System.Drawing.Size(187, 29);
            this.Btn2_4.TabIndex = 4;
            this.Btn2_4.Text = "II.IV optionem";
            this.Btn2_4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn2_4.UseVisualStyleBackColor = false;
            // 
            // Btn2_3
            // 
            this.Btn2_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn2_3.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn2_3.FlatAppearance.BorderSize = 0;
            this.Btn2_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn2_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2_3.ForeColor = System.Drawing.Color.Silver;
            this.Btn2_3.Image = ((System.Drawing.Image)(resources.GetObject("Btn2_3.Image")));
            this.Btn2_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn2_3.Location = new System.Drawing.Point(0, 87);
            this.Btn2_3.Name = "Btn2_3";
            this.Btn2_3.Size = new System.Drawing.Size(187, 42);
            this.Btn2_3.TabIndex = 3;
            this.Btn2_3.Text = "       Consultar Proceso";
            this.Btn2_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn2_3.UseVisualStyleBackColor = false;
            this.Btn2_3.Click += new System.EventHandler(this.Btn2_3_Click);
            // 
            // Btn2_1
            // 
            this.Btn2_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn2_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn2_1.FlatAppearance.BorderSize = 0;
            this.Btn2_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn2_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2_1.ForeColor = System.Drawing.Color.Silver;
            this.Btn2_1.Image = ((System.Drawing.Image)(resources.GetObject("Btn2_1.Image")));
            this.Btn2_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn2_1.Location = new System.Drawing.Point(0, 47);
            this.Btn2_1.Name = "Btn2_1";
            this.Btn2_1.Size = new System.Drawing.Size(187, 40);
            this.Btn2_1.TabIndex = 1;
            this.Btn2_1.Text = "       Consultar Estudiante";
            this.Btn2_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn2_1.UseVisualStyleBackColor = false;
            this.Btn2_1.Click += new System.EventHandler(this.Btn2_1_Click);
            // 
            // BotonOpc2
            // 
            this.BotonOpc2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BotonOpc2.Dock = System.Windows.Forms.DockStyle.Top;
            this.BotonOpc2.FlatAppearance.BorderSize = 0;
            this.BotonOpc2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonOpc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonOpc2.ForeColor = System.Drawing.Color.Silver;
            this.BotonOpc2.Image = global::ProyectoResidencias.Properties.Resources.IconoAbajo;
            this.BotonOpc2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BotonOpc2.Location = new System.Drawing.Point(0, 0);
            this.BotonOpc2.Name = "BotonOpc2";
            this.BotonOpc2.Size = new System.Drawing.Size(187, 47);
            this.BotonOpc2.TabIndex = 0;
            this.BotonOpc2.Text = "  Consultas";
            this.BotonOpc2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotonOpc2.UseVisualStyleBackColor = false;
            this.BotonOpc2.Click += new System.EventHandler(this.BotonOpc2_Click);
            // 
            // PanelOpcion3
            // 
            this.PanelOpcion3.Controls.Add(this.Btn3_5);
            this.PanelOpcion3.Controls.Add(this.Btn3_4);
            this.PanelOpcion3.Controls.Add(this.Btn3_3);
            this.PanelOpcion3.Controls.Add(this.Btn3_2);
            this.PanelOpcion3.Controls.Add(this.Btn3_1_2);
            this.PanelOpcion3.Controls.Add(this.Btn3_1);
            this.PanelOpcion3.Controls.Add(this.BotonOpc3);
            this.PanelOpcion3.Location = new System.Drawing.Point(3, 250);
            this.PanelOpcion3.MaximumSize = new System.Drawing.Size(187, 221);
            this.PanelOpcion3.MinimumSize = new System.Drawing.Size(187, 47);
            this.PanelOpcion3.Name = "PanelOpcion3";
            this.PanelOpcion3.Size = new System.Drawing.Size(187, 47);
            this.PanelOpcion3.TabIndex = 6;
            // 
            // Btn3_5
            // 
            this.Btn3_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn3_5.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn3_5.FlatAppearance.BorderSize = 0;
            this.Btn3_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn3_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn3_5.ForeColor = System.Drawing.Color.Silver;
            this.Btn3_5.Image = ((System.Drawing.Image)(resources.GetObject("Btn3_5.Image")));
            this.Btn3_5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn3_5.Location = new System.Drawing.Point(0, 192);
            this.Btn3_5.Name = "Btn3_5";
            this.Btn3_5.Size = new System.Drawing.Size(187, 29);
            this.Btn3_5.TabIndex = 14;
            this.Btn3_5.Text = "       Solicitar Folios";
            this.Btn3_5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn3_5.UseVisualStyleBackColor = false;
            this.Btn3_5.Click += new System.EventHandler(this.Btn3_5_Click);
            // 
            // Btn3_4
            // 
            this.Btn3_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn3_4.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn3_4.FlatAppearance.BorderSize = 0;
            this.Btn3_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn3_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn3_4.ForeColor = System.Drawing.Color.Silver;
            this.Btn3_4.Image = ((System.Drawing.Image)(resources.GetObject("Btn3_4.Image")));
            this.Btn3_4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn3_4.Location = new System.Drawing.Point(0, 163);
            this.Btn3_4.Name = "Btn3_4";
            this.Btn3_4.Size = new System.Drawing.Size(187, 29);
            this.Btn3_4.TabIndex = 13;
            this.Btn3_4.Text = "       Generar Etiquetas";
            this.Btn3_4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn3_4.UseVisualStyleBackColor = false;
            this.Btn3_4.Click += new System.EventHandler(this.Btn3_4_Click);
            // 
            // Btn3_3
            // 
            this.Btn3_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn3_3.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn3_3.FlatAppearance.BorderSize = 0;
            this.Btn3_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn3_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn3_3.ForeColor = System.Drawing.Color.Silver;
            this.Btn3_3.Image = ((System.Drawing.Image)(resources.GetObject("Btn3_3.Image")));
            this.Btn3_3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn3_3.Location = new System.Drawing.Point(0, 134);
            this.Btn3_3.Name = "Btn3_3";
            this.Btn3_3.Size = new System.Drawing.Size(187, 29);
            this.Btn3_3.TabIndex = 12;
            this.Btn3_3.Text = "       Generar Credencial";
            this.Btn3_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn3_3.UseVisualStyleBackColor = false;
            this.Btn3_3.Click += new System.EventHandler(this.Btn3_3_Click);
            // 
            // Btn3_2
            // 
            this.Btn3_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn3_2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn3_2.FlatAppearance.BorderSize = 0;
            this.Btn3_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn3_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn3_2.ForeColor = System.Drawing.Color.Silver;
            this.Btn3_2.Image = ((System.Drawing.Image)(resources.GetObject("Btn3_2.Image")));
            this.Btn3_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn3_2.Location = new System.Drawing.Point(0, 105);
            this.Btn3_2.Name = "Btn3_2";
            this.Btn3_2.Size = new System.Drawing.Size(187, 29);
            this.Btn3_2.TabIndex = 11;
            this.Btn3_2.Text = "       Calcular Periodo";
            this.Btn3_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn3_2.UseVisualStyleBackColor = false;
            this.Btn3_2.Click += new System.EventHandler(this.Btn3_2_Click);
            // 
            // Btn3_1_2
            // 
            this.Btn3_1_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn3_1_2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn3_1_2.FlatAppearance.BorderSize = 0;
            this.Btn3_1_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn3_1_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn3_1_2.ForeColor = System.Drawing.Color.Silver;
            this.Btn3_1_2.Image = ((System.Drawing.Image)(resources.GetObject("Btn3_1_2.Image")));
            this.Btn3_1_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn3_1_2.Location = new System.Drawing.Point(0, 76);
            this.Btn3_1_2.Name = "Btn3_1_2";
            this.Btn3_1_2.Size = new System.Drawing.Size(187, 29);
            this.Btn3_1_2.TabIndex = 2;
            this.Btn3_1_2.Text = "       Carta Terminacion";
            this.Btn3_1_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn3_1_2.UseVisualStyleBackColor = false;
            this.Btn3_1_2.Click += new System.EventHandler(this.Btn3_1_2_Click);
            // 
            // Btn3_1
            // 
            this.Btn3_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn3_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn3_1.FlatAppearance.BorderSize = 0;
            this.Btn3_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn3_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn3_1.ForeColor = System.Drawing.Color.Silver;
            this.Btn3_1.Image = ((System.Drawing.Image)(resources.GetObject("Btn3_1.Image")));
            this.Btn3_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn3_1.Location = new System.Drawing.Point(0, 47);
            this.Btn3_1.Name = "Btn3_1";
            this.Btn3_1.Size = new System.Drawing.Size(187, 29);
            this.Btn3_1.TabIndex = 1;
            this.Btn3_1.Text = "       Carta Aceptacion";
            this.Btn3_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn3_1.UseVisualStyleBackColor = false;
            this.Btn3_1.Click += new System.EventHandler(this.Btn3_1_Click);
            // 
            // BotonOpc3
            // 
            this.BotonOpc3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BotonOpc3.Dock = System.Windows.Forms.DockStyle.Top;
            this.BotonOpc3.FlatAppearance.BorderSize = 0;
            this.BotonOpc3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonOpc3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonOpc3.ForeColor = System.Drawing.Color.Silver;
            this.BotonOpc3.Image = global::ProyectoResidencias.Properties.Resources.IconoAbajo;
            this.BotonOpc3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BotonOpc3.Location = new System.Drawing.Point(0, 0);
            this.BotonOpc3.Name = "BotonOpc3";
            this.BotonOpc3.Size = new System.Drawing.Size(187, 47);
            this.BotonOpc3.TabIndex = 0;
            this.BotonOpc3.Text = "  Generadores";
            this.BotonOpc3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotonOpc3.UseVisualStyleBackColor = false;
            this.BotonOpc3.Click += new System.EventHandler(this.BotonOpc3_Click);
            // 
            // PanelOpcion4
            // 
            this.PanelOpcion4.Controls.Add(this.Btn4_4);
            this.PanelOpcion4.Controls.Add(this.Btn4_3);
            this.PanelOpcion4.Controls.Add(this.Btn4_2);
            this.PanelOpcion4.Controls.Add(this.Btn4_1);
            this.PanelOpcion4.Controls.Add(this.BotonOpc4);
            this.PanelOpcion4.Location = new System.Drawing.Point(3, 303);
            this.PanelOpcion4.MaximumSize = new System.Drawing.Size(187, 105);
            this.PanelOpcion4.MinimumSize = new System.Drawing.Size(187, 47);
            this.PanelOpcion4.Name = "PanelOpcion4";
            this.PanelOpcion4.Size = new System.Drawing.Size(187, 47);
            this.PanelOpcion4.TabIndex = 7;
            // 
            // Btn4_4
            // 
            this.Btn4_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.Btn4_4.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn4_4.FlatAppearance.BorderSize = 0;
            this.Btn4_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn4_4.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn4_4.ForeColor = System.Drawing.Color.White;
            this.Btn4_4.Image = global::ProyectoResidencias.Properties.Resources.faq;
            this.Btn4_4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn4_4.Location = new System.Drawing.Point(0, 134);
            this.Btn4_4.Name = "Btn4_4";
            this.Btn4_4.Size = new System.Drawing.Size(187, 29);
            this.Btn4_4.TabIndex = 4;
            this.Btn4_4.Text = "FAQ";
            this.Btn4_4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn4_4.UseVisualStyleBackColor = false;
            // 
            // Btn4_3
            // 
            this.Btn4_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.Btn4_3.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn4_3.FlatAppearance.BorderSize = 0;
            this.Btn4_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn4_3.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn4_3.ForeColor = System.Drawing.Color.White;
            this.Btn4_3.Image = global::ProyectoResidencias.Properties.Resources.iconopruebamenu;
            this.Btn4_3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn4_3.Location = new System.Drawing.Point(0, 105);
            this.Btn4_3.Name = "Btn4_3";
            this.Btn4_3.Size = new System.Drawing.Size(187, 29);
            this.Btn4_3.TabIndex = 3;
            this.Btn4_3.Text = "IV.III optionem";
            this.Btn4_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn4_3.UseVisualStyleBackColor = false;
            // 
            // Btn4_2
            // 
            this.Btn4_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn4_2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn4_2.FlatAppearance.BorderSize = 0;
            this.Btn4_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn4_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn4_2.ForeColor = System.Drawing.Color.Silver;
            this.Btn4_2.Image = ((System.Drawing.Image)(resources.GetObject("Btn4_2.Image")));
            this.Btn4_2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn4_2.Location = new System.Drawing.Point(0, 76);
            this.Btn4_2.Name = "Btn4_2";
            this.Btn4_2.Size = new System.Drawing.Size(187, 29);
            this.Btn4_2.TabIndex = 2;
            this.Btn4_2.Text = "       Asistencia";
            this.Btn4_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn4_2.UseVisualStyleBackColor = false;
            this.Btn4_2.Click += new System.EventHandler(this.Btn4_2_Click);
            // 
            // Btn4_1
            // 
            this.Btn4_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn4_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn4_1.FlatAppearance.BorderSize = 0;
            this.Btn4_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn4_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn4_1.ForeColor = System.Drawing.Color.Silver;
            this.Btn4_1.Image = ((System.Drawing.Image)(resources.GetObject("Btn4_1.Image")));
            this.Btn4_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn4_1.Location = new System.Drawing.Point(0, 47);
            this.Btn4_1.Name = "Btn4_1";
            this.Btn4_1.Size = new System.Drawing.Size(187, 29);
            this.Btn4_1.TabIndex = 1;
            this.Btn4_1.Text = "       Programar Curso";
            this.Btn4_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn4_1.UseVisualStyleBackColor = false;
            this.Btn4_1.Click += new System.EventHandler(this.Btn4_1_Click);
            // 
            // BotonOpc4
            // 
            this.BotonOpc4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BotonOpc4.Dock = System.Windows.Forms.DockStyle.Top;
            this.BotonOpc4.FlatAppearance.BorderSize = 0;
            this.BotonOpc4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonOpc4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonOpc4.ForeColor = System.Drawing.Color.Silver;
            this.BotonOpc4.Image = global::ProyectoResidencias.Properties.Resources.IconoAbajo;
            this.BotonOpc4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BotonOpc4.Location = new System.Drawing.Point(0, 0);
            this.BotonOpc4.Name = "BotonOpc4";
            this.BotonOpc4.Size = new System.Drawing.Size(187, 47);
            this.BotonOpc4.TabIndex = 0;
            this.BotonOpc4.Text = "  Curso";
            this.BotonOpc4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotonOpc4.UseVisualStyleBackColor = false;
            this.BotonOpc4.Click += new System.EventHandler(this.BotonOpc4_Click);
            // 
            // GenerarReporte
            // 
            this.GenerarReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.GenerarReporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.GenerarReporte.FlatAppearance.BorderSize = 0;
            this.GenerarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerarReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerarReporte.ForeColor = System.Drawing.Color.Silver;
            this.GenerarReporte.Image = ((System.Drawing.Image)(resources.GetObject("GenerarReporte.Image")));
            this.GenerarReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GenerarReporte.Location = new System.Drawing.Point(3, 356);
            this.GenerarReporte.Name = "GenerarReporte";
            this.GenerarReporte.Size = new System.Drawing.Size(187, 47);
            this.GenerarReporte.TabIndex = 8;
            this.GenerarReporte.Text = "Generar Reporte";
            this.GenerarReporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GenerarReporte.UseVisualStyleBackColor = false;
            this.GenerarReporte.Click += new System.EventHandler(this.button1_Click);
            // 
            // PanelSaludoCases
            // 
            this.PanelSaludoCases.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(92)))), ((int)(((byte)(77)))));
            this.PanelSaludoCases.Controls.Add(this.label4);
            this.PanelSaludoCases.Controls.Add(this.label3);
            this.PanelSaludoCases.Controls.Add(this.label2);
            this.PanelSaludoCases.Controls.Add(this.label1);
            this.PanelSaludoCases.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSaludoCases.Location = new System.Drawing.Point(0, 0);
            this.PanelSaludoCases.Name = "PanelSaludoCases";
            this.PanelSaludoCases.Size = new System.Drawing.Size(190, 106);
            this.PanelSaludoCases.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(5, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Practicas Profesionales";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(86, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Servicio Social";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(58, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "C.A.S.E.S.";
            // 
            // TimerOpcion1
            // 
            this.TimerOpcion1.Enabled = true;
            this.TimerOpcion1.Interval = 10;
            this.TimerOpcion1.Tick += new System.EventHandler(this.TimerOpcion1_Tick);
            // 
            // TimerOpcion2
            // 
            this.TimerOpcion2.Enabled = true;
            this.TimerOpcion2.Interval = 10;
            this.TimerOpcion2.Tick += new System.EventHandler(this.TimerOpcion2_Tick);
            // 
            // TimerOpcion3
            // 
            this.TimerOpcion3.Enabled = true;
            this.TimerOpcion3.Interval = 10;
            this.TimerOpcion3.Tick += new System.EventHandler(this.TimerOpcion3_Tick);
            // 
            // TimerOpcion4
            // 
            this.TimerOpcion4.Enabled = true;
            this.TimerOpcion4.Interval = 10;
            this.TimerOpcion4.Tick += new System.EventHandler(this.TimerOpcion4_Tick);
            // 
            // TimerOpcion5
            // 
            this.TimerOpcion5.Enabled = true;
            this.TimerOpcion5.Interval = 10;
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.BackColor = System.Drawing.SystemColors.Control;
            this.PanelPrincipal.Controls.Add(this.bienvenida1);
            this.PanelPrincipal.Controls.Add(this.calculadoraPeriodos1);
            this.PanelPrincipal.Controls.Add(this.consultasEstablecidas1);
            this.PanelPrincipal.Controls.Add(this.bajaPrincipal1);
            this.PanelPrincipal.Controls.Add(this.busquedaPrincipal1);
            this.PanelPrincipal.Controls.Add(this.nuevoRegistro1);
            this.PanelPrincipal.Controls.Add(this.programarCurso1);
            this.PanelPrincipal.Controls.Add(this.registrarAsistencia1);
            this.PanelPrincipal.Controls.Add(this.registroEstadoDocumento1);
            this.PanelPrincipal.Controls.Add(this.registroFolio1);
            this.PanelPrincipal.Controls.Add(this.registroProcesoPrincipal1);
            this.PanelPrincipal.Controls.Add(this.solicitarFolio1);
            this.PanelPrincipal.Controls.Add(this.ucCartaAceptacion1);
            this.PanelPrincipal.Controls.Add(this.ucCartaTerminacion1);
            this.PanelPrincipal.Controls.Add(this.ucGeneradorCredenciales1);
            this.PanelPrincipal.Controls.Add(this.ucGeneradorEtiquetas1);
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(190, 30);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(1010, 695);
            this.PanelPrincipal.TabIndex = 2;
            // 
            // bienvenida1
            // 
            this.bienvenida1.Location = new System.Drawing.Point(0, 0);
            this.bienvenida1.Name = "bienvenida1";
            this.bienvenida1.Size = new System.Drawing.Size(1010, 699);
            this.bienvenida1.TabIndex = 15;
            // 
            // calculadoraPeriodos1
            // 
            this.calculadoraPeriodos1.BackColor = System.Drawing.SystemColors.Control;
            this.calculadoraPeriodos1.Location = new System.Drawing.Point(0, 0);
            this.calculadoraPeriodos1.Name = "calculadoraPeriodos1";
            this.calculadoraPeriodos1.Size = new System.Drawing.Size(1010, 699);
            this.calculadoraPeriodos1.TabIndex = 14;
            // 
            // consultasEstablecidas1
            // 
            this.consultasEstablecidas1.Location = new System.Drawing.Point(0, 0);
            this.consultasEstablecidas1.Name = "consultasEstablecidas1";
            this.consultasEstablecidas1.Size = new System.Drawing.Size(1010, 699);
            this.consultasEstablecidas1.TabIndex = 13;
            // 
            // bajaPrincipal1
            // 
            this.bajaPrincipal1.BackColor = System.Drawing.SystemColors.Control;
            this.bajaPrincipal1.Location = new System.Drawing.Point(0, 0);
            this.bajaPrincipal1.Name = "bajaPrincipal1";
            this.bajaPrincipal1.Size = new System.Drawing.Size(1010, 699);
            this.bajaPrincipal1.TabIndex = 12;
            // 
            // busquedaPrincipal1
            // 
            this.busquedaPrincipal1.BackColor = System.Drawing.SystemColors.Control;
            this.busquedaPrincipal1.Location = new System.Drawing.Point(0, 0);
            this.busquedaPrincipal1.Name = "busquedaPrincipal1";
            this.busquedaPrincipal1.Size = new System.Drawing.Size(1010, 699);
            this.busquedaPrincipal1.TabIndex = 11;
            // 
            // nuevoRegistro1
            // 
            this.nuevoRegistro1.Location = new System.Drawing.Point(0, 0);
            this.nuevoRegistro1.Name = "nuevoRegistro1";
            this.nuevoRegistro1.Size = new System.Drawing.Size(1010, 699);
            this.nuevoRegistro1.TabIndex = 10;
            // 
            // programarCurso1
            // 
            this.programarCurso1.Location = new System.Drawing.Point(0, 0);
            this.programarCurso1.Name = "programarCurso1";
            this.programarCurso1.Size = new System.Drawing.Size(1010, 699);
            this.programarCurso1.TabIndex = 9;
            // 
            // registrarAsistencia1
            // 
            this.registrarAsistencia1.Location = new System.Drawing.Point(0, 0);
            this.registrarAsistencia1.Name = "registrarAsistencia1";
            this.registrarAsistencia1.Size = new System.Drawing.Size(1010, 699);
            this.registrarAsistencia1.TabIndex = 8;
            // 
            // registroEstadoDocumento1
            // 
            this.registroEstadoDocumento1.Location = new System.Drawing.Point(0, 0);
            this.registroEstadoDocumento1.Name = "registroEstadoDocumento1";
            this.registroEstadoDocumento1.Size = new System.Drawing.Size(1010, 699);
            this.registroEstadoDocumento1.TabIndex = 7;
            // 
            // registroFolio1
            // 
            this.registroFolio1.Location = new System.Drawing.Point(0, 0);
            this.registroFolio1.Name = "registroFolio1";
            this.registroFolio1.Size = new System.Drawing.Size(1010, 699);
            this.registroFolio1.TabIndex = 6;
            // 
            // registroProcesoPrincipal1
            // 
            this.registroProcesoPrincipal1.Location = new System.Drawing.Point(0, 0);
            this.registroProcesoPrincipal1.Name = "registroProcesoPrincipal1";
            this.registroProcesoPrincipal1.Size = new System.Drawing.Size(1010, 699);
            this.registroProcesoPrincipal1.TabIndex = 5;
            // 
            // solicitarFolio1
            // 
            this.solicitarFolio1.Location = new System.Drawing.Point(0, 0);
            this.solicitarFolio1.Name = "solicitarFolio1";
            this.solicitarFolio1.Size = new System.Drawing.Size(1010, 699);
            this.solicitarFolio1.TabIndex = 4;
            // 
            // ucCartaAceptacion1
            // 
            this.ucCartaAceptacion1.Location = new System.Drawing.Point(0, 0);
            this.ucCartaAceptacion1.Name = "ucCartaAceptacion1";
            this.ucCartaAceptacion1.Size = new System.Drawing.Size(1010, 699);
            this.ucCartaAceptacion1.TabIndex = 3;
            // 
            // ucCartaTerminacion1
            // 
            this.ucCartaTerminacion1.Location = new System.Drawing.Point(0, 0);
            this.ucCartaTerminacion1.Name = "ucCartaTerminacion1";
            this.ucCartaTerminacion1.Size = new System.Drawing.Size(1010, 699);
            this.ucCartaTerminacion1.TabIndex = 2;
            // 
            // ucGeneradorCredenciales1
            // 
            this.ucGeneradorCredenciales1.Location = new System.Drawing.Point(0, 0);
            this.ucGeneradorCredenciales1.Name = "ucGeneradorCredenciales1";
            this.ucGeneradorCredenciales1.Size = new System.Drawing.Size(1010, 699);
            this.ucGeneradorCredenciales1.TabIndex = 1;
            // 
            // ucGeneradorEtiquetas1
            // 
            this.ucGeneradorEtiquetas1.Location = new System.Drawing.Point(0, 0);
            this.ucGeneradorEtiquetas1.Name = "ucGeneradorEtiquetas1";
            this.ucGeneradorEtiquetas1.Size = new System.Drawing.Size(1010, 699);
            this.ucGeneradorEtiquetas1.TabIndex = 0;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1200, 725);
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.PanelPrincipalIzquierdo);
            this.Controls.Add(this.BarraControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BarraControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BotonMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonCerrar)).EndInit();
            this.PanelPrincipalIzquierdo.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.PanelOpcion1.ResumeLayout(false);
            this.PanelOpcion2.ResumeLayout(false);
            this.PanelOpcion3.ResumeLayout(false);
            this.PanelOpcion4.ResumeLayout(false);
            this.PanelSaludoCases.ResumeLayout(false);
            this.PanelSaludoCases.PerformLayout();
            this.PanelPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraControl;
        private System.Windows.Forms.PictureBox BotonCerrar;
        private System.Windows.Forms.PictureBox BotonMinimizar;
        private System.Windows.Forms.Panel PanelPrincipalIzquierdo;
        private System.Windows.Forms.Panel PanelSaludoCases;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel PanelOpcion1;
        private System.Windows.Forms.Button Btn1_5;
        private System.Windows.Forms.Button Btn1_4;
        private System.Windows.Forms.Button Btn1_3;
        private System.Windows.Forms.Button Btn1_2;
        private System.Windows.Forms.Button Btn1_1;
        private System.Windows.Forms.Timer TimerOpcion1;
        private System.Windows.Forms.Timer TimerOpcion2;
        private System.Windows.Forms.Panel PanelOpcion3;
        private System.Windows.Forms.Button Btn3_1;
        private System.Windows.Forms.Button BotonOpc3;
        private System.Windows.Forms.Timer TimerOpcion3;
        private System.Windows.Forms.Panel PanelOpcion4;
        private System.Windows.Forms.Button Btn4_4;
        private System.Windows.Forms.Button Btn4_3;
        private System.Windows.Forms.Button Btn4_2;
        private System.Windows.Forms.Button Btn4_1;
        private System.Windows.Forms.Button BotonOpc4;
        private System.Windows.Forms.Timer TimerOpcion4;
        private System.Windows.Forms.Timer TimerOpcion5;
        private System.Windows.Forms.Button BotonOpc1;
        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.Button BtnInicio;
        private System.Windows.Forms.Button Btn3_1_2;
        private System.Windows.Forms.Button Btn3_3;
        private System.Windows.Forms.Button Btn3_2;
        private System.Windows.Forms.Button Btn3_4;
        private System.Windows.Forms.Button Btn3_5;
        private UCGeneradorEtiquetas ucGeneradorEtiquetas1;
        private BusquedaPrincipal busquedaPrincipal1;
        private NuevoRegistro nuevoRegistro1;
        private ProgramarCurso programarCurso1;
        private RegistrarAsistencia registrarAsistencia1;
        private RegistroEstadoDocumento registroEstadoDocumento1;
        private RegistroFolio registroFolio1;
        private RegistroProcesoPrincipal registroProcesoPrincipal1;
        private SolicitarFolio solicitarFolio1;
        private UCCartaAceptacion ucCartaAceptacion1;
        private UCCartaTerminacion ucCartaTerminacion1;
        private UCGeneradorCredenciales ucGeneradorCredenciales1;
        private BajaPrincipal bajaPrincipal1;
        private Bienvenida bienvenida1;
        private CalculadoraPeriodos calculadoraPeriodos1;
        private ConsultasEstablecidas consultasEstablecidas1;
        private System.Windows.Forms.Panel PanelOpcion2;
        private System.Windows.Forms.Button Btn2_4;
        private System.Windows.Forms.Button Btn2_3;
        private System.Windows.Forms.Button Btn2_1;
        private System.Windows.Forms.Button BotonOpc2;
        private System.Windows.Forms.Button GenerarReporte;

        /*
        private ProyectoResidencias.Bienvenida bienvenida1;
        private ProyectoResidencias.NuevoRegistro nuevoRegistro1;
        private BusquedaPrincipal busquedaPrincipal1;
        private RegistroProcesoPrincipal registroProcesoPrincipal1;
        private RegistroFolio registroFolio1;
        private ProyectoResidencias.BajaPrincipal bajaPrincipal1;
        private RegistroEstadoDocumento registroEstadoDocumento1;
        private ProyectoResidencias.CalculadoraPeriodos calculadoraPeriodos1;
        private ProyectoResidencias.SolicitarFolio solicitarFolio1;
        private ProyectoResidencias.ProgramarCurso programarCurso1;
        private ProyectoResidencias.RegistrarAsistencia registrarAsistencia1;
        private CartaAceptacion cartaAceptacion1;
        private UCCartaAceptacion ucCartaAceptacion1;
        private UCCartaTerminacion ucCartaTerminacion1;
        private UCGeneradorEtiquetas ucGeneradorEtiquetas1;
        private UCGeneradorCredenciales ucGeneradorCredenciales1;
        private ConsultasEstablecidas consultasEstablecidas1;
        */
    }
    
}

