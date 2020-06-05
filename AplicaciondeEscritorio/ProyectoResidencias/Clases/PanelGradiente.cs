using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoResidencias
{
    class PanelGradiente : Panel
    {
        public Color ColorArriba { get; set; }
        public Color ColorAbajo { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush LGB = new LinearGradientBrush(this.ClientRectangle,this.ColorArriba,this.ColorAbajo,90F);
            Graphics g = e.Graphics;
            g.FillRectangle(LGB,this.ClientRectangle);

            
            base.OnPaint(e);
        }
    }
}
