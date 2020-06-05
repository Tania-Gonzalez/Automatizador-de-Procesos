using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoResidencias.ControlesUsuario.BuscarAlumno
{
    public partial class BusquedaDocumentos : UserControl
    {
        #region Variables
        private int ID_exp;
        private int? ID_doc, ID_req;
        private string CadenaConexion;
        #endregion

        public BusquedaDocumentos()
        {
            InitializeComponent();
        }
        public void SetValues(int a, string b)
        {
            ID_exp = a;
            CadenaConexion = b;
            Cargar();


        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea modificar expediente?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                using (var a = new EditDocumentos(ID_exp, CadenaConexion))
                {

                    a.ShowDialog();

                }
            }
        }

        public void Cargar()
        {
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {
                var datosexpediente = context.Expediente.ToList();
                foreach (var valores in datosexpediente.Where(n => n.ID_Expediente== ID_exp))
                {
                    ID_doc = valores.ID_Documentacion;
                    ID_req = valores.ID_Requisitos;
                }
                var datosdocumentos = context.Documentos.ToList();
                foreach (var valores in datosdocumentos.Where(n => n.ID_Documentos == ID_doc))
                {
                    CartaCompromisoForBA.Checked = valores.Carta_Compromiso;
                    EntrevistaBA.Checked = valores.Entrevista;
                    AnexoBA.Checked = valores.Anexo;
                    ReglamentoBA.Checked = valores.Reglamento;
                    FormatoRentaBA.Checked = valores.Hoja_Renta;
                    
                }
                var datosrequisitos = context.Requisitos.ToList();
                foreach (var valores in datosrequisitos.Where(n => n.ID_Requisitos == ID_req))
                {
                    CartaPresentacionBA.Checked = valores.Carta_Presentacion;
                    SeguroBA.Checked = valores.Carta_Seguro;
                    HistorialAcademinoBA.Checked = valores.Historial_Academico;
                    CartaCompromisoBA.Checked = valores.Carta_Compromiso;
                    CartillaBA.Checked = valores.Cartilla_Servicio;
                    ActaNacimientoBA.Checked = valores.Acta_Nacimiento;
                    CompDomicioBA.Checked = valores.Comprobante_Domicilio;
                    CurpDocBA.Checked = valores.Curp;
                    CredEscolarBA.Checked = valores.Credencial_Escolar;
                    CredElectorBA.Checked = valores.Credencial_Elector;
                    FotosBA.Checked = valores.Fotos;
                }


            }

        }
    }
}
