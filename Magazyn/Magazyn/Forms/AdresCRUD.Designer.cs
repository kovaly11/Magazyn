
namespace Magazyn.Forms
{
    partial class AdresCRUD
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
            this.exitButton = new MetroFramework.Controls.MetroButton();
            this.createRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.updateRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.deleteRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.idAd = new MetroFramework.Controls.MetroTextBox();
            this.city = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.number = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.pCode = new MetroFramework.Controls.MetroTextBox();
            this.street = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(66, 358);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(4);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(117, 30);
            this.metroButton1.TabIndex = 19;
            this.metroButton1.Text = "Back";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(617, 358);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(117, 30);
            this.exitButton.TabIndex = 17;
            this.exitButton.Text = "Ok";
            this.exitButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // createRadioButton
            // 
            this.createRadioButton.AutoSize = true;
            this.createRadioButton.Location = new System.Drawing.Point(83, 92);
            this.createRadioButton.Name = "createRadioButton";
            this.createRadioButton.Size = new System.Drawing.Size(62, 17);
            this.createRadioButton.Style = MetroFramework.MetroColorStyle.Purple;
            this.createRadioButton.TabIndex = 20;
            this.createRadioButton.TabStop = true;
            this.createRadioButton.Text = "Create";
            this.createRadioButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.createRadioButton.UseVisualStyleBackColor = true;
            // 
            // updateRadioButton
            // 
            this.updateRadioButton.AutoSize = true;
            this.updateRadioButton.Location = new System.Drawing.Point(323, 92);
            this.updateRadioButton.Name = "updateRadioButton";
            this.updateRadioButton.Size = new System.Drawing.Size(67, 17);
            this.updateRadioButton.Style = MetroFramework.MetroColorStyle.Purple;
            this.updateRadioButton.TabIndex = 21;
            this.updateRadioButton.TabStop = true;
            this.updateRadioButton.Text = "Update";
            this.updateRadioButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.updateRadioButton.UseVisualStyleBackColor = true;
            // 
            // deleteRadioButton
            // 
            this.deleteRadioButton.AutoSize = true;
            this.deleteRadioButton.Location = new System.Drawing.Point(617, 92);
            this.deleteRadioButton.Name = "deleteRadioButton";
            this.deleteRadioButton.Size = new System.Drawing.Size(61, 17);
            this.deleteRadioButton.Style = MetroFramework.MetroColorStyle.Purple;
            this.deleteRadioButton.TabIndex = 22;
            this.deleteRadioButton.TabStop = true;
            this.deleteRadioButton.Text = "Delete";
            this.deleteRadioButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.deleteRadioButton.UseVisualStyleBackColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(86, 180);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(50, 20);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel2.TabIndex = 25;
            this.metroLabel2.Text = "street";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(86, 143);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(42, 20);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel1.TabIndex = 24;
            this.metroLabel1.Text = "idAd";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseStyleColors = true;
            // 
            // idAd
            // 
            this.idAd.Location = new System.Drawing.Point(192, 135);
            this.idAd.Margin = new System.Windows.Forms.Padding(4);
            this.idAd.Name = "idAd";
            this.idAd.Size = new System.Drawing.Size(156, 28);
            this.idAd.TabIndex = 23;
            this.idAd.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(531, 180);
            this.city.Margin = new System.Windows.Forms.Padding(4);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(156, 28);
            this.city.TabIndex = 30;
            this.city.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(425, 180);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(34, 20);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel3.TabIndex = 29;
            this.metroLabel3.Text = "city";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(425, 143);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(64, 20);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel4.TabIndex = 28;
            this.metroLabel4.Text = "number";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel4.UseStyleColors = true;
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(531, 135);
            this.number.Margin = new System.Windows.Forms.Padding(4);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(156, 28);
            this.number.TabIndex = 27;
            this.number.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(86, 227);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(53, 20);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel5.TabIndex = 31;
            this.metroLabel5.Text = "pCode";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel5.UseStyleColors = true;
            // 
            // pCode
            // 
            this.pCode.Location = new System.Drawing.Point(192, 225);
            this.pCode.Margin = new System.Windows.Forms.Padding(4);
            this.pCode.Name = "pCode";
            this.pCode.Size = new System.Drawing.Size(156, 28);
            this.pCode.TabIndex = 33;
            this.pCode.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // street
            // 
            this.street.Location = new System.Drawing.Point(192, 180);
            this.street.Margin = new System.Windows.Forms.Padding(4);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(156, 28);
            this.street.TabIndex = 32;
            this.street.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // AdresCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pCode);
            this.Controls.Add(this.street);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.city);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.number);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.idAd);
            this.Controls.Add(this.deleteRadioButton);
            this.Controls.Add(this.updateRadioButton);
            this.Controls.Add(this.createRadioButton);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.exitButton);
            this.Name = "AdresCRUD";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "AdresCRUD";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.AdresCRUD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton exitButton;
        private MetroFramework.Controls.MetroRadioButton createRadioButton;
        private MetroFramework.Controls.MetroRadioButton updateRadioButton;
        private MetroFramework.Controls.MetroRadioButton deleteRadioButton;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox idAd;
        private MetroFramework.Controls.MetroTextBox city;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox number;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox pCode;
        private MetroFramework.Controls.MetroTextBox street;
    }
}