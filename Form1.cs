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

            double re,gr,bl;



            //Convert
            const int porcentaje = 80;
            const int ultimoValorRgb = 225;
            re = ((red * porcentaje) / ultimoValorRgb) / porcentaje;
            gr = ((green * porcentaje) / ultimoValorRgb) / porcentaje;
            bl = ((blue * porcentaje) / ultimoValorRgb) / porcentaje;
            
            this.lblRed.Text = re.ToString("N4");
            this.lblGreen.Text = gr.ToString("N4");
            this.lblBlue.Text = bl.ToString("N4");


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario = new Form2();
            formulario.Show();
        }
    }
}
