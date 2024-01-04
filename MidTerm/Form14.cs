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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }
        private void btnCopy_Click(object sender, EventArgs e)
        {

            string dataToCopy = txtdata.Text;
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
        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            string dataToCopy = rTB.Text;
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
