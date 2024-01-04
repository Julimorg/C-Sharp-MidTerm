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
    public partial class LableForm : Form
    {
        public LableForm()
        {
            InitializeComponent();
        }

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
            panelMain.Controls.Add(childForm); 
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void click_lbl_Click(object sender, EventArgs e)
        {
            openChildForm(new FormHover());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            openChildForm(new FormClick());
        }

        private void label6_Click(object sender, EventArgs e)
        {
            openChildForm(new FormTextChangedEvent());

        }

        private void label7_Click(object sender, EventArgs e)
        {
            openChildForm(new FormLabel_MouseLeave_Event());

        }

        private void label5_Click(object sender, EventArgs e)
        {
           openChildForm(new FormBorderStyless());

        }

        private void label8_Click(object sender, EventArgs e)
        {
            openChildForm(new FormAutoSizeChanged());

        }

        private void label9_Click(object sender, EventArgs e)
        {
            openChildForm(new FormBackgroundImageChanged());

        }

        private void label10_Click(object sender, EventArgs e)
        {
            openChildForm(new FormkeyDownPressUp());

        }

        private void label11_Click(object sender, EventArgs e)
        {
            openChildForm(new FormImageList());

        }

        private void label12_Click(object sender, EventArgs e)
        {
            openChildForm(new FormTextAlign());

        }
    }
}
