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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        bool IsDropDown = false;
        private void MenuDrop_Tick(object sender, EventArgs e)
        {
            if (!IsDropDown)
            {
                DropContainer.Height += 60;
                Content.Location = new Point(Content.Location.X, DropContainer.Height + 30);
                label1.Location = new Point(label1.Location.X, Content.Location.Y + Content.Height - 5);
                Code.Location = new Point(Code.Location.X, label1.Location.Y + label1.Height + 5);
                CopyBtnCode1.Location = new Point(CopyBtnCode1.Location.X, Code.Location.Y + Code.Height + 6);
                if (DropContainer.Height == DropContainer.MaximumSize.Height)
                {
                    IsDropDown = true;
                    MenuDrop.Stop();
                }
            }
            else
            {
                DropContainer.Height -= 60;
                Content.Location = new Point(Content.Location.X, DropContainer.Height + 30);
                label1.Location = new Point(label1.Location.X, Content.Location.Y + Content.Height - 5);
                Code.Location = new Point(Code.Location.X, label1.Location.Y + label1.Height + 5);
                CopyBtnCode1.Location = new Point(CopyBtnCode1.Location.X, Code.Location.Y + Code.Height + 6);
                if (DropContainer.Height == DropContainer.MinimumSize.Height)
                {
                    IsDropDown = false;
                    MenuDrop.Stop();
                }
            }
        }

        private void HoverDropBtn_Click(object sender, EventArgs e)
        {
            MenuDrop.Start(); //Set thời gian delay (ms)
            if (HoverDropBtn.FillColor == Color.FromArgb(62, 114, 199))
            {
                HoverDropBtn.FillColor = Color.FromArgb(94, 148, 255);
            }
            else
            {
                HoverDropBtn.FillColor = Color.FromArgb(62, 114, 199);
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
                default:
                    break;
            }
            Clipboard.SetText(dataToCopy);
            MessageBox.Show("Đã sao chép!");
        }
    }
}
