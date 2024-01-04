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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtData.Text = "";
            txtData.Focus();
        }
        private void btnCp2_Click(object sender, EventArgs e)
        {
            string dataToCopy = rTB.Text;
            if (!string.IsNullOrEmpty(dataToCopy))
            {
                Clipboard.SetText(dataToCopy);

                MessageBox.Show("Đã sao chép");
            }
            else
            {
                MessageBox.Show("Please enter data before copying.");
            }
        }
    }
}
