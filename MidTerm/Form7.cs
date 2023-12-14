using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Speech.Synthesis.TtsEngine;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidTerm
{
    public partial class Form7 : Form
    {
        string default_thickness;
        string default_style;
        string default_radius;
        string default_BorColor;
        string default_FillColor;
        string property;
        string value;
        bool isEdit = false;
        public Form7()
        {
            InitializeComponent();
            Button2.BorderThickness = 2;
            Button2.BorderStyle = DashStyle.Dot;
            Button2.BorderRadius = 5;
            Button2.BorderColor = Color.Black;
            Button2.FillColor = Color.MediumPurple;
            //TextBox-Code Name
             default_thickness  =  Box1.Text; //thickness
             default_style = Box2.Text; //borderStyle
             default_radius = Box3.Text; //Radius
             default_BorColor = Box4.Text; // BorderColor
             default_FillColor = Box5.Text; // FillColor
          /*  string[] textArr = code.Split('=');
            property = textArr[0].Trim();
            value = textArr[1].Trim();
            property = property.Split('.')[1];
            value = value.Split(';')[0];*/
            //Tìm property 
            /*Console.WriteLine(property + property.Length);
            Console.WriteLine(value + value.Length);*/
            /*onsole.WriteLine(property + "\n" + value);*/
        }
        private void Box1_TextChanged(object sender, EventArgs e)
        {
            isEdit = true;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (isEdit == true)
                {
                    string code1 = Box1.Text;
                    string code2 = Box2.Text;
                    string code3 = Box3.Text;
                    string code4 = Box4.Text;
                    string code5 = Box5.Text;

                    string val1 = code1.Split('=')[1].Trim();
                    string val2 = code2.Split('=')[1].Trim();
                    string val3 = code3.Split('=')[1].Trim();
                    string val4 = code4.Split('=')[1].Trim();
                    string val5 = code5.Split('=')[1].Trim();

                    val1 = val1.Split(';')[0]; //Thickness
                    val2 = val2.Split('.')[1].Split(';')[0];//Style
                     
                    val3 = val3.Split(';')[0]; //Radius
                    val4 = val4.Split('.')[1].Split(';')[0];//Color
                    
                    val5 = val5.Split('.')[1].Split(';')[0];//Color
                    
                    Console.WriteLine(val1);
                    Console.WriteLine(val2);
                    Console.WriteLine(val3);
                    Console.WriteLine(val4);
                    Console.WriteLine(val5);

                    Button2.BorderThickness = Int32.Parse(val1);
                

            switch (val2)
                    {
                        case "Solid":
                            Button2.BorderStyle = DashStyle.Solid;
                            break;
                        case "Dash":
                            Button2.BorderStyle = DashStyle.Dash;
                            break;
                        case "Dot":
                            Button2.BorderStyle = DashStyle.Dot;
                            break;
                        case "DashDot":
                            Button2.BorderStyle = DashStyle.DashDot;
                            break;
                        case "DashDotDot":
                            Button2.BorderStyle = DashStyle.DashDotDot;
                            break;
                    }
                    Button2.BorderRadius = Int32.Parse(val3);
                    Button2.FillColor = Color.FromName(val5);
                    Button2.BorderColor = Color.FromName(val4);
                }
            }
         catch
     {
         MessageBox.Show("ERROR!");
     }
            isEdit = false;
}
        private void label5_Click(object sender, EventArgs e)
        {
            
        }   
        private void guna2Button9_Click(object sender, EventArgs e)
        {
            //reset Thickness
            Box1.Text = default_thickness;
            guna2Button1_Click(sender, e);
        } 
        private void guna2Button7_Click(object sender, EventArgs e)
        {
            //reset Style
            Box2.Text = default_style;
            guna2Button1_Click(sender, e);
        }
        private void guna2Button10_Click(object sender, EventArgs e)
        {
            //reset BorderRadius
            Box3.Text = default_radius;
            guna2Button1_Click(sender, e);
        }
        private void guna2Button8_Click(object sender, EventArgs e)
        {
            //reset BorderColor
            Box4.Text = default_BorColor;
            guna2Button1_Click(sender, e);
        } 
        private void guna2Button11_Click(object sender, EventArgs e)
        {
            //reset Fill Color
            Box5.Text = default_FillColor;
            guna2Button1_Click(sender, e);
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string dataToCopy = Box1.Text;
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

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            string dataToCopy = Box3.Text;
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

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            string dataToCopy = Box4.Text;
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

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            string dataToCopy = Box2.Text;
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

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            string dataToCopy = Box5.Text;
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
        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

      
    }
}
