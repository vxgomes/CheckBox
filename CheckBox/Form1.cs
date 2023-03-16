using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String txt = "";
            if(checkBoxMaca.Checked)
            {
                txt += checkBoxMaca.Text + ", ";
            }
            if (checkBoxPera.Checked)
            {
                txt += checkBoxPera.Text + ", ";
            }
            if (checkBoxBanana.Checked)
            {
                txt += checkBoxBanana.Text + ", ";
            }
            if (checkBoxUva.Checked)
            {
                txt += checkBoxUva.Text + ", ";
            }
            if (checkBoxAbacaxi.Checked)
            {
                txt += checkBoxAbacaxi.Text + ", ";
            }
            MessageBox.Show(" A fruta escolhida foi: " + txt, "A fruta escolhida foi...");
        }
    }
}
