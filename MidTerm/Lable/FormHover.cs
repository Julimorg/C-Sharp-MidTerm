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
    public partial class FormHover : Form
    {

        private Form currentFormChild;
        private void openChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_demo_click.Controls.Add(childForm);
            panel_demo_click.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        public FormHover()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void demo_label_Click(object sender, EventArgs e)
        {
            openChildForm(new demo_label_click());

        }

        private void FormHover_Load(object sender, EventArgs e)
        {

        }
    }
}
