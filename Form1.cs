using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPAFaculdade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            double n1, res = 0;
            int i = 1;
            n1 = double.Parse(txtb_Numero1.Text);

            if(rdb_Multiplicaçao.Checked)
            {
                
                while (i <= ((int)nupd_Numero2.Value))
                {                
                    res = (n1 * i);                    
                    lb_Resultado.Items.Add(n1 + " * " + i + " = " + res);
                    i++;
                }
                
            }
            else
            {
                while (((int)nupd_Numero2.Value) >= i)
                {
                    res = (n1 / i);
                    lb_Resultado.Items.Add(n1 + " / " + i + " = " + res);
                    i++;
                }
            }
            
        }

        private void nupd_Numero2_ValueChanged(object sender, EventArgs e)
        {
            ((int)nupd_Numero2.Value).ToString("X2");
        }

        private void lb_Resultado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lb_Resultado_DoubleClick(object sender, EventArgs e)
        {
        }
    }
}
