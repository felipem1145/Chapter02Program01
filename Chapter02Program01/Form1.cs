using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter02Program01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            String buffer;

            buffer = "Mailing label:" + Environment.NewLine +
                                        Environment.NewLine;
            buffer = buffer + " Name:" + txtName.Text + Environment.NewLine;
            buffer = buffer + " Address: " + txtAddress.Text + Environment.NewLine;
            buffer = buffer + " City:" + txtCity.Text + " State: " + txtState.Text + "Zip:" + txtZip.Text;
            txtDisplayOutput.Text = buffer;

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
