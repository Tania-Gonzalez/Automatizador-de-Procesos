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
    public partial class EditDocumentos : Form
    {
        #region Variables
        private int ID_Exp;
        private int? ID_Doc, ID_Req;
        private string CadenaConexion;
        List<bool> ListaDocumentos = new List<bool>();
        List<bool> ListaRequisitos = new List<bool>();

        #endregion
        public EditDocumentos(int a, string b)
        {
            InitializeComponent();
            this.ID_Exp = a;
            this.CadenaConexion = b;
            Cargar();
        }

        private void Cargar()
        {
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {
                var item = context.Expediente.ToList();
                foreach (var valores in item.Where(n => n.ID_Expediente== ID_Exp))
                {
                    this.ID_Doc = valores.ID_Documentacion;
                    this.ID_Req = valores.ID_Requisitos;
                }
            }
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {
                var item = context.Documentos.ToList();
                foreach (var valores in item.Where(n => n.ID_Documentos== ID_Doc))
                {
                    EntrevistaNR.Checked=valores.Entrevista;
                    CartaCompNR.Checked=valores.Carta_Compromiso;
                    AnexoNR.Checked=valores.Anexo;
                    ReglamentoNR.Checked=valores.Reglamento;
                    RentaNR.Checked=valores.Hoja_Renta;
                }

            }
            using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
            {
                var item = context.Requisitos.ToList();
                foreach (var valores in item.Where(n => n.ID_Requisitos== ID_Req))
                {
                    CartaPresentacionNR.Checked = valores.Carta_Presentacion;
                    SeguroNR.Checked=valores.Carta_Seguro;
                    HistorialAcademicoNR.Checked=valores.Historial_Academico;
                    FotosNR.Checked=valores.Fotos;
                    ComprobanteNR.Checked=valores.Comprobante_Domicilio;
                    ActaNacimientoNR.Checked=valores.Acta_Nacimiento;
                    CurpNR.Checked=valores.Curp;
                    CredencialEscolarNR.Checked=valores.Credencial_Escolar;
                    CredencialElectorNR.Checked=valores.Credencial_Elector;
                    CartaCompIPNNR.Checked=valores.Carta_Compromiso;
                    CartillaNR.Checked=valores.Cartilla_Servicio;


                }
            }



        }

        private void LlenarListaDocumentos()
        {
            ListaDocumentos.Clear();
            ListaDocumentos.Add(EntrevistaNR.Checked);
            ListaDocumentos.Add(CartaCompNR.Checked);
            ListaDocumentos.Add(AnexoNR.Checked);
            ListaDocumentos.Add(ReglamentoNR.Checked);
            ListaDocumentos.Add(RentaNR.Checked);
        }
        private bool Validar()
        {
            if (ListaRequisitos.All(a => !a) || ListaDocumentos.All(a => !a))
            {
                return false;
            }
            else
            {
                return true;
            }


        }

        private void LllenarListaRequisitos()
        {
            ListaRequisitos.Clear();
            ListaRequisitos.Add(CartaPresentacionNR.Checked);
            ListaRequisitos.Add(SeguroNR.Checked);
            ListaRequisitos.Add(HistorialAcademicoNR.Checked);
            ListaRequisitos.Add(FotosNR.Checked);
            ListaRequisitos.Add(ComprobanteNR.Checked);
            ListaRequisitos.Add(ActaNacimientoNR.Checked);
            ListaRequisitos.Add(CurpNR.Checked);
            ListaRequisitos.Add(CredencialEscolarNR.Checked);
            ListaRequisitos.Add(CredencialElectorNR.Checked);
            ListaRequisitos.Add(CartaCompIPNNR.Checked);
            ListaRequisitos.Add(CartillaNR.Checked);

        }
        private void SeleccionarTodoNR_Click(object sender, EventArgs e)
        {
            CartaPresentacionNR.Checked = true;
            SeguroNR.Checked = true;
            HistorialAcademicoNR.Checked = true;
            ActaNacimientoNR.Checked = true;
            CredencialEscolarNR.Checked = true;
            ComprobanteNR.Checked = true;
            CurpNR.Checked = true;
            CredencialElectorNR.Checked = true;
            FotosNR.Checked = true;

            EntrevistaNR.Checked = true;
            CartaCompNR.Checked = true;
            AnexoNR.Checked = true;
            ReglamentoNR.Checked = true;
            RentaNR.Checked = true;
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardarDocumentosNR_Click(object sender, EventArgs e)
        {
            LlenarListaDocumentos();
            LllenarListaRequisitos();
            if (Validar() == false)
            {
                MessageBox.Show("Datos Incompletos");
            }
            else
            {
                using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
                {
                    var a = context.Documentos.SingleOrDefault(n => n.ID_Documentos== ID_Doc);
                    if (a != null)
                    {
                        a.Entrevista = ListaDocumentos[0];
                        a.Carta_Compromiso = ListaDocumentos[1];
                        a.Anexo = ListaDocumentos[2];
                        a.Reglamento = ListaDocumentos[3];
                        a.Hoja_Renta = ListaDocumentos[4];
                        context.SaveChanges();                        
                    }
                }
                using (var context = new Base_Servicio_PracticasEntities(CadenaConexion))
                {
                    var a = context.Requisitos.SingleOrDefault(n => n.ID_Requisitos== ID_Req);
                    if (a != null)
                    {
                        a.Carta_Presentacion = ListaRequisitos[0];
                        a.Carta_Seguro = ListaRequisitos[1];
                        a.Historial_Academico = ListaRequisitos[2];
                        a.Fotos = ListaRequisitos[3];
                        a.Comprobante_Domicilio = ListaRequisitos[4];
                        a.Acta_Nacimiento = ListaRequisitos[5];
                        a.Curp = ListaRequisitos[6];
                        a.Credencial_Escolar = ListaRequisitos[7];
                        a.Credencial_Elector = ListaRequisitos[8];
                        a.Carta_Compromiso = ListaRequisitos[9];
                        a.Cartilla_Servicio = ListaRequisitos[10];
                        context.SaveChanges();
                    }
                }
                MessageBox.Show("Modificacion Correcta");

            }


        }
    }
}
