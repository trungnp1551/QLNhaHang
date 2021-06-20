using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class mainscreenForm : Form
    {
        public mainscreenForm()
        {
            InitializeComponent();
        }
        DateTime dateTime;

        public string manhanvien;

        private void mainscreenForm_Load(object sender, EventArgs e)
        {
            lblQuyen.Text = "Mã nhân viên: " + manhanvien;
            dateTime = DateTime.Now;
            lblTime.Text = dateTime.ToString();
            if(manhanvien == "admin")
            {
                btEmployeeForm.Enabled = true;
                btBill.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateTime = DateTime.Now;
            lblTime.Text = dateTime.ToString();
        }

        private void btServerForm_Click(object sender, EventArgs e)
        {
            //this.Hide();
            serveForm serveForm = new serveForm();
            serveForm.manhanvien = manhanvien;
            serveForm.ShowDialog();

        }

        private void btMenuForm_Click(object sender, EventArgs e)
        {
            //this.Hide();
            menuForm menuForm = new menuForm();
            menuForm.ShowDialog();

        }

        private void btEmployeeForm_Click(object sender, EventArgs e)
        {
            //this.Close();
            employeeForm employeeForm = new employeeForm();
            employeeForm.ShowDialog();

        }

        private void btBill_Click(object sender, EventArgs e)
        {
            billForm billForm = new billForm();
            billForm.ShowDialog();
        }

        private void mainscreenForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm loginForm = new loginForm();
            loginForm.ShowDialog();
        }
    }
}
