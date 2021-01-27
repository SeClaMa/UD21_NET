using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UD21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }   

        private void realizarOperacion_Click(object sender, EventArgs e)
        {
            Geometria geoOpe = new Geometria();
            int resultado;
            int resultado2;
            int resultado3;

            switch (operacion.Text)
            {
                case "Cuadrado":
                    resultado = Convert.ToInt32(var1.Text);
                    MessageBox.Show(Convert.ToString(geoOpe.areacuadrado(resultado)));
                    break;

                case "Circulo":
                    resultado = Convert.ToInt32(var1.Text);
                    MessageBox.Show(Convert.ToString(geoOpe.areaCirculo(resultado)));
                    break;

                case "Triangulo":
                    resultado = Convert.ToInt32(var1.Text);
                    resultado2 = Convert.ToInt32(var2.Text);
                    MessageBox.Show(Convert.ToString(geoOpe.areatriangulo(resultado, resultado2)));

                    break;

                case "Rectangulo":
                    resultado = Convert.ToInt32(var1.Text);
                    resultado2 = Convert.ToInt32(var2.Text);
                    MessageBox.Show(Convert.ToString(geoOpe.arearectangulo(resultado, resultado2)));

                    break;

                case "Pentagono":
                    resultado = Convert.ToInt32(var1.Text);
                    resultado2 = Convert.ToInt32(var2.Text);
                    MessageBox.Show(Convert.ToString(geoOpe.areapentagono(resultado, resultado2)));

                    break;

                case "Rombo":
                    resultado = Convert.ToInt32(var1.Text);
                    resultado2 = Convert.ToInt32(var2.Text);
                    MessageBox.Show(Convert.ToString(geoOpe.arearombo(resultado, resultado2)));
                    break;

                case "Romboide":
                    resultado = Convert.ToInt32(var1.Text);
                    resultado2 = Convert.ToInt32(var2.Text);
                    MessageBox.Show(Convert.ToString(geoOpe.arearomboide(resultado, resultado2)));

                    break;

                case "Trapecio":
                    resultado = Convert.ToInt32(var1.Text);
                    resultado2 = Convert.ToInt32(var2.Text);
                    resultado3 = Convert.ToInt32(var3.Text);
                    MessageBox.Show(Convert.ToString(geoOpe.areatrapecio(resultado, resultado2, resultado3)));

                    break;

                default:
                    break;
            }

        }
    }
}
