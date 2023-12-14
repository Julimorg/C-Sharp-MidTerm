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
    public partial class Form1 : Form
    {
     
        public Form1()
        {
            InitializeComponent();
        }

        bool isExpand = false;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(isExpand == false)
            {
                MenuDropDown.Height += 1000;

                if (MenuDropDown.Height >= MenuDropDown.MaximumSize.Height) 
                {
                    timer1.Stop();
                    isExpand = true;
                   
                }
            }
           else
            {
                MenuDropDown.Height -= 1000;
                if(MenuDropDown.Height >= MenuDropDown.MinimumSize.Height)
                {
                     
                    timer1.Stop();
                    isExpand = false; 
                }
            }

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
            panelchild.Controls.Add(childForm);
            panelchild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        } 
       
        private void ButtonSelect_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            timer1.Start();

        }
         private void Button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form2());

        }
        private void Button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form3());

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form4());

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form5());

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form6());

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form7());

        }

        private void Button8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form8());

        }

        private void Button9_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form9());

        }

        private void Button10_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form10());

        }

        private void Button11_Click(object sender, EventArgs e)
        {

        }
    }
}
