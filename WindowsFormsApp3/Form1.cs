using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxValidate(textBox1))
            {

                int a = int.Parse(textBox1.Text);
                int s, v;
                if (a < 0)
                {
                    S.Text = "Длинна ребра должна быть больше 0";
                }
                else
                {
                    v = a * a * a;
                    s = 4 * (a * a);

                    S.Text = "Площадь боковой поверхности куба = " + s.ToString();
                    V.Text = "Объем куба = " + v.ToString();

                }
            }
        }

        private bool textBoxValidate(params TextBox[] textBox)
        {

            bool result = true;

            foreach (TextBox t in textBox)
            {
                if (t.Text == "")
                {
                    errorProvider1.SetError(t, "Заполните поле");
                    result = false;
                }
                else errorProvider1.SetError(t, "");
            }

            return result;

        }
    }
    
}
