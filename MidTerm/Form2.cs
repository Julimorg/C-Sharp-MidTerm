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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void TestHoverBtn_MouseHover(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            btn.FillColor = Color.Black;
            DropdownInf.Start();
        }

        private void TestHoverBtn_MouseLeave(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            btn.FillColor = Color.FromArgb(94, 148, 255);
        }

        private void TestHoverBorder_MouseEnter(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            btn.FillColor = Color.White;
            btn.ForeColor = Color.FromArgb(94, 148, 255);
            btn.BorderColor = Color.FromArgb(94, 148, 255);
        }

        private void TestHoverBorder_MouseLeave(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            btn.FillColor = Color.FromArgb(94, 148, 255);
            btn.ForeColor = Color.White;
            btn.BorderColor = Color.Transparent;
        }



        bool IsDropDown = false;
        private void DropdownInf_Tick(object sender, EventArgs e)
        {
            if (!IsDropDown)
            {
                Content.Height += 210;
                Code.Location = new Point(Code.Location.X, 286);
                label1.Location = new Point(label1.Location.X, 255);
                CopyBtnCode1.Location = new Point(CopyBtnCode1.Location.X, Code.Location.Y + Code.Height + 6);

                TestHoverBorder.Location = new Point(TestHoverBorder.Location.X, 525);
                Code2.Location = new Point(Code2.Location.X, 606);
                label2.Location = new Point(label2.Location.X, 576);
                CopyBtnCode2.Location = new Point(CopyBtnCode2.Location.X, Code2.Location.Y + Code2.Height + 6);
                if (Content.Height == Content.MaximumSize.Height)
                {
                    DropdownInf.Stop();
                }
            }
        }

        private void CopyCode(object sender, EventArgs e)
        {
            string dataToCopy = "";
            Guna2CircleButton btn = (Guna2CircleButton)sender;
            switch (btn.Name)
            {
                case "CopyBtnCode1":
                    dataToCopy = richTextBox1.Text;
                    break;
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
