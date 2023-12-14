using Guna.UI2.WinForms;
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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void lightdarkmodebtn_CheckedChanged(object sender, EventArgs e)
        {
            if (lightdarkmodebtn.Checked)
            {
                this.BackColor = Color.DimGray;
                DarkMode.ForeColor = Color.WhiteSmoke;
                label1.ForeColor = Color.WhiteSmoke;
                richTextBox2.ForeColor = Color.Black;
                Code2.ForeColor = Color.Black;
                txtbox.ForeColor = Color.Blue;
                label2.ForeColor = Color.WhiteSmoke;


            }
            else
            {
                this.BackColor = Color.WhiteSmoke;
                DarkMode.ForeColor = Color.Black;
                label1.ForeColor = Color.Black;
                richTextBox2.ForeColor = Color.Black;
                Code2.ForeColor = Color.Black;
                txtbox.ForeColor = Color.Black;
                label2.ForeColor = Color.Blue;
            }
        }
        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CopyBtnCode2_Click(object sender, EventArgs e)
        {
            string dataToCopy = "";
            Guna2CircleButton btn = (Guna2CircleButton)sender;
            switch (btn.Name)
            {
                case "CopyBtnCode2":
                    dataToCopy = richTextBox2.Text;
                    break;
                default:
                    break;
            }
            Clipboard.SetText(dataToCopy);
            MessageBox.Show("Đã sao chép!");
        }
    }
}
