using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace La_calculadora_2._0
{
    public partial class form1 : Form
    {
        double primero;
        double segundo;
        string operador;

        public form1()
        {
            InitializeComponent();
        }


        Clases.ClsSuma obj = new Clases.ClsSuma();
        Clases.ClsResta obj2 = new Clases.ClsResta();
        Clases.ClsMultiplicacion obj3 = new Clases.ClsMultiplicacion();
        Clases.ClsDivision obj4 = new Clases.ClsDivision();



        private void button20_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(tbxScreen.Text);

            double Sum;
            double Res;
            double Mul;
            double Div;

            switch(operador)
            {
                case "+":
                    Sum = obj.Sumar((primero), (segundo));
                    tbxScreen.Text = Sum.ToString();
                    break;


                case "-":
                    Res = obj2.Restar((primero), (segundo));
                    tbxScreen.Text = Res.ToString();
                    break;


                case "*":
                    Mul = obj3.Multiplicacion((primero), (segundo));
                    tbxScreen.Text = Mul.ToString();
                    break;


                case "/":
                    Div = obj4.Division((primero), (segundo));
                    tbxScreen.Text = Div.ToString();
                    break;

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (tbxScreen.Text.Length == 1)
                tbxScreen.Text = "";
            else
                tbxScreen.Text = tbxScreen.Text.Substring(0, tbxScreen.Text.Length - 1);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen + "3";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen + "6";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen + "9";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen + "0";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen + "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen + "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen + "8";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tbxScreen.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen + ".";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen + "4";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen + "7";
        }

        private void form1_Load(object sender, EventArgs e)
        {

        }
    }
}
