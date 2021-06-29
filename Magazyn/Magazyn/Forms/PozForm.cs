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
    public partial class PozForm : MetroForm
    {
        private int idDok;
        private int idPrac;
        private string role;
        public PozForm(int idPrac, string role, int idDok)
        {
            InitializeComponent();
            this.idDok = idDok;
            this.idPrac = idPrac;
            this.role = role;
        }

        private void PozForm_Load(object sender, EventArgs e)
        {
            this.Text = "Dokument " + this.idDok;
            listPoz.Items.Clear();
            Function toList = new Function();
            List<Tables.Poz> poz = toList.ToList<Tables.Poz>($"http://localhost:8090/poz/{this.idDok}"); ;
            foreach (var com in poz)
            {
                var row = new string[] { com.nrPoz.ToString(), com.tow.name, com.qty.ToString()};
                var lvi = new ListViewItem(row);
                // lvi.Tag = adres;
                listPoz.Items.Add(lvi);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DokForm dokForm = new DokForm(this.idPrac, this.role);
            dokForm.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (this.role == "admin")
            {
                PozCRUD pozCRUD = new PozCRUD(this.idPrac, this.role, this.idDok);
                pozCRUD.Show();
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
