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
    public partial class Form11 : Form
    {
        bool defaultEnabled = false;
        bool isEdit = false;
        public Form11()
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
            richTextBox1.Text = "btnEnable.Enabled = false;";
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
                if(isEdit)
                {
                    string code = richTextBox1.Text;
                    string val = code.Split('=')[1].Trim();
                    val = val.Split(';')[0];
                    btnEnable.Enabled = (val == "false")?false:true;
                    btnEnable.Text = code.Split('.')[1].Trim();
                }
                isEdit = false;
                richTextBox1.ReadOnly = true;
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
            
        }
        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
