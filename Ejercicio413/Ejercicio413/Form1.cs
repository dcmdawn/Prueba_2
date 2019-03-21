using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio413
{
    public partial class Form1 : Form
    {
        private static string InputBox(string texto)
        {
            InputBoxDialog ib = new InputBoxDialog(); ib.FormPrompt = texto; ib.DefaultValue = "";
            ib.ShowDialog(); string s = ib.InputResponse; ib.Close(); return s;
        }

        public Form1()
        {
            InitializeComponent();
        }
        int potencia(int bas, int exp)
        {
            int res = bas;
            for (int i = 1; i < exp; i++)
            {
                res = res * bas;
            }
            return res;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(InputBox("Introduce un numero"));
            int i = 2;
            int j = 5;
            int l = 7;
            int resi;
            int resj;
            int resl;

            resi = potencia(num, i);

            MessageBox.Show("El " + num + " elevado a " + i + " es = " + resi);

            resj = potencia(num, j);

            MessageBox.Show("El " + num + " elevado a " + j + " es = " + resj);

            resl = potencia(num, l);

            MessageBox.Show("El " + num + " elevado a " + l + " es = " + resl);
        }
    }
}
