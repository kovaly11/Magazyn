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
    public partial class TowForm : MetroForm
    {
        private int idPrac;
        private string role;
        public TowForm(int idPrac, string role)
        {
            InitializeComponent();
            this.idPrac = idPrac;
            this.role = role;
        }

        private void Towform_Load(object sender, EventArgs e)
        {
            listTow.Items.Clear();
            Function toList = new Function();
            List<Tables.Tow> company = toList.ToList<Tables.Tow>("http://localhost:8090/tow/all");
            foreach (var com in company)
            {
                var row = new string[] { com.idTow.ToString(), com.name, com.nrSer, com.dim, com.prod.name };
                var lvi = new ListViewItem(row);
                // lvi.Tag = adres;
                listTow.Items.Add(lvi);
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
                TowCRUD towCRUD = new TowCRUD(this.idPrac, this.role);
                towCRUD.Show();
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
