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
    public partial class DokForm : MetroForm
    {
        private int idPrac;
        private string role;
        public DokForm(int idPrac, string role)
        {
            InitializeComponent();
            this.idPrac = idPrac;
            this.role = role;
        }

        private void DokForm_Load(object sender, EventArgs e)
        {
            listDok.Items.Clear();
            Function toList = new Function();
            List<Tables.Dok> doks = toList.ToList<Tables.Dok>("http://localhost:8090/dok/all");
            foreach (var com in doks)
            {
                var row = new string[] { com.idDok.ToString(), com.prac.imie + " " + com.prac.nazw, com.company.name, com.tdok, com.data.ToString() };
                var lvi = new ListViewItem(row);
                // lvi.Tag = adres;
                comboBox1.Items.Add(com.idDok);
                listDok.Items.Add(lvi);
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
            PozForm pozForm = new PozForm(this.idPrac, this.role, Int32.Parse(comboBox1.SelectedItem.ToString()));
            pozForm.Show();
            this.Hide();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (this.role == "admin")
            {
                DokCRUD dokCRUD = new DokCRUD(this.idPrac, this.role);
                dokCRUD.Show();
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
