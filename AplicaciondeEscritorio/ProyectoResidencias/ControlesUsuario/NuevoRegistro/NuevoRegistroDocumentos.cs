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
    public partial class NuevoRegistroDocumentos : UserControl
    {
        #region Delegados
        public delegate void GDocumentos(List<bool> ListaDocumentos, List<bool> ListaRequisitos);
        public event GDocumentos GuardarDocumentos;
        #endregion

        #region Variables

        List<bool> ListaDocumentos = new List<bool>();
        List<bool> ListaRequisitos = new List<bool>();


        #endregion

        #region Constructor

        public NuevoRegistroDocumentos()
        {
            InitializeComponent();
        }

        #endregion

        #region MetodosApoyo

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
            if(ListaRequisitos.All(a => !a) || ListaDocumentos.All(a => !a))
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
        public void Limpiar()
        {
            ListaDocumentos.Clear();
            ListaRequisitos.Clear();
            CartaPresentacionNR.Checked = false;
           
            SeguroNR.Checked = false;
            HistorialAcademicoNR.Checked = false;
            ActaNacimientoNR.Checked = false;
            ComprobanteNR.Checked = false;
            CurpNR.Checked = false;
            CredencialEscolarNR.Checked = false;
            CredencialElectorNR.Checked = false;
            FotosNR.Checked = false;
            CartaCompIPNNR.Checked = false;
            CartillaNR.Checked = false;

            EntrevistaNR.Checked = false;
            CartaCompNR.Checked = false;
            AnexoNR.Checked = false;
            ReglamentoNR.Checked = false;
            RentaNR.Checked = false;
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

        #endregion

        private void BtnGuardarDocumentosNR_Click(object sender, EventArgs e)
        {
            LlenarListaDocumentos();
            LllenarListaRequisitos();
            if (Validar()==false)
            {
                MessageBox.Show("Datos Incompletos");
            }
            else
            {
                GuardarDocumentos.Invoke(ListaDocumentos,ListaRequisitos);
            }
            

        }
    }
}
