using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFtextchanger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
         private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (red.Checked)
            {
                textBox1.ForeColor = Color.Red;
            }
            if (blue.Checked)
            {
                textBox1.ForeColor = Color.Blue;
            }
            if(orange.Checked)
            {
                textBox1.ForeColor = Color.Orange;
            }
            if (wm.Checked)
            {
                this.textBox1.Font = new System.Drawing.Font("Arial", 8 );
            }
            if (wd.Checked)
            {
                this.textBox1.Font = new System.Drawing.Font("Arial", 12 );
            }
            if (wbd.Checked)
            {
                this.textBox1.Font = new System.Drawing.Font("Arial", 16 );
            }
            if (spogrubione.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Bold);
            }
            if (spodkreslone.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Underline);
            }
            if (spochylone.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Italic);
            }
        }

      
    }
}
