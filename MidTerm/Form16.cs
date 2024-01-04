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
    public partial class Form16 : Form
    {
        bool isEdit = false;
        public Form16()
        {
            InitializeComponent();
        }
        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            string dataToCopy = richTextBox1.Text;
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
        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "btnEnable.Visible = true;";
            richTextBox1.Focus();
            isEdit = true;
            guna2CircleButton4_Click(sender, e);
        }
        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            isEdit = true;
            richTextBox1.ReadOnly = false;
        }
        private void guna2CircleButton4_Click(object sender, EventArgs e)
        {
            try
            {
                if (isEdit)
                {
                    string code = richTextBox1.Text;
                    string val = code.Split('=')[1].Trim();
                    val = val.Split(';')[0];
                    btnEnable.Visible = (val == "false") ? false : true;
                    InvisibleAlert.Visible = (val == "false") ? true : false;
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
            isEdit = false;
            richTextBox1.ReadOnly = true;
        }
    }
}
