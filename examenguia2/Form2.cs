using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace examenguia2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnSumar_Click(object sender, EventArgs e)
        {
            int Num1 = int.Parse(TextNum1.Text);
            int Num2 = int.Parse(TextNum2.Text);
            int suma = Num1 + Num2;
            MessageBox.Show("el resultado de la suma" + suma);

        }

        private void BtnResta_Click(object sender, EventArgs e)
        {
            int Num1 = int.Parse(TextNum1.Text);
            int Num2 = int.Parse(TextNum2.Text);
            int resta = Num1 - Num2;
            MessageBox.Show("el resultado de la resta es" + resta);
        


        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            float Num1 = float.Parse(TextNum1.Text);
            float Num2 = float.Parse(TextNum2.Text);

            if (Num2 > 0)
            {
                float division = Num1 / Num2;
                MessageBox.Show("el resultado es " + division);
            }
            else
            {
                MessageBox.Show("la division es indefinida ");

            }
                
        }
    }
}
