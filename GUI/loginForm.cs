using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class loginForm : Form
    {
        BUS_Employee employee = new BUS_Employee();
        public loginForm()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text!="" && txtPassword.Text != "")
            {
                mainscreenForm mainscreenForm = new mainscreenForm();

                string username = txtUsername.Text.ToString();
                string password = txtPassword.Text.ToString();

                if (employee.login(username, password)) 
                {
                    MessageBox.Show("Login fail");
                    return;
                }

                string manhanvien = employee.getIdUser(username);
                if (manhanvien == "nv1")
                {
                    mainscreenForm.manhanvien = "admin";
                }
                else
                {
                    mainscreenForm.manhanvien = manhanvien;
                }
                this.Hide();
                mainscreenForm.ShowDialog();
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void loginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
