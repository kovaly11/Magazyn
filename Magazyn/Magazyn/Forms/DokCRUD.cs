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
    public partial class DokCRUD : MetroForm
    {
        private int idPrac;
        private string role;
        public DokCRUD(int idPrac, string role)
        {
            InitializeComponent();
            this.idPrac = idPrac;
            this.role = role;
        }

        private void DokCRUD_Load(object sender, EventArgs e)
        {
            Function toList = new Function();
            prac.Items.Clear();
            company.Items.Clear();
            List<Tables.Prac> pr = toList.ToList<Tables.Prac>("http://localhost:8090/prac/all");
            foreach (var com in pr)
            {
                prac.Items.Add(com.idPrac + " " + com.imie + " " + com.nazw);
            }
            List<Tables.Company> comp = toList.ToList<Tables.Company>("http://localhost:8090/company/all");
            foreach (var com in comp)
            {
                company.Items.Add(com.idCom + " " + com.name);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DokForm companyForm = new DokForm(this.idPrac, this.role);
            companyForm.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Function crud = new Function();


            if (createRadioButton.Checked)
            {
                string[] idPrac = prac.SelectedItem.ToString().Split(' ');
                string[] idCom = company.SelectedItem.ToString().Split(' ');
                var postData = "idPrac=" + Uri.EscapeDataString(idPrac[0]);
                postData += "&idCom=" + Uri.EscapeDataString(idCom[0]);
                postData += "&tDok=" + Uri.EscapeDataString(tDok.Text);
                postData += "&data=" + Uri.EscapeDataString(data.Value.ToString());
                var msg = crud.PostReq("http://localhost:8090/dok/add", postData);
                ErrorForm errorForm = new ErrorForm(msg);
                errorForm.Show();
            }
            if (updateRadioButton.Checked)
            {
                string[] idPrac = prac.SelectedItem.ToString().Split(' ');
                string[] idCom = company.SelectedItem.ToString().Split(' ');
                var postData = "id=" + Uri.EscapeDataString(idDok.Text);
                postData += "&idPrac=" + Uri.EscapeDataString(idPrac[0]);
                postData += "&idCom=" + Uri.EscapeDataString(idCom[0]);
                postData += "&tDok=" + Uri.EscapeDataString(tDok.Text);
                postData += "&data=" + Uri.EscapeDataString(data.Value.ToString());
                var msg = crud.PostReq("http://localhost:8090/dok/update", postData);
                ErrorForm errorForm = new ErrorForm(msg);
                errorForm.Show();
            }
            if (deleteRadioButton.Checked)
            {
                var postData = "id=" + Uri.EscapeDataString(idDok.Text);
                var msg = crud.PostReq("http://localhost:8090/dok/delete", postData);
                ErrorForm errorForm = new ErrorForm(msg);
                errorForm.Show();
            }
            
        }
    }
}
