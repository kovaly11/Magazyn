
namespace Magazyn.Forms
{
    partial class CompanyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.listCompany = new System.Windows.Forms.ListView();
            this.idCom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.person = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.exitButton = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(66, 358);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(4);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(117, 30);
            this.metroButton1.TabIndex = 18;
            this.metroButton1.Text = "Menu";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // listCompany
            // 
            this.listCompany.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idCom,
            this.name,
            this.person,
            this.nip,
            this.adres});
            this.listCompany.FullRowSelect = true;
            this.listCompany.GridLines = true;
            this.listCompany.HideSelection = false;
            this.listCompany.Location = new System.Drawing.Point(66, 81);
            this.listCompany.Name = "listCompany";
            this.listCompany.Size = new System.Drawing.Size(668, 207);
            this.listCompany.TabIndex = 17;
            this.listCompany.UseCompatibleStateImageBehavior = false;
            this.listCompany.View = System.Windows.Forms.View.Details;
            // 
            // idCom
            // 
            this.idCom.Text = "idCom";
            this.idCom.Width = 80;
            // 
            // name
            // 
            this.name.Text = "name";
            this.name.Width = 132;
            // 
            // person
            // 
            this.person.Text = "person";
            this.person.Width = 131;
            // 
            // nip
            // 
            this.nip.Text = "nip";
            this.nip.Width = 132;
            // 
            // adres
            // 
            this.adres.Text = "adres";
            this.adres.Width = 184;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(617, 358);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(117, 30);
            this.exitButton.TabIndex = 16;
            this.exitButton.Text = "Exit";
            this.exitButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(344, 358);
            this.metroButton2.Margin = new System.Windows.Forms.Padding(4);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(117, 30);
            this.metroButton2.TabIndex = 19;
            this.metroButton2.Text = "CRUD";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // CompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.listCompany);
            this.Controls.Add(this.exitButton);
            this.Name = "CompanyForm";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Company";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.CompanyForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.ListView listCompany;
        private System.Windows.Forms.ColumnHeader idCom;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader person;
        private System.Windows.Forms.ColumnHeader nip;
        private System.Windows.Forms.ColumnHeader adres;
        private MetroFramework.Controls.MetroButton exitButton;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}