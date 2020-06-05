using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoResidencias
{
    public partial class BusquedaAlumno : Form
    {
        #region Variables
        private string cadenaconexion;
        private int ide, ID_datospersonales, ID_datosescolares, ID_area, ID_expediente, ID_programa;

        private void BtnTutor_Click(object sender, EventArgs e)
        {
            busquedaTutor1.BringToFront();
        }

        private void BtnPrograma_Click(object sender, EventArgs e)
        {
            busquedaPrograma1.BringToFront();
        }

        private void BtnDireccion_Click(object sender, EventArgs e)
        {
            busquedaDireccion1.BringToFront();
        }

        private void BtnAsesor_Click(object sender, EventArgs e)
        {
            busquedaAsesorTecnico1.BringToFront();
        }

        private void BtnArea_Click(object sender, EventArgs e)
        {
            busquedaArea1.BringToFront();
        }

        private void BtnDocumentos_Click(object sender, EventArgs e)
        {
            busquedaDocumentos1.BringToFront();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

 

        private void BtnDatosEscolares_Click(object sender, EventArgs e)
        {
            busquedaDatosEscolares1.BringToFront();
        }

        private void BtnDatosPersonales_Click(object sender, EventArgs e)
        {
            busquedaDatosPersonales1.BringToFront();
        }

        private List<CargarBusqueda> datoscarga = new List<CargarBusqueda>();
        #endregion

        public BusquedaAlumno(string a,int b)
        {
            InitializeComponent();
            cadenaconexion = a;
            ide = b;
            llenardatos();
        }

        private void llenardatos()
        {
            using (var context = new Base_Servicio_PracticasEntities(cadenaconexion))
            {
                var listabusqueda = (from e in context.Estudiante
                                     join pg in context.Programa on e.ID_Programa equals pg.ID_Programa
                                     join av in context.Avance on pg.ID_Programa equals av.ID_Avance
                                     join dp in context.Datos_Personales on e.ID_Datos_Personales equals dp.ID_Datos_Personales
                                     join de in context.Datos_Escolares on e.ID_Datos_Escolares equals de.ID_Datos_Escolares
                                     join esc in context.Escuela on de.ID_Escuela equals esc.ID_Escuela
                                     join car in context.Carrera on de.ID_Escuela equals car.ID_Carrera
                                     select new CargarBusqueda
                                     {
                                         ID=e.ID_Estudiante,
                                         ID_Area=e.ID_Area,
                                         ID_DatosEscolares=e.ID_Datos_Escolares,
                                         ID_DatosPersonales=e.ID_Datos_Personales,
                                         ID_Expediente=e.ID_Expediente,
                                         ID_Programa=e.ID_Programa,

                                         Folio =av.ID_Aceptacion,
                                         TipoPrograma=pg.Nombre_Programa,
                                         NombreCompleto=dp.Nombre1+" "+dp.Nombre2+" "+dp.Apellido_Paterno+" "+dp.Apellido_Materno,
                                         NombreCarrera=car.Nombre_Carrera,
                                         Escuela = esc.Nombre_Escuela,
                                         Matricula =de.Matricula,
                                         Curso=av.Curso_De_Induccion.ToString()


                                     }).AsQueryable();
                listabusqueda = listabusqueda.Where(i => i.ID==ide);

                var a = listabusqueda.ToList();
                foreach (var valores in a)
                {
                    this.ID_area = valores.ID_Area.GetValueOrDefault();
                    this.ID_datosescolares = valores.ID_DatosEscolares.GetValueOrDefault();
                    this.ID_datospersonales = valores.ID_DatosPersonales.GetValueOrDefault();
                    this.ID_expediente = valores.ID_Expediente.GetValueOrDefault();
                    this.ID_programa = valores.ID_Programa.GetValueOrDefault();


                    labelID.Text = valores.Folio.ToString();
                    PractoServBA.Text = valores.TipoPrograma;
                    NombreEstudianteBA.Text = valores.NombreCompleto;
                    NombreEscuelaBA.Text = valores.Escuela;
                    NombreCarreraBA.Text = valores.NombreCarrera;
                    NombreMatriculaBA.Text = valores.Matricula;
                    EstadoCursoBA.Text = valores.Curso;

                }
            }

            using (var context = new Base_Servicio_PracticasEntities(cadenaconexion))
            {
                var listabusqueda = (from e in context.Estudiante
                                     join pg in context.Programa on e.ID_Programa equals pg.ID_Programa
                                     join av in context.Avance on pg.ID_Programa equals av.ID_Avance
                                     where (e.ID_Estudiante == ide)
                                     select new CargarDatosProceso
                                     {
                                         Credencial = av.Credencial.ToString(),
                                         Curso = av.Curso_De_Induccion.ToString(),
                                         SolAcept = av.Carta_Aceptacion.ToString(),
                                         TerminacionArea = av.Carta_Terminacion_Area.ToString(),
                                         SolTermn = av.Carta_Terminacion.ToString(),
                                         Reportes = (from r in context.Reportes where (r.ID_Avance == av.ID_Avance) select r.ID_Reportes).Count().ToString(),
                                     }).AsQueryable().ToList();
                foreach (var item in listabusqueda)
                {
                    EstadoAceptacion.Text = item.SolAcept;
                    EstadoCredencial.Text = item.Credencial;
                    EsadoTerminacion.Text = item.TerminacionArea;
                    EstadoCurso.Text = item.Curso;
                    EstadoReortes.Text = item.Reportes;
                    EstadoTermArea.Text = item.TerminacionArea;
                }
            }

            busquedaDatosPersonales1.SetValues(ID_datospersonales,cadenaconexion);
            busquedaDatosEscolares1.SetValues(ID_datosescolares,cadenaconexion);
            busquedaTutor1.SetValues(ID_datospersonales,cadenaconexion);
            busquedaPrograma1.SetValues(ID_programa, cadenaconexion);
            busquedaDireccion1.SetValues(ID_datospersonales,cadenaconexion,ID_expediente);
            busquedaAsesorTecnico1.SetValues(ID_area,cadenaconexion);
            busquedaArea1.SetValues(ID_area, cadenaconexion);
            busquedaDocumentos1.SetValues(ID_expediente,cadenaconexion);

        }



    }
}
