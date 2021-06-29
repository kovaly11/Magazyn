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

namespace Magazyn.Forms
{
    public partial class ErrorForm : MetroForm
    {
        string errorType;

        public ErrorForm(string errorType)
        {
            InitializeComponent();
            this.errorType = errorType;
        }

        private void ErrorForm_Load(object sender, EventArgs e)
        {
            if (this.errorType == "login")
            {
                errorLabel.Text = "Error: Wrong Login or Password!";
            }
            else if (this.errorType == "access")
            {
                errorLabel.Text = "Error: No access to administrator functions!";
            }
            else
                errorLabel.Text = this.errorType;

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
