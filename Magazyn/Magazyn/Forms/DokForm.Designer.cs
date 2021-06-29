
namespace Magazyn.Forms
{
    partial class DokForm
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
            this.listDok = new System.Windows.Forms.ListView();
            this.idDok = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prac = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.company = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tdok = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.exitButton = new MetroFramework.Controls.MetroButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(66, 358);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(4);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(117, 30);
            this.metroButton1.TabIndex = 24;
            this.metroButton1.Text = "Menu";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // listDok
            // 
            this.listDok.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idDok,
            this.prac,
            this.company,
            this.tdok,
            this.data});
            this.listDok.FullRowSelect = true;
            this.listDok.GridLines = true;
            this.listDok.HideSelection = false;
            this.listDok.Location = new System.Drawing.Point(66, 82);
            this.listDok.Name = "listDok";
            this.listDok.Size = new System.Drawing.Size(668, 207);
            this.listDok.TabIndex = 23;
            this.listDok.UseCompatibleStateImageBehavior = false;
            this.listDok.View = System.Windows.Forms.View.Details;
            // 
            // idDok
            // 
            this.idDok.Text = "idDok";
            this.idDok.Width = 80;
            // 
            // prac
            // 
            this.prac.Text = "pracownik";
            this.prac.Width = 177;
            // 
            // company
            // 
            this.company.Text = "company";
            this.company.Width = 189;
            // 
            // tdok
            // 
            this.tdok.Text = "typ";
            this.tdok.Width = 53;
            // 
            // data
            // 
            this.data.Text = "data";
            this.data.Width = 150;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(617, 358);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(117, 30);
            this.exitButton.TabIndex = 22;
            this.exitButton.Text = "Exit";
            this.exitButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(287, 295);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(69, 24);
            this.comboBox1.TabIndex = 25;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(75, 299);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(140, 20);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel1.TabIndex = 26;
            this.metroLabel1.Text = "Dokument with Id:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(407, 295);
            this.metroButton2.Margin = new System.Windows.Forms.Padding(4);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(117, 30);
            this.metroButton2.TabIndex = 27;
            this.metroButton2.Text = "Select";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(322, 358);
            this.metroButton3.Margin = new System.Windows.Forms.Padding(4);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(117, 30);
            this.metroButton3.TabIndex = 28;
            this.metroButton3.Text = "CRUD";
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // DokForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.listDok);
            this.Controls.Add(this.exitButton);
            this.Name = "DokForm";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Dokumenty";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.DokForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.ListView listDok;
        private System.Windows.Forms.ColumnHeader idDok;
        private System.Windows.Forms.ColumnHeader tdok;
        private System.Windows.Forms.ColumnHeader company;
        private System.Windows.Forms.ColumnHeader prac;
        private MetroFramework.Controls.MetroButton exitButton;
        private System.Windows.Forms.ColumnHeader data;
        private System.Windows.Forms.ComboBox comboBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
    }
}