using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadoraa
{
    public partial class Calculator : Form
    {
        double pri;
        double seg;
        string op;
    
        public Calculator()
        {
            InitializeComponent();
        }

        Clases.ClsSuma obj = new Clases.ClsSuma();
        Clases.ClsResta obj2 = new Clases.ClsResta();
        Clases.ClsMultiplicacion obj3 = new Clases.ClsMultiplicacion();
        Clases.ClsDivision obj4 = new Clases.ClsDivision();
        Clases.ClsPorcentaje obj5 = new Clases.ClsPorcentaje();


      

        private void Boton6_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "6";
        }

        private void Boton0_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "0";
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Boton1_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "1";
        }

        private void Boton2_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "2";
        }

        private void Boton3_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "3";
        }

        private void Boton4_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "4";
        }

        private void Boton5_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "5";
        }

        private void Boton7_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "7";
        }

        private void Boton8_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "8";
        }

        private void Boton9_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "9";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Botonsumar_Click(object sender, EventArgs e)
        {
            op = "+";
            pri = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void Botonrestar_Click(object sender, EventArgs e)
        {
            op = "-";
            pri = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void Botonmultiplicar_Click(object sender, EventArgs e)
        {
            op = "*";
            pri = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void Botondividir_Click(object sender, EventArgs e)
        {
            op = "/";
            pri = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void Botonporcentaje_Click(object sender, EventArgs e)
        {
            op = "%";
            pri = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }
        private void Botonigual_Click(object sender, EventArgs e)
        {
            seg = double.Parse(tbxScreen.Text);

            double su;
            double re;
            double mu;
            double di;
            double po;

            switch (op)
            {
                case "+":
                    su = obj.Sumar((pri), (seg));
                    tbxScreen.Text = su.ToString();
                    break;
                case "-":
                    re = obj2.Restar((pri), (seg));
                    tbxScreen.Text = re.ToString();
                    break;
                case "*":
                    mu = obj3.Multiplicar((pri), (seg));
                    tbxScreen.Text = mu.ToString();
                    break;
                case "/":
                    di = obj4.Dividir((pri), (seg));
                    tbxScreen.Text = di.ToString();
                    break;
                case "%":
                    po = obj5.Porcentaje((pri), (seg));
                    tbxScreen.Text = po.ToString();
                    break;
            }
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            if (tbxScreen.Text.Length == 1)
                tbxScreen.Text = "";
            else
                tbxScreen.Text = tbxScreen.Text.Substring(0, tbxScreen.Text.Length - 1);
        }
        private void Button16_Click(object sender, EventArgs e)
        {
            tbxScreen.Clear();
        }
    }

}
