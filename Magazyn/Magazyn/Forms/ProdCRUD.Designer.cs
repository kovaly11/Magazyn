
namespace Magazyn.Forms
{
    partial class ProdCRUD
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
            this.adres = new MetroFramework.Controls.MetroComboBox();
            this.person = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.tel = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.name = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.idCom = new MetroFramework.Controls.MetroTextBox();
            this.deleteRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.updateRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.createRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.exitButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // adres
            // 
            this.adres.FormattingEnabled = true;
            this.adres.ItemHeight = 24;
            this.adres.Location = new System.Drawing.Point(192, 212);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(156, 30);
            this.adres.TabIndex = 64;
            // 
            // person
            // 
            this.person.Location = new System.Drawing.Point(192, 165);
            this.person.Margin = new System.Windows.Forms.Padding(4);
            this.person.Name = "person";
            this.person.Size = new System.Drawing.Size(156, 28);
            this.person.TabIndex = 63;
            this.person.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(86, 222);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(47, 20);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel5.TabIndex = 62;
            this.metroLabel5.Text = "adres";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel5.UseStyleColors = true;
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(531, 165);
            this.tel.Margin = new System.Windows.Forms.Padding(4);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(156, 28);
            this.tel.TabIndex = 61;
            this.tel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(425, 165);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(59, 20);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel3.TabIndex = 60;
            this.metroLabel3.Text = "telefon";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(425, 128);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(48, 20);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel4.TabIndex = 59;
            this.metroLabel4.Text = "name";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel4.UseStyleColors = true;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(531, 120);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(156, 28);
            this.name.TabIndex = 58;
            this.name.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(86, 165);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(57, 20);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel2.TabIndex = 57;
            this.metroLabel2.Text = "person";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(86, 128);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(54, 20);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel1.TabIndex = 56;
            this.metroLabel1.Text = "idCom";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseStyleColors = true;
            // 
            // idCom
            // 
            this.idCom.Location = new System.Drawing.Point(192, 120);
            this.idCom.Margin = new System.Windows.Forms.Padding(4);
            this.idCom.Name = "idCom";
            this.idCom.Size = new System.Drawing.Size(156, 28);
            this.idCom.TabIndex = 55;
            this.idCom.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // deleteRadioButton
            // 
            this.deleteRadioButton.AutoSize = true;
            this.deleteRadioButton.Location = new System.Drawing.Point(617, 77);
            this.deleteRadioButton.Name = "deleteRadioButton";
            this.deleteRadioButton.Size = new System.Drawing.Size(61, 17);
            this.deleteRadioButton.Style = MetroFramework.MetroColorStyle.Purple;
            this.deleteRadioButton.TabIndex = 54;
            this.deleteRadioButton.TabStop = true;
            this.deleteRadioButton.Text = "Delete";
            this.deleteRadioButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.deleteRadioButton.UseVisualStyleBackColor = true;
            // 
            // updateRadioButton
            // 
            this.updateRadioButton.AutoSize = true;
            this.updateRadioButton.Location = new System.Drawing.Point(323, 77);
            this.updateRadioButton.Name = "updateRadioButton";
            this.updateRadioButton.Size = new System.Drawing.Size(67, 17);
            this.updateRadioButton.Style = MetroFramework.MetroColorStyle.Purple;
            this.updateRadioButton.TabIndex = 53;
            this.updateRadioButton.TabStop = true;
            this.updateRadioButton.Text = "Update";
            this.updateRadioButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.updateRadioButton.UseVisualStyleBackColor = true;
            // 
            // createRadioButton
            // 
            this.createRadioButton.AutoSize = true;
            this.createRadioButton.Location = new System.Drawing.Point(83, 77);
            this.createRadioButton.Name = "createRadioButton";
            this.createRadioButton.Size = new System.Drawing.Size(62, 17);
            this.createRadioButton.Style = MetroFramework.MetroColorStyle.Purple;
            this.createRadioButton.TabIndex = 52;
            this.createRadioButton.TabStop = true;
            this.createRadioButton.Text = "Create";
            this.createRadioButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.createRadioButton.UseVisualStyleBackColor = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(66, 343);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(4);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(117, 30);
            this.metroButton1.TabIndex = 51;
            this.metroButton1.Text = "Back";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(617, 343);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(117, 30);
            this.exitButton.TabIndex = 50;
            this.exitButton.Text = "Ok";
            this.exitButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // ProdCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.adres);
            this.Controls.Add(this.person);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.name);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.idCom);
            this.Controls.Add(this.deleteRadioButton);
            this.Controls.Add(this.updateRadioButton);
            this.Controls.Add(this.createRadioButton);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.exitButton);
            this.Name = "ProdCRUD";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "ProdCRUD";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.ProdCRUD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox adres;
        private MetroFramework.Controls.MetroTextBox person;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox tel;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox name;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox idCom;
        private MetroFramework.Controls.MetroRadioButton deleteRadioButton;
        private MetroFramework.Controls.MetroRadioButton updateRadioButton;
        private MetroFramework.Controls.MetroRadioButton createRadioButton;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton exitButton;
    }
}