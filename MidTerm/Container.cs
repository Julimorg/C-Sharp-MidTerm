using ComboBox;
using midterm_trungthanh;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm_Midterm;

namespace MidTerm
{
    public partial class Container : Form
    {
        public Container()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelchild.Controls.Add(childForm);
            panelchild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }           
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form1());
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TextBoxControl());
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ComboBoxForm());
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LableForm());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
