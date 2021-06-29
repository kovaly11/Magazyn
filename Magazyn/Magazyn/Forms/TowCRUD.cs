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
    public partial class TowCRUD : MetroForm
    {
        private int idPrac;
        private string role;
        public TowCRUD(int idPrac, string role)
        {
            InitializeComponent();
            this.idPrac = idPrac;
            this.role = role;
        }

        private void TowCRUDcs_Load(object sender, EventArgs e)
        {
            Function toList = new Function();
            prod.Items.Clear();
            List<Tables.Prod> adr = toList.ToList<Tables.Prod>("http://localhost:8090/prod/all");
            foreach (var com in adr)
            {
                prod.Items.Add(com.idProd + " " + com.name);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            TowForm companyForm = new TowForm(this.idPrac, this.role);
            companyForm.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Function crud = new Function();


            if (createRadioButton.Checked)
            {
                string[] idAd = prod.SelectedItem.ToString().Split(' ');
                var postData = "name=" + Uri.EscapeDataString(name.Text);
                postData += "&nrSer=" + Uri.EscapeDataString(nrSer.Text);
                postData += "&dim=" + Uri.EscapeDataString(dim.Text);
                postData += "&idProd=" + Uri.EscapeDataString(idAd[0]);
                var msg = crud.PostReq("http://localhost:8090/tow/add", postData);
                ErrorForm errorForm = new ErrorForm(msg);
                errorForm.Show();
            }
            if (updateRadioButton.Checked)
            {
                string[] idAd = prod.SelectedItem.ToString().Split(' ');
                var postData = "id=" + Uri.EscapeDataString(idTow.Text);
                postData += "&name=" + Uri.EscapeDataString(name.Text);
                postData += "&nrSer=" + Uri.EscapeDataString(nrSer.Text);
                postData += "&dim=" + Uri.EscapeDataString(dim.Text);
                postData += "&idProd=" + Uri.EscapeDataString(idAd[0]);
                var msg = crud.PostReq("http://localhost:8090/tow/update", postData);
                ErrorForm errorForm = new ErrorForm(msg);
                errorForm.Show();
            }
            if (deleteRadioButton.Checked)
            {
                var postData = "id=" + Uri.EscapeDataString(idTow.Text);
                var msg = crud.PostReq("http://localhost:8090/tow/delete", postData);
                ErrorForm errorForm = new ErrorForm(msg);
                errorForm.Show();
            }
        }
    }
}
