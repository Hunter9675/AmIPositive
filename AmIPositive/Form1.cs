using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmIPositive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numberInput = Convert.ToInt32(ponInput.Text);

            if (numberInput < 0)
            {
                ponOutput.Text = "This number is NOT positive.";
               
            }          
            else
            {
                ponOutput.Text = " This number IS positive";
            }
        }
    }
}
