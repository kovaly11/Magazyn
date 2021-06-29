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
using Magazyn.Tables;

namespace Magazyn.Forms
{
    public partial class CompanyForm : MetroForm
    {
        private int idPrac; 
        private string role;
        public CompanyForm(int idPrac, string role)
        {
            InitializeComponent();
            this.idPrac = idPrac;
            this.role = role;
        }

        private void CompanyForm_Load(object sender, EventArgs e)
        {
            listCompany.Items.Clear();
            Function toList = new Function();
            List<Tables.Company> company = toList.ToList<Tables.Company>("http://localhost:8090/company/all");
            foreach (var com in company)
            {
                var row = new string[] { com.idCom.ToString(), com.name, com.person, com.nip, com.adres.street + " " + com.adres.number};
                var lvi = new ListViewItem(row);
                // lvi.Tag = adres;
                listCompany.Items.Add(lvi);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm(this.idPrac);
            menuForm.Show();
            this.Hide();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (this.role == "admin")
            {
                CompanyCRUD adresCRUD = new CompanyCRUD(this.idPrac, this.role);
                adresCRUD.Show();
                this.Hide();
            }
            else
            {
                ErrorForm errorForm = new ErrorForm("access");
                errorForm.Show();
            }
        }
    }
}