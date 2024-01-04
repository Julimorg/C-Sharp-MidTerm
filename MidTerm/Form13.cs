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
    public partial class Form13 : Form
    {
        dbUniversityDataContext db = new dbUniversityDataContext();
        public Form13()
        {
            InitializeComponent();
        }
            private void AllStudentBtn_CheckedChanged(object sender, EventArgs e)
            {
                var lst = (from user in db.Users
                           select user).OrderBy(i => i.role_).ToList();
                dataGridView1.DataSource = lst;


            }

            private void LectureBtn_CheckedChanged(object sender, EventArgs e)
            {
                var lst = (from user in db.Users where user.role_ == "lecture" select user).OrderBy(i => i.role_).ToList();
                dataGridView1.DataSource = lst;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                    row.DefaultCellStyle.BackColor = Color.Pink;
            }
            private void AcademicBtn_CheckedChanged(object sender, EventArgs e)
            {
                var lst = (from user in db.Users where user.role_ == "academic affair" select user).OrderBy(i => i.role_).ToList();
                dataGridView1.DataSource = lst;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                    row.DefaultCellStyle.BackColor = Color.FromArgb(97, 252, 102);
            }
            private void StudentBtn_CheckedChanged(object sender, EventArgs e)
            {
                var lst = (from user in db.Users where user.role_ == "student" select user).OrderBy(i => i.role_).ToList();
                dataGridView1.DataSource = lst;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                    row.DefaultCellStyle.BackColor = Color.FromArgb(87, 185, 249);
            }

            private void AdminBtn_CheckedChanged_1(object sender, EventArgs e)
            {
                var lst = (from user in db.Users where user.role_ == "admin" select user).OrderBy(i => i.role_).ToList();
                dataGridView1.DataSource = lst;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                    row.DefaultCellStyle.BackColor = Color.Yellow;
            }

        private void Form13_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'universityDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.universityDataSet.Users);
            // TODO: This line of code loads data into the 'dBUniversityDataSet.Users' table. You can move, or remove it, as needed.
            //this.usersTableAdapter.Fill(this.dBUniversityDataSet.Users);

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
