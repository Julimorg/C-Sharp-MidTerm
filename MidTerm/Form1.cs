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
    
        private void ButtonSelect_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
       
    }
}
