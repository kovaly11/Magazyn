using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Components;
using Magazyn.Functions;

namespace Magazyn.Forms
{
    public partial class LoginForm : MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Function fun = new Function();
            int idPrac = Int16.Parse(fun.LogIn(Login.Text, Password.Text));
            if (idPrac==-1)
            {
                Login.Text = "";
                Password.Text = "";
                ErrorForm errorForm = new ErrorForm("login");
                errorForm.Show();
            }
            else
            {
                MenuForm menuForm = new MenuForm(idPrac);
                menuForm.Show();
                this.Hide();
            }
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
