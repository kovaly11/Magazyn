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
    public partial class AdresForm : MetroForm
    {
        private int idPrac;
        private string role;
        public AdresForm(int idPrac, string role)
        {
            InitializeComponent();
            this.idPrac = idPrac;
            this.role = role;
        }

        private void Adresy_Load(object sender, EventArgs e)
        {
            listAdres.Items.Clear();
            Function toList = new Function();
            List<Adres> adresy = toList.ToList<Adres>("http://localhost:8090/adres/all");
            foreach (var adres in adresy)
            {
                var row = new string[] { adres.idAd.ToString(), adres.street, adres.number, adres.city, adres.pcode };
                var lvi = new ListViewItem(row);
               //lvi.Tag = adres;
                listAdres.Items.Add(lvi);
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
                AdresCRUD adresCRUD = new AdresCRUD(this.idPrac, this.role);
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
