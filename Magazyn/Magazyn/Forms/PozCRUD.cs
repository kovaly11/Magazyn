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
    public partial class PozCRUD : MetroForm
    {
        private int idPrac;
        private string role;
        private int idDok;
        public PozCRUD(int idPrac, string role, int idDok)
        {
            InitializeComponent();
            this.idDok = idDok;
            this.idPrac = idPrac;
            this.role = role;
        }

        private void PozCRUD_Load(object sender, EventArgs e)
        {
            Function toList = new Function();
            tow.Items.Clear();
            List<Tables.Tow> tows = toList.ToList<Tables.Tow>("http://localhost:8090/tow/all");
            foreach (var com in tows)
            {
                tow.Items.Add(com.idTow + " " + com.name);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            PozForm pozForm = new PozForm(this.idPrac, this.role, this.idDok);
            pozForm.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Function crud = new Function();


            if (createRadioButton.Checked)
            {
                string[] idTow = tow.SelectedItem.ToString().Split(' ');
                var postData = "idTow=" + Uri.EscapeDataString(idTow[0]);
                postData += "&idDok=" + Uri.EscapeDataString(this.idDok.ToString());
                postData += "&qty=" + Uri.EscapeDataString(qty.Text);
                var msg = crud.PostReq("http://localhost:8090/poz/add", postData);
                ErrorForm errorForm = new ErrorForm(msg);
                errorForm.Show();
            }
            if (updateRadioButton.Checked)
            {
                string[] idTow = tow.SelectedItem.ToString().Split(' ');
                var postData = "idTow=" + Uri.EscapeDataString(idTow[0]);
                postData += "&idDok=" + Uri.EscapeDataString(this.idDok.ToString());
                postData += "&qty=" + Uri.EscapeDataString(qty.Text);
                postData += "&nrPoz=" + Uri.EscapeDataString(nrPoz.Text);
                var msg = crud.PostReq("http://localhost:8090/poz/update", postData);
                ErrorForm errorForm = new ErrorForm(msg);
                errorForm.Show();
            }
            if (deleteRadioButton.Checked)
            {
                
                var postData = "nrPoz=" + Uri.EscapeDataString(nrPoz.Text);
                postData += "&idDok=" + Uri.EscapeDataString(this.idDok.ToString());
                var msg = crud.PostReq("http://localhost:8090/poz/delete", postData);
                ErrorForm errorForm = new ErrorForm(msg);
                errorForm.Show();
            }
        }
    }
}
