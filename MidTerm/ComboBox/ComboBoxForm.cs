using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class ComboBoxForm : Form
    {
        public ComboBoxForm()
        {
            InitializeComponent();
            InitializeComboBox();            
        }
        private void InitializeComboBox()
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.Add("Add");
            comboBox1.Items.Add("Size");
            comboBox1.Items.Add("Font");
            comboBox1.SelectedIndex = 0;

            comboBox1.Enabled = true; 
            comboBox1.Visible = true;

            comboBox1.Font = new System.Drawing.Font("Arial", 10f);
            comboBox1.Text = "Combo Box";
            comboBox1.BackColor = System.Drawing.Color.Pink;
            comboBox1.ForeColor = System.Drawing.Color.White;
            comboBox1.DropDownHeight = 100;

            comboBox1.Height = 30;
            
        }

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbValue1.Text = cboDepartment.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboChooseMore.Items.Add("Korean");
            cboChooseMore.Items.Add("Law");
            
            //cboCountries.Items.Clear();

            //Init data
            List<City> list = new List<City>();
            list.Add(new City() { ID = "01", nameCity = "HO CHi MINH", });
            list.Add(new City() { ID = "02", nameCity = "NHA TRANG" });
            list.Add(new City() { ID = "03", nameCity = "HA NOI" });
            //set display member and value for combo box
            cboID.DataSource = list;
            cboID.ValueMember = "nameCity";
            cboID.DisplayMember = "ID";


        }

        private void cboChooseMore_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbValue2.Text = cboChooseMore.Text;
        }

        private void cboCity_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            City obj = cboID.SelectedItem as City;
            if(obj != null)
            {
                lbValue4.Text = obj.nameCity;
            }
        }

        private void cboDay_DropDown(object sender, EventArgs e)
        {
            cboDay.Items.Clear();
            cboDay.Items.Add("1");
            cboDay.Items.Add("2");
            cboDay.Items.Add("3");
            cboDay.Items.Add("4");
        }

        private void cboPay_SelectedValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show("You choose by " + cboPay.SelectedItem);
        }

        private void btnChangeColour_Click(object sender, EventArgs e)
        {
           if(cboColour.Text == "Yellow")
            {
                lbChangeColour.BackColor = Color.Red;
                lbChangeColour.ForeColor = Color.Yellow;
            }
            if (cboColour.Text == "Red")
            {
                lbChangeColour.ForeColor = Color.Yellow;
                lbChangeColour.BackColor = Color.Red;               
            }
            if (cboColour.Text == "Blue")
            {
                lbChangeColour.ForeColor = Color.Yellow;
                lbChangeColour.BackColor = Color.Blue;
            }
            if (cboColour.Text == "Black")
            {
                lbChangeColour.ForeColor = Color.White;
                lbChangeColour.BackColor = Color.Black;
            }
        }        

        private void label25_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel9_Click(object sender, EventArgs e)
        {

        }

        private void label53_Click(object sender, EventArgs e)
        {

        }

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel8_Click(object sender, EventArgs e)
        {

        }

        private void label51_Click(object sender, EventArgs e)
        {

        }

        private void label48_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void label49_Click(object sender, EventArgs e)
        {

        }

        private void label46_Click(object sender, EventArgs e)
        {

        }

        private void label47_Click(object sender, EventArgs e)
        {

        }

        private void label52_Click(object sender, EventArgs e)
        {

        }
    }
}
