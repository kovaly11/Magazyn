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
    public partial class ProdForm : MetroForm
    {
        private int idPrac;
        private string role;
        public ProdForm(int idPrac, string role)
        {
            InitializeComponent();
            this.idPrac = idPrac;
            this.role = role;
        }

        private void ProdForm_Load(object sender, EventArgs e)
        {
            listProd.Items.Clear();
            Function toList = new Function();
            List<Tables.Prod> producenty = toList.ToList<Tables.Prod>("http://localhost:8090/prod/all");
            foreach (var com in producenty)
            {
                var row = new string[] { com.idProd.ToString(), com.name, com.person, com.tel, com.adres.street + " " + com.adres.number };
                var lvi = new ListViewItem(row);
                // lvi.Tag = adres;
                listProd.Items.Add(lvi);
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
                ProdCRUD adresCRUD = new ProdCRUD(this.idPrac, this.role);
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
