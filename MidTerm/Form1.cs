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
            customizeDesign();
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
       
        private void customizeDesign()
        {
            panelMediaSubmenu.Visible =false;
            panelPlaylistSubmenu.Visible =false;
            panelToolSubmenu.Visible =false;
            panelImageSubmenu.Visible = false;

        }
        private void hideSubMenu()
        {
            if(panelMediaSubmenu.Visible == true)
            {
                panelMediaSubmenu.Visible = false;
            }
            if(panelPlaylistSubmenu.Visible == true)
            {
                panelPlaylistSubmenu.Visible = false;
            }
            if (panelToolSubmenu.Visible == true)
            { 
                panelToolSubmenu.Visible = false;
            }
            if(panelImageSubmenu.Visible == true)
            {
                panelImageSubmenu.Visible = false;

            }
        }
        private void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }

        }  
        //Default panel
        private void label1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }
        private void HeadSideBar_Paint(object sender, PaintEventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        //Button Panel
       private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubmenu);
        } 
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form2());
           
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form4());
           
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form5());
           
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form6());
           
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form7());
           
        }
        private void guna2Button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form9());

        }


        private void guna2Button8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form10());

        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form11());

        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form12());

        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form14());

        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form15());

        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form16());

        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form17());

        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form20());

        }

        private void guna2Button18_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form21());

        }

        //Toggle Panel
        private void guna2Button6_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPlaylistSubmenu);

        }
        private void guna2Button11_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form8());
        }
        
        //Radio Panel
        private void btnRadio_Click(object sender, EventArgs e)
        {
            showSubMenu(panelToolSubmenu);
        }
        private void guna2Button17_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form13());

        }

        //Image Button Panel
        private void guna2Button6_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelImageSubmenu);

        }
        private void guna2Button21_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new Form18());

        }
        private void guna2Button20_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form18());

        }
    
        bool isExpand = false;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
