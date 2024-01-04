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
    public partial class Form18 : Form
    {
		private int cornerRadius = 50;
		public Form18()
        {
            InitializeComponent();
			RoundCorners(panel1, 10);
		}
		private void close_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Kết thúc chương trình");
		}
		private void RoundCorners(Panel panel, int cornerRadius)
		{
			// Tạo đối tượng GraphicsPath để bo tròn góc
			GraphicsPath path = new GraphicsPath();
			path.AddArc(0, 0, cornerRadius * 2, cornerRadius * 2, 180, 90);
			path.AddArc(panel.Width - (cornerRadius * 2), 0, cornerRadius * 2, cornerRadius * 2, 270, 90);
			path.AddArc(panel.Width - (cornerRadius * 2), panel.Height - (cornerRadius * 2), cornerRadius * 2, cornerRadius * 2, 0, 90);
			path.AddArc(0, panel.Height - (cornerRadius * 2), cornerRadius * 2, cornerRadius * 2, 90, 90);
			panel.Region = new Region(path);
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}
		private void minimize_Click(object sender, EventArgs e)
		{
			//WindowState = FormWindowState.Minimized;
			MessageBox.Show("Button này giúp thu nhỏ của sổ");
		}
		private void maximize_Click(object sender, EventArgs e)
		{
			/*if (WindowState == FormWindowState.Normal)
			{
				WindowState = FormWindowState.Maximized;
			}
			else
			{
				WindowState = FormWindowState.Normal;
			}*/
			MessageBox.Show("Button này phống lớn của sổ");
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
    }
}
