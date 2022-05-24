using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabuada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_processar_Click(object sender, EventArgs e)
        {
            lst_tabuada.Items.Clear();
            int n,conta;

            n = int.Parse(txt_box.Text);

            for(int x=1;x<=10; x++)
            {

                conta = n * x;
                 
                lst_tabuada.Items.Add(n + " X " + x + " = " + conta);
            }
        }

        private void txt_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tabuada_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
