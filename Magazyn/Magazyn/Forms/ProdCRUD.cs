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
    public partial class ProdCRUD : MetroForm
    {
        private int idPrac;
        private string role;
        public ProdCRUD(int idPrac, string role)
        {
            InitializeComponent();
            this.idPrac = idPrac;
            this.role = role;
        }

        private void ProdCRUD_Load(object sender, EventArgs e)
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
            ProdForm prodForm = new ProdForm(this.idPrac, this.role);
            prodForm.Show();
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
                postData += "&tel=" + Uri.EscapeDataString(tel.Text);
                postData += "&idAd=" + Uri.EscapeDataString(idAd[0]);
                var msg = crud.PostReq("http://localhost:8090/prod/add", postData);
                ErrorForm errorForm = new ErrorForm(msg);
                errorForm.Show();
            }
            if (updateRadioButton.Checked)
            {
                string[] idAd = adres.SelectedItem.ToString().Split(' ');
                var postData = "id=" + Uri.EscapeDataString(idCom.Text);
                postData += "&name=" + Uri.EscapeDataString(name.Text);
                postData += "&person=" + Uri.EscapeDataString(person.Text);
                postData += "&tel=" + Uri.EscapeDataString(tel.Text);
                postData += "&idAd=" + Uri.EscapeDataString(idAd[0]);
                var msg = crud.PostReq("http://localhost:8090/prod/update", postData);
                ErrorForm errorForm = new ErrorForm(msg);
                errorForm.Show();
            }
            if (deleteRadioButton.Checked)
            {
                var postData = "id=" + Uri.EscapeDataString(idCom.Text);
                var msg = crud.PostReq("http://localhost:8090/prod/delete", postData);
                ErrorForm errorForm = new ErrorForm(msg);
                errorForm.Show();
            }
        }
    }
}
