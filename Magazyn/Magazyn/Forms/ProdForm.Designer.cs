
namespace Magazyn.Forms
{
    partial class ProdForm
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
            this.listProd = new System.Windows.Forms.ListView();
            this.idProd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.person = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.metroButton1.TabIndex = 21;
            this.metroButton1.Text = "Menu";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // listProd
            // 
            this.listProd.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idProd,
            this.name,
            this.person,
            this.tel,
            this.adres});
            this.listProd.FullRowSelect = true;
            this.listProd.GridLines = true;
            this.listProd.HideSelection = false;
            this.listProd.Location = new System.Drawing.Point(66, 87);
            this.listProd.Name = "listProd";
            this.listProd.Size = new System.Drawing.Size(668, 207);
            this.listProd.TabIndex = 20;
            this.listProd.UseCompatibleStateImageBehavior = false;
            this.listProd.View = System.Windows.Forms.View.Details;
            // 
            // idProd
            // 
            this.idProd.Text = "idProd";
            this.idProd.Width = 80;
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
            // tel
            // 
            this.tel.Text = "telefon";
            this.tel.Width = 132;
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
            this.exitButton.TabIndex = 19;
            this.exitButton.Text = "Exit";
            this.exitButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(336, 358);
            this.metroButton2.Margin = new System.Windows.Forms.Padding(4);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(117, 30);
            this.metroButton2.TabIndex = 22;
            this.metroButton2.Text = "CRUD";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // ProdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.listProd);
            this.Controls.Add(this.exitButton);
            this.Name = "ProdForm";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Producenty";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.ProdForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.ListView listProd;
        private System.Windows.Forms.ColumnHeader idProd;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader person;
        private System.Windows.Forms.ColumnHeader tel;
        private System.Windows.Forms.ColumnHeader adres;
        private MetroFramework.Controls.MetroButton exitButton;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}