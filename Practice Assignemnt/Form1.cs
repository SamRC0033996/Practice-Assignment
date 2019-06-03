using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_Assignemnt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            //Calculate the area of a rectangle
            try
            {
                double width, height, area;
                width = Convert.ToDouble(textBox1.Text);
                height = Convert.ToDouble(textBox2.Text);
                area = width * height;
                lblArea.Text = "Area = " + area;
            }
            catch
            {
                MessageBox.Show("Type in two numbers.");
            }
        }
    }
}
