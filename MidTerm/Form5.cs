using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidTerm
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            
        }
  
        /*Setting multi panel child content*/
        //Panel child content 
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
            MultiForm2.Controls.Add(childForm);
            MultiForm2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

        }
        private void Button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form24());
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form25());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
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

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string dataToCopy = richTextBox2.Text;
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

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void MultiForm1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MultiForm2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
