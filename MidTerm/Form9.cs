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
    public partial class Form9 : Form
    {
		int default_Width = 202;
		int default_Height = 69;
		string default_W = "int Width = 202;";
		string default_H = "int Height = 69;";
		string property;
		string value;
		bool isEditing = false;
		int Width = 10;
		int Height = 10;
		public Form9()
		{
			InitializeComponent();
			//TextBox-Code Name
			string code = richTextBox1.Text; //newWidth
			string code2 = richTextBox2.Text; //newHeight
			string[] textArr = code.Split('=');
			property = textArr[0].Trim();
			value = textArr[1].Trim();
			property = property.Split(' ')[1];
			value = value.Split(';')[0];
		}
		private void guna2Button4_Click(object sender, EventArgs e)
		{
			richTextBox1.ReadOnly = false;
			richTextBox2.ReadOnly = false;
			isEditing = true;
		}
		private void guna2Button3_Click(object sender, EventArgs e)
		{
			try
			{
				if (isEditing == true)
				{
					string code1 = richTextBox1.Text;
					string code2 = richTextBox2.Text;

					string val1 = code1.Split('=')[1].Trim();
					string val2 = code2.Split('=')[1].Trim();

					val1 = val1.Split(';')[0];
					val2 = val2.Split(';')[0];

					Console.WriteLine(val1);
					Console.WriteLine(val2);

					Width = Int32.Parse(val1);
					Height = Int32.Parse(val2);

				}
				isEditing = false;
				button1.Size = new Size(Width, Height);
				int diffW = Width - default_Width;
				int diffH = Height - default_Height;
				if (diffW > 0)
				{
					button1.Location = new Point(button1.Location.X - diffW/2, button1.Location.Y);
				}
				else if (diffW < 0)
				{
					button1.Location = new Point(button1.Location.X + -(diffW / 2), button1.Location.Y);
				}
                if (diffH > 0)
                {
                    button1.Location = new Point(button1.Location.X , button1.Location.Y - diffH/2);
                }
                else if (diffH < 0)
                {
                    button1.Location = new Point(button1.Location.X , button1.Location.Y + -(diffH/2));
                }
				default_Width = Width;
                default_Height = Height;

            }
			catch
			{
				MessageBox.Show("ERROR!");
			}
		}
		private void btnCopy_Click(object sender, EventArgs e)
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

		private void text_Changed(object sender, EventArgs e)
		{
			isEditing = true;
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void guna2Button2_Click(object sender, EventArgs e)
		{
			richTextBox1.Text = default_W;
			richTextBox2.Text = default_H;
			isEditing = true;
			guna2Button3_Click(sender, e);
		}

		private void guna2Button5_Click(object sender, EventArgs e)
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
	}
}
