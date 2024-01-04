using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidTerm
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        int clickCount = 0;
        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            clickCount++;
            if (clickCount % 2 == 1)
            {
                btnChangeColor.FillColor = Color.Gray;
                btnChangeColor.ForeColor = Color.White;
            }
            else
            {
                btnChangeColor.FillColor = Color.FromArgb(94, 148, 255);
                btnChangeColor.ForeColor = Color.White;
            }
        }
        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            string dataToCopy = richTextBox1.Text;
            if (!string.IsNullOrEmpty(dataToCopy))
            {
                Clipboard.SetText(dataToCopy);

                MessageBox.Show("Copied to Clipboard!");
            }
            else
            {
                MessageBox.Show("Please enter data before copying.");
            }
        }
    }
}
