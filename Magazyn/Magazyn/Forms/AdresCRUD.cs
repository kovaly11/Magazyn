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
    public partial class AdresCRUD : MetroForm
    {
        private int idPrac;
        private string role;
        public AdresCRUD(int idPrac, string role)
        {
            InitializeComponent();
            this.idPrac = idPrac;
            this.role = role;
        }

        private void AdresCRUD_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            AdresForm adresForm = new AdresForm(this.idPrac, this.role);
            adresForm.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Function crud = new Function();
            if (createRadioButton.Checked) 
            {
                var postData = "street=" + Uri.EscapeDataString(street.Text);
                postData += "&number=" + Uri.EscapeDataString(number.Text);
                postData += "&city=" + Uri.EscapeDataString(city.Text);
                postData += "&pCode=" + Uri.EscapeDataString(pCode.Text);            
                var msg = crud.PostReq("http://localhost:8090/adres/add", postData);
                ErrorForm errorForm = new ErrorForm(msg);
                errorForm.Show();
            }
            if(updateRadioButton.Checked)
            {
                var postData = "id=" + Uri.EscapeDataString(idAd.Text);
                postData += "&street=" + Uri.EscapeDataString(street.Text);
                postData += "&number=" + Uri.EscapeDataString(number.Text);
                postData += "&city=" + Uri.EscapeDataString(city.Text);
                postData += "&pCode=" + Uri.EscapeDataString(pCode.Text);
                var msg = crud.PostReq("http://localhost:8090/adres/update", postData);
                ErrorForm errorForm = new ErrorForm(msg);
                errorForm.Show();
            }
            if (deleteRadioButton.Checked)
            {
                var postData = "id=" + Uri.EscapeDataString(idAd.Text);
                var msg = crud.PostReq("http://localhost:8090/adres/delete", postData);
                ErrorForm errorForm = new ErrorForm(msg);
                errorForm.Show();
            }
        }

    }
}
