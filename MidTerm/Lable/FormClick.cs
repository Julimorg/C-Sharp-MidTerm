using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace midterm_trungthanh
{
    public partial class FormClick : Form
    {
        public FormClick()
        {
            InitializeComponent();
        }

        private void FormClick_Load(object sender, EventArgs e)
        {

        }

        private void hover_demo_MouseLeave(object sender, EventArgs e)
        {

        }

        private void hover_demo_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Demo");
        }
    }
}
