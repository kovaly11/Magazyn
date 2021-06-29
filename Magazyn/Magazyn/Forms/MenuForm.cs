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
    public partial class MenuForm : MetroForm
    {
        private int idPrac;
        private string role;
        public MenuForm(int idPrac)
        {
            InitializeComponent();
            this.idPrac = idPrac;
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            Function toEntity = new Function();
            Prac prac = toEntity.ToEntity<Prac>("http://localhost:8090/prac/"+idPrac);
            this.Text = "Hello " + prac.imie + " " + prac.nazw;
            this.role = prac.role;
            if(prac.role=="admin")
            {
                accessLabel.Text = "access to administrator functions";
            }
            else
            {
                accessLabel.Text = "No access to administrator functions";
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void adresyButton_Click(object sender, EventArgs e)
        {
            AdresForm adresForm = new AdresForm(this.idPrac, this.role);
            adresForm.Show();
            this.Hide();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            CompanyForm companyForm = new CompanyForm(this.idPrac, this.role);
            companyForm.Show();
            this.Hide();
        }

        private void prodButton_Click(object sender, EventArgs e)
        {
            ProdForm prodForm = new ProdForm(this.idPrac, this.role);
            prodForm.Show();
            this.Hide();
        }

        private void towarButton_Click(object sender, EventArgs e)
        {
            TowForm towForm = new TowForm(this.idPrac, this.role);
            towForm.Show();
            this.Hide();
        }

        private void dokButton_Click(object sender, EventArgs e)
        {
            DokForm dokForm = new DokForm(this.idPrac, this.role);
            dokForm.Show();
            this.Hide();
        }
    }
}
