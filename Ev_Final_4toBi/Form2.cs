using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ev_Final_4toBi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnProducto_Click(object sender, EventArgs e)
        {
            byte Var1 = byte.Parse(TextVar1.Text);
            byte Var2 = byte.Parse(TextVar2.Text);
            int producto = Var1 * Var2;
            MessageBox.Show("El resultado del producto es" + producto);
        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            int Var1 = int.Parse(TextVar1.Text);
            int Var2 = int.Parse(TextVar2.Text);
            int Suma = Var1 + Var2;
            MessageBox.Show("El resultado de la Suma es" + Suma);
        }

        private void BtnPotencia_Click(object sender, EventArgs e)
        {
            int Var1 = int.Parse(TextVar1.Text);
            int Var2 = int.Parse(TextVar2.Text);
            int Potencia = 1;
            int J = 0;
            while (J != Var2)
            {
                Potencia = Potencia * Var1;
                J++;
            }
            MessageBox.Show("El resultado de la potencia es" + Potencia);

        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            byte Var1 = byte.Parse(TextVar1.Text);
            byte Var2 = byte.Parse(TextVar2.Text);
            if (Var2 > 0)
            {
                float Division = Var1 / Var2;
                MessageBox.Show("El resultado de la Division es" + Division);
            }
            else
            {
                MessageBox.Show("La Division es indefinida");
            }
        }
    }
}
