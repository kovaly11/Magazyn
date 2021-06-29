
namespace Magazyn.Forms
{
    partial class AdresForm
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
            this.exitButton = new MetroFramework.Controls.MetroButton();
            this.listAdres = new System.Windows.Forms.ListView();
            this.IdAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.street = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.city = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pcode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(631, 379);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(117, 30);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "Exit";
            this.exitButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // listAdres
            // 
            this.listAdres.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdAd,
            this.street,
            this.number,
            this.city,
            this.pcode});
            this.listAdres.FullRowSelect = true;
            this.listAdres.GridLines = true;
            this.listAdres.HideSelection = false;
            this.listAdres.Location = new System.Drawing.Point(80, 84);
            this.listAdres.Name = "listAdres";
            this.listAdres.Size = new System.Drawing.Size(668, 207);
            this.listAdres.TabIndex = 14;
            this.listAdres.UseCompatibleStateImageBehavior = false;
            this.listAdres.View = System.Windows.Forms.View.Details;
            // 
            // IdAd
            // 
            this.IdAd.Text = "IdAd";
            this.IdAd.Width = 80;
            // 
            // street
            // 
            this.street.Text = "street";
            this.street.Width = 80;
            // 
            // number
            // 
            this.number.Text = "number";
            this.number.Width = 80;
            // 
            // city
            // 
            this.city.Text = "city";
            this.city.Width = 80;
            // 
            // pcode
            // 
            this.pcode.Text = "pcode";
            this.pcode.Width = 80;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(80, 379);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(4);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(117, 30);
            this.metroButton1.TabIndex = 15;
            this.metroButton1.Text = "Menu";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(341, 379);
            this.metroButton2.Margin = new System.Windows.Forms.Padding(4);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(117, 30);
            this.metroButton2.TabIndex = 16;
            this.metroButton2.Text = "CRUD";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // AdresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.listAdres);
            this.Controls.Add(this.exitButton);
            this.Name = "AdresForm";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Adresy";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Adresy_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton exitButton;
        private System.Windows.Forms.ListView listAdres;
        private System.Windows.Forms.ColumnHeader IdAd;
        private System.Windows.Forms.ColumnHeader street;
        private System.Windows.Forms.ColumnHeader number;
        private System.Windows.Forms.ColumnHeader city;
        private System.Windows.Forms.ColumnHeader pcode;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}