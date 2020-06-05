using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoResidencias
{
    public partial class NuevoRegistro : UserControl
    {
        #region Delegador

        public delegate void PasarBool(bool t);
        public delegate void Clickeado(object sender, EventArgs e);



        public event PasarBool Booleano;
        public event Clickeado Oprimido;


        #endregion
        #region Variables
        private string cadenaconexion;
        private bool datosdireccion, datostutor, datospersonales, datosescolares, datosarea
            ,datosasesor,datosdocumentos,datosprograma;

        private int ID_Tutor, ID_Direccion, ID_DatosPersonales, ID_DatosEscolares,
            ID_Departamento, ID_Puerta, ID_Asesor, ID_Jefe, ID_Area,ID_Expediente,
            ID_Programa;

        private List<string> ListaDireccion = new List<string>();
        private List<string> ListaDireccionRenta = new List<string>();
        private List<string> ListaTutor = new List<string>();
        private List<string> ListaDatosPersonales = new List<string>();
        private List<string> ListaDatosEscolares = new List<string>();
        private List<string> ListaArea = new List<string>();
        private List<bool> ListaRequisitos = new List<bool>();
        private List<bool> ListaDocumentos = new List<bool>();
        private List<string> ListaPrograma = new List<string>();

        private bool HojaRenta = false;



        #endregion

        #region Constructores

        public NuevoRegistro()
        {
            InitializeComponent();
            nuevoRegistroDireccion1.GuardarDireccion += NuevoRegistroDireccion1_GuardarDireccion;
            nuevoRegistroTutor1.GuardarTutor += NuevoRegistroTutor1_GuardarTutor;
            nuevoRegistroDatosPersonales1.GuardarDatosPersonales += NuevoRegistroDatosPersonales1_GuardarDatosPersonales;
            nuevoRegistroDatosEscolares1.GuardarDatosEscolares += NuevoRegistroDatosEscolares1_GuardarDatosEscolares;
            nuevoRegistroArea1.GuardarDatosArea += NuevoRegistroArea1_GuardarDatosArea;
            nuevoRegistroAsesorTecnico1.GuardarDatosAsesor += NuevoRegistroAsesorTecnico1_GuardarDatosAsesor;
            nuevoRegistroDocumentos1.GuardarDocumentos += NuevoRegistroDocumentos1_GuardarDocumentos;
            nuevoRegistroPrograma1.GuardarPrograma += NuevoRegistroPrograma1_GuardarPrograma;
        }

        private void NuevoRegistroPrograma1_GuardarPrograma(List<string> ListaPrograma)
        {
            this.ListaPrograma = ListaPrograma;
            btnProgramaNR.BackColor = Color.FromArgb(40, 92, 77);
            btnProgramaNR.ForeColor = Color.FromArgb(255, 255, 255);
            datosprograma = true;
            MessageBox.Show("Datos Guardados Correctamente");
        }

        private void NuevoRegistroDocumentos1_GuardarDocumentos(List<bool> ListaDocumentos, List<bool> ListaRequisitos)
        {
            this.ListaRequisitos = ListaRequisitos;
            this.ListaDocumentos = ListaDocumentos;
            btnDocumentosNR.BackColor = Color.FromArgb(70, 130, 180);
            btnDocumentosNR.ForeColor = Color.FromArgb(255, 255, 255);
            datosdocumentos = true;
            MessageBox.Show("Datos Guardados Correctamente");
        }

        private void NuevoRegistroAsesorTecnico1_GuardarDatosAsesor(int id_asesor, int id_jefe)
        {
            ID_Asesor = id_asesor;
            ID_Jefe = id_jefe;
            btnAsesorNR.BackColor = Color.FromArgb(70, 130, 180);
            btnAsesorNR.ForeColor = Color.FromArgb(255, 255, 255);
            datosasesor = true;
            MessageBox.Show("Datos Guardados Correctamente");

        }

        private void NuevoRegistroArea1_GuardarDatosArea(int id_dep, int id_puerta)
        {
            ID_Departamento = id_dep;
            ID_Puerta = id_puerta;
            btnAreaNR.BackColor = Color.FromArgb(70, 130, 180);
            btnAreaNR.ForeColor = Color.FromArgb(255, 255, 255);
            datosarea = true;
            MessageBox.Show("Datos Guardados Correctamente");
        }

        private void NuevoRegistroDatosEscolares1_GuardarDatosEscolares(List<string> a)
        {
            ListaDatosEscolares = a;
            btnDatosEscolaresNR.BackColor = Color.FromArgb(70, 130, 180);
            btnDatosEscolaresNR.ForeColor = Color.FromArgb(255, 255, 255);
            datosescolares = true;
            MessageBox.Show("Datos Guardados Correctamente");
        }

        private void NuevoRegistroDatosPersonales1_GuardarDatosPersonales(List<string> a)
        {
            ListaDatosPersonales = a;
            btnDatosPersonalesNR.BackColor = Color.FromArgb(70, 130, 180);
            btnDatosPersonalesNR.ForeColor = Color.FromArgb(255, 255, 255);
            datospersonales = true;
            MessageBox.Show("Datos Guardados Correctamente");
        }

        private void NuevoRegistroTutor1_GuardarTutor(List<string> a)
        { ListaTutor = a;
            btnTutorNR.BackColor = Color.FromArgb(70, 130, 180);
            btnTutorNR.ForeColor = Color.FromArgb(255, 255, 255);
            datostutor = true;
            MessageBox.Show("Datos Guardados Correctamente");
        }

        private void NuevoRegistroDireccion1_GuardarDireccion(List<string> a, List<string> b, bool c)
        {
            ListaDireccion = a;
            ListaDireccionRenta = b;
            HojaRenta = c;
            datosdireccion = true;
            btnDireccionNR.BackColor = Color.FromArgb(70, 130, 180);
            btnDireccionNR.ForeColor = Color.FromArgb(255, 255, 255);
            MessageBox.Show("Cambios Guardados Correctamente");


        }
        private void GuardarEstudiante()
        {
            using (var context = new Base_Servicio_PracticasEntities(cadenaconexion))
            {
                var a = new Estudiante()
                {
                    ID_Datos_Personales = this.ID_DatosPersonales,
                    ID_Datos_Escolares = this.ID_DatosEscolares,
                    ID_Area = this.ID_Area,
                    ID_Expediente = this.ID_Expediente,
                    ID_Programa = this.ID_Programa
                };
                context.Estudiante.Add(a);
                context.SaveChanges();


            }
        }


            private void GuardarPrograma()
        {
            int idav;
            using (var context = new Base_Servicio_PracticasEntities(cadenaconexion))
            {
                var a = new Avance()
                {
                    Nota = null,
                    Avance_General=0,
                    Peticion_folio_aceptacion=false,
                    Fecha_Peticion_Folio_Aceptacion=null,
                    Curso_De_Induccion=0,
                    Fecha_Curso_Induccion=null,
                    Peticion_Credencial=0,
                    Fecha_Peticion_Credencial=null,
                    Fecha_Llegada_Credencial=null,
                    Credencial=false,
                    ID_Credencial=null,
                    Peticion_Carta_Aceptacion=0,
                    Fecha_Peticion_Carta_Aceptacion=null,
                    Fecha_Llegada_Carta_Aceptacion=null,
                    Carta_Aceptacion=false,
                    Fecha_Carta_Aceptacion=null,
                    ID_Aceptacion=null,
                    Carta_Terminacion_Area=false,
                    Fecha_Carta_Terminacion_Area=null,
                    Peticion_Folio_Carta_Terminacion=false,
                    Fecha_Peticion_Folio_Carta_Terminacion=null,
                    Peticion_Carta_Terminacion=0,
                    Fecha_Peticion_Carta_Terminacion=null,
                    Fecha_Llegada_Carta_Terminacion=null,
                    Carta_Terminacion=false,
                    Fecha_Carta_Terminacion=null,
                    ID_Terminacion=null,
                    Estado=true,
                    Fecha_Baja=null,
                    Fecha_Credencial=null
                    
                };
                context.Avance.Add(a);
                context.SaveChanges();
                idav = a.ID_Avance;

            }
            using (var context = new Base_Servicio_PracticasEntities(cadenaconexion))
            {
                var a = new Programa()
                { 
                    Nombre_Programa=ListaPrograma[0],
                    Horas_Totales = Int32.Parse(ListaPrograma[1]),
                    Horas_Diarias = Int32.Parse(ListaPrograma[2]),
                    Hora_Inicio= ListaPrograma[3],
                    Hora_Termino=ListaPrograma[4],
                    Fecha_Inicio=DateTime.Parse(ListaPrograma[5]),
                    Fecha_Final= DateTime.Parse(ListaPrograma[6]),
                    Nombre_Proyecto=ListaPrograma[7],
                    Actividades=ListaPrograma[8],
                    ID_Avance = idav

                };
                context.Programa.Add(a);
                context.SaveChanges();
                ID_Programa = a.ID_Programa;


                }

            }

        private void GuardarExpediente()
        {
            int idd, idr;
            using (var context = new Base_Servicio_PracticasEntities(cadenaconexion))
            {
                var a = new Documentos()
                {
                    Entrevista = ListaDocumentos[0],
                    Carta_Compromiso = ListaDocumentos[1],
                    Anexo = ListaDocumentos[2],
                    Reglamento = ListaDocumentos[3],
                    Hoja_Renta = ListaDocumentos[4]
                };
                context.Documentos.Add(a);
                context.SaveChanges();
                idd = a.ID_Documentos;
            }
            using (var context = new Base_Servicio_PracticasEntities(cadenaconexion))
            {
                var a = new Requisitos()
                {
                    Carta_Presentacion = ListaRequisitos[0],
                    Carta_Seguro = ListaRequisitos[1],
                    Historial_Academico = ListaRequisitos[2],
                    Fotos = ListaRequisitos[3],
                    Comprobante_Domicilio = ListaRequisitos[4],
                    Acta_Nacimiento = ListaRequisitos[5],
                    Curp = ListaRequisitos[6],
                    Credencial_Escolar = ListaRequisitos[7],
                    Credencial_Elector = ListaRequisitos[8],
                    Carta_Compromiso = ListaRequisitos[9],
                    Cartilla_Servicio = ListaRequisitos[10],

                };
                context.Requisitos.Add(a);
                context.SaveChanges();
                idr = a.ID_Requisitos;
            }

            using (var context = new Base_Servicio_PracticasEntities(cadenaconexion))
            {
                var a = new Expediente()
                {
                    Etiqueta = false,
                    ID_Documentacion = idd,
                    ID_Requisitos = idr
                };
                context.Expediente.Add(a);
                context.SaveChanges();
                ID_Expediente = a.ID_Expediente;
            }
        }                

        private void GuardarDatosArea()
        {
            using (var context = new Base_Servicio_PracticasEntities(cadenaconexion))
            {
                var a = new Area()
                {
                    Ubicacion = null,
                    ID_Departamento = this.ID_Departamento,
                    ID_Puerta = this.ID_Puerta,
                    ID_Asesor=this.ID_Asesor,
                    ID_Jefe_Area=this.ID_Jefe
                };
                context.Area.Add(a);
                context.SaveChanges();
                ID_Area = a.ID_Area;
                }

        }
       

        private void GuardarDatosEscolares()
        {
            using (var context = new Base_Servicio_PracticasEntities(cadenaconexion))
            {
                var a = new Datos_Escolares()

                {
                    Semestre = ListaDatosEscolares[0],
                    Matricula = ListaDatosEscolares[1],
                    Promedio_General = decimal.Parse(ListaDatosEscolares[2]),
                    ID_Escuela = Int32.Parse(ListaDatosEscolares[3]),
                    ID_Persona_Enc= Int32.Parse(ListaDatosEscolares[4]),
                    ID_Carrera=Int32.Parse(ListaDatosEscolares[5])
                };
                context.Datos_Escolares.Add(a);
                context.SaveChanges();
                ID_DatosEscolares = a.ID_Datos_Escolares;
            }
        }

        private void GuardarDatosPersonales()
        {
            using (var context = new Base_Servicio_PracticasEntities(cadenaconexion))
            {
                var a = new Datos_Personales()
                {
                    Nombre1 = ListaDatosPersonales[0],
                    Nombre2 = ListaDatosPersonales[1],
                    Apellido_Paterno = ListaDatosPersonales[2],
                    Apellido_Materno = ListaDatosPersonales[3],
                    Sexo = ListaDatosPersonales[4],
                    Edad = byte.Parse(ListaDatosPersonales[5]),
                    Estado_Civil = ListaDatosPersonales[6],
                    Fecha_Nacimiento = DateTime.Parse(ListaDatosPersonales[7]),
                    Telefono_Fijo = ListaDatosPersonales[8],
                    Celular = ListaDatosPersonales[9],
                    Correo=ListaDatosPersonales[10],
                    Curp=ListaDatosPersonales[11],
                    ID_Referencia=ID_Tutor,
                    ID_Direccion=ID_Direccion
                };
                context.Datos_Personales.Add(a);
                context.SaveChanges();
                ID_DatosPersonales = a.ID_Datos_Personales;
            }
        }
        private void GuardarTutor()
        { 
            using (var context = new Base_Servicio_PracticasEntities(cadenaconexion))
            {
                var a = new Tutor()
                {
                    Nombre1_Tutor = ListaTutor[0],
                    Nombre2_Tutor = ListaTutor[1],
                    Ap_P_T = ListaTutor[2],
                    AP_M_T = ListaTutor[3],
                    TelefonoT = ListaTutor[4],
                    Nombre1_Ref = ListaTutor[5],
                    Nombre2_Ref = ListaTutor[6],
                    AP_P_R = ListaTutor[7],
                    AP_M_R = ListaTutor[8],
                    TelefonoR = ListaTutor[9]
                };
                context.Tutor.Add(a);
                context.SaveChanges();
                ID_Tutor = a.ID_Ref;
            }
        }
        public void GuardarDireccion()
        {
            if (HojaRenta == false)
            {

                using (var context = new Base_Servicio_PracticasEntities(cadenaconexion))
                {
                    var a = new Direccion()
                    {
                        Calle = ListaDireccion[0],
                        Numero_Interior = ListaDireccion[1],
                        Numero_Exterior = ListaDireccion[2],
                        Colonia = ListaDireccion[3],
                        Municipio = ListaDireccion[4],
                        Estado = ListaDireccion[5],
                        Pais = ListaDireccion[6],
                        Codigo_Postal = ListaDireccion[7],
                      


                    };
                    context.Direccion.Add(a);
                    context.SaveChanges();
                    ID_Direccion = a.ID_Direccion;
                }
            }
            else
            {
                int idr;
                using (var context = new Base_Servicio_PracticasEntities(cadenaconexion))
                {
                    var a = new DireccionRenta()
                    {
                        Calle = ListaDireccionRenta[0],
                        Numero_Interior = ListaDireccionRenta[1],
                        Colonia = ListaDireccionRenta[2],
                        Municipio = ListaDireccionRenta[3]
                    };
                    context.DireccionRenta.Add(a);
                    context.SaveChanges();
                    idr = a.ID_Renta;

                }
            

                using (var context = new Base_Servicio_PracticasEntities(cadenaconexion))
                {
                    var b = new Direccion()
                    {
                        Calle = ListaDireccion[0],
                        Numero_Interior = ListaDireccion[1],
                        Numero_Exterior = ListaDireccion[2],
                        Colonia = ListaDireccion[3],
                        Municipio = ListaDireccion[4],
                        Estado = ListaDireccion[5],
                        Pais = ListaDireccion[6],
                        Codigo_Postal = ListaDireccion[7],
                        ID_Direccion_Renta = idr


                    };
                    context.Direccion.Add(b);
                    context.SaveChanges();
                    ID_Direccion = b.ID_Direccion;
                }
            }
        } 
        


        public NuevoRegistro(string t)
        {
            cadenaconexion = t;

        }

        #endregion

        #region BotonesOpciones
     
        private void ColorBotones()
        {
           
        }
        private void BtnProgramaNR_Click(object sender, EventArgs e)
        {
          
            nuevoRegistroPrograma1.SetCadena(cadenaconexion);
            nuevoRegistroPrograma1.BringToFront();

        }

  

        private void BtnDatosPersonalesNR_Click(object sender, EventArgs e)
        {
          
            nuevoRegistroDatosPersonales1.BringToFront();
        }
        private void BtnDocumentosNR_Click(object sender, EventArgs e)
        {
          
            nuevoRegistroDocumentos1.BringToFront();


        }

        private void BtnDireccionNR_Click(object sender, EventArgs e)
        {
          
            nuevoRegistroDireccion1.BringToFront();
        }

        private void BtnTutorNR_Click(object sender, EventArgs e)
        {
          
            nuevoRegistroTutor1.BringToFront();
        }

        private void BtnDatosEscolaresNR_Click(object sender, EventArgs e)
        {
          
            nuevoRegistroDatosEscolares1.BringToFront();
            nuevoRegistroDatosEscolares1.SetCadena(cadenaconexion);
        }

        private void BtnAsesorNR_Click(object sender, EventArgs e)
        {
          
            nuevoRegistroAsesorTecnico1.BringToFront();
            nuevoRegistroAsesorTecnico1.SetCadena(cadenaconexion);
        }

        private void BtnAreaNR_Click(object sender, EventArgs e)
        {
          
            nuevoRegistroArea1.BringToFront();
            nuevoRegistroArea1.SetCadena(cadenaconexion);




        }
        #endregion

        #region MetodosApoyo
        public void Activar()
        {

          
        
            BtnTerminar.Visible = true;
            BtnCancelar.Visible = true;
            panelbotones.Visible = true;
            panelFijoNuevoRegistro.Visible = true;
            

        }
        public bool Validar()
        {
            if (datostutor == false || datosdireccion == false || datospersonales == false || datosescolares == false 
                || datosarea == false || datosasesor == false|| datosdocumentos==false||datosprograma==false)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public void Cancelar(object sender, CancelEventArgs e)
        {
            nuevoRegistroDatosPersonales1.Cancelar(sender, e);
            nuevoRegistroArea1.Cancelar(sender,e);
            nuevoRegistroAsesorTecnico1.Cancelar(sender,e);
            nuevoRegistroDatosEscolares1.Cancelar(sender,e);
            nuevoRegistroDireccion1.Cancelar(sender,e);
            nuevoRegistroPrograma1.Cancelar(sender, e);
            nuevoRegistroTutor1.Cancelar(sender,e);
        }
        public void Ocultar()
        {
            BtnTerminar.Visible = false;
            BtnCancelar.Visible = false;
            panelbotones.Visible = false;
            panelFijoNuevoRegistro.Visible = false;
            BtnNuevoRegistro.Visible = true;
        }

        public void LlenarDDL()
        {
            nuevoRegistroAsesorTecnico1.LlenarAsesores(cadenaconexion);            
            nuevoRegistroDatosEscolares1.LlenarDatosEscolares(cadenaconexion);
            nuevoRegistroArea1.LlenarArea(cadenaconexion);

        }

        public void Limpiar()
        {
            btnDatosPersonalesNR.ForeColor = Color.FromArgb(18,31,31);
            btnDatosPersonalesNR.BackColor = Color.FromArgb(211,211,211);

            btnDireccionNR.ForeColor = Color.FromArgb(18, 31, 31);
            btnDireccionNR.BackColor = Color.FromArgb(211, 211, 211);

            btnTutorNR.ForeColor = Color.FromArgb(18, 31, 31);
            btnTutorNR.BackColor = Color.FromArgb(211, 211, 211);

            btnDatosEscolaresNR.ForeColor = Color.FromArgb(18, 31, 31);
            btnDatosEscolaresNR.BackColor = Color.FromArgb(211, 211, 211);

            btnAreaNR.ForeColor = Color.FromArgb(18, 31, 31);
            btnAreaNR.BackColor = Color.FromArgb(211, 211, 211);

            btnAsesorNR.ForeColor = Color.FromArgb(18, 31, 31);
            btnAsesorNR.BackColor = Color.FromArgb(211, 211, 211);

            btnProgramaNR.ForeColor = Color.FromArgb(18, 31, 31);
            btnProgramaNR.BackColor = Color.FromArgb(211, 211, 211);

            btnDocumentosNR.ForeColor = Color.FromArgb(18, 31, 31);
            btnDocumentosNR.BackColor = Color.FromArgb(211, 211, 211);

            ListaDireccion.Clear();
            ListaDireccionRenta.Clear();
            ListaTutor.Clear();
            ListaDatosPersonales.Clear();
            ListaDatosEscolares.Clear();
            ListaArea.Clear();
            ListaRequisitos.Clear();
            ListaDocumentos.Clear();
            ListaPrograma.Clear();



            datosdireccion = false;
            datostutor = false;
            datospersonales = false;
            datosescolares = false;
            datosarea = false;
            datosasesor = false;
            datosdocumentos = false;
            datosprograma=false;


            nuevoRegistroArea1.Limpiar();
            nuevoRegistroAsesorTecnico1.Limpiar();
            nuevoRegistroDatosEscolares1.Limpiar();
            nuevoRegistroDatosPersonales1.Limpiar();
            nuevoRegistroDireccion1.Limpiar();
            nuevoRegistroDocumentos1.Limpiar();
            nuevoRegistroPrograma1.Limpiar();
            nuevoRegistroTutor1.Limpiar();

         

        }
        public void setCD(string t)
        {
            cadenaconexion = t;


        }

        

        #endregion

        #region BotonesRegistro
        private void BtnNuevoRegistro_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea Registrar Un Nuevo Estudiante?", "Nuevo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
        
              
                BtnNuevoRegistro.Visible = false;
                Oprimido.Invoke(sender,e);
                Booleano.Invoke(true);
                LlenarDDL();
                Limpiar();

                nuevoRegistroDatosPersonales1.BringToFront();
                Activar();

            }
            if (resultado == DialogResult.No)
            {

            }
                       
        }



     
     
       
        
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            
            DialogResult resultado = MessageBox.Show("¿Desea Cancelar El Registro?", "Nuevo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                var z = new CancelEventArgs();
                Ocultar();
                Cancelar(sender, z);
                Booleano.Invoke(false);
                Limpiar();
                
               
            }
            if (resultado == DialogResult.No)
            {

            }
        }

        private void BtnTerminar_Click(object sender, EventArgs e)
        {
            if (Validar()==true) {
                GuardarDireccion();
                GuardarTutor();
                GuardarDatosPersonales();
                GuardarDatosEscolares();
                GuardarDatosArea();
                GuardarExpediente();
                GuardarPrograma();
                GuardarEstudiante();

                Limpiar();
                MessageBox.Show("Estudiante registrado con éxito");
                nuevoRegistroDatosPersonales1.BringToFront();


            }
            else
            {
                MessageBox.Show("Faltan datos por llenar");
            }
        }


        #endregion
    }
}