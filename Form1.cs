using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONVERTIDOR_ESCALA_0_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {

            double red = Convert.ToInt32(this.txtRed.Text);
            double green = Convert.ToInt32(this.txtGreen.Text);
            double blue = Convert.ToInt32(this.txtBlue.Text);

            double r,g,b;



            //Convert
            const int porcentaje = 100;
            const int ultimoValorRgb = 255;
            r = ((red * porcentaje) / ultimoValorRgb) / porcentaje;
            g = ((green * porcentaje) / ultimoValorRgb) / porcentaje;
            b = ((blue * porcentaje) / ultimoValorRgb) / porcentaje;
            
            this.lblRed.Text = r.ToString("N4");
            this.lblGreen.Text = g.ToString("N4");
            this.lblBlue.Text = b.ToString("N4");


        }
    }
}
