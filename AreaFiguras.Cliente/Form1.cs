using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaFiguras.Cliente
{
    public partial class calculadorAreaFiguras : Form
    {
        public calculadorAreaFiguras()
        {
            InitializeComponent();
        }
        AFigurasServiceReference.AreaFigurasWebServiceSoapClient calc = new AFigurasServiceReference.AreaFigurasWebServiceSoapClient();

        private void areaCuadradoButton_Click(object sender, EventArgs e)
        {
            resultadoCuadradoLabel.Text = calc.AreaCuadrado(Convert.ToInt32(ladoCuadradoTextBox.Text)).ToString();
        }

        private void areaTrianguloButton_Click(object sender, EventArgs e)
        {
            resultadoTrianguloLabel.Text = calc.AreaTriangulo(Convert.ToInt32(baseTrianguloTextBox.Text), Convert.ToInt32(alturaTrianguloTextBox.Text)).ToString();
        }

        private void areaCirculoButton_Click(object sender, EventArgs e)
        {
            resultadoCirculoLabel.Text = calc.AreaCirculo(Convert.ToDouble(radioCirculoTextBox.Text)).ToString();
        }
    }
}
