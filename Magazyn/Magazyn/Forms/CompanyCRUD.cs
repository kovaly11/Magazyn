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
    public partial class CompanyCRUD : MetroForm
    {
        private int idPrac;
        private string role;
        public CompanyCRUD(int idPrac, string role)
        {
            InitializeComponent();
            this.idPrac = idPrac;
            this.role = role;
        }

        private void CompanyCRUD_Load(object sender, EventArgs e)
        {
            Function toList = new Function();
            adres.Items.Clear();
            List<Tables.Adres> adr = toList.ToList<Tables.Adres>("http://localhost:8090/adres/all");
            foreach (var com in adr)
            { 
                adres.Items.Add(com.idAd + " " + com.street + ' ' + com.number);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            CompanyForm companyForm = new CompanyForm(this.idPrac, this.role);
            companyForm.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Function crud = new Function();
            

            if (createRadioButton.Checked)
            {
                string[] idAd = adres.SelectedItem.ToString().Split(' ');
                var postData = "name=" + Uri.EscapeDataString(name.Text);
                postData += "&person=" + Uri.EscapeDataString(person.Text);
                postData += "&nip=" + Uri.EscapeDataString(nip.Text);
                postData += "&idAd=" + Uri.EscapeDataString(idAd[0]);
                var msg = crud.PostReq("http://localhost:8090/company/add", postData);
                ErrorForm errorForm = new ErrorForm(msg);
                errorForm.Show();
            }
            if (updateRadioButton.Checked)
            {
                string[] idAd = adres.SelectedItem.ToString().Split(' ');
                var postData = "id=" + Uri.EscapeDataString(idCom.Text);
                postData += "&name=" + Uri.EscapeDataString(name.Text);
                postData += "&person=" + Uri.EscapeDataString(person.Text);
                postData += "&nip=" + Uri.EscapeDataString(nip.Text);
                postData += "&idAd=" + Uri.EscapeDataString(idAd[0]);
                var msg = crud.PostReq("http://localhost:8090/company/update", postData);
                ErrorForm errorForm = new ErrorForm(msg);
                errorForm.Show();
            }
            if (deleteRadioButton.Checked)
            {
                var postData = "id=" + Uri.EscapeDataString(idCom.Text);
                var msg = crud.PostReq("http://localhost:8090/company/delete", postData);
                ErrorForm errorForm = new ErrorForm(msg);
                errorForm.Show();
            }

        }
    }
}
