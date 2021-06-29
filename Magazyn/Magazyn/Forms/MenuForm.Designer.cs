
namespace Magazyn.Forms
{
    partial class MenuForm
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
            this.accessLabel = new MetroFramework.Controls.MetroLabel();
            this.exitButton = new MetroFramework.Controls.MetroButton();
            this.adresyButton = new MetroFramework.Controls.MetroButton();
            this.companyButton = new MetroFramework.Controls.MetroButton();
            this.prodButton = new MetroFramework.Controls.MetroButton();
            this.towarButton = new MetroFramework.Controls.MetroButton();
            this.dokButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // accessLabel
            // 
            this.accessLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.accessLabel.Location = new System.Drawing.Point(24, 371);
            this.accessLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accessLabel.Name = "accessLabel";
            this.accessLabel.Size = new System.Drawing.Size(460, 24);
            this.accessLabel.Style = MetroFramework.MetroColorStyle.Purple;
            this.accessLabel.TabIndex = 11;
            this.accessLabel.Text = "Password";
            this.accessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accessLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.accessLabel.UseStyleColors = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(426, 371);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(117, 30);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Exit";
            this.exitButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // adresyButton
            // 
            this.adresyButton.Location = new System.Drawing.Point(171, 81);
            this.adresyButton.Margin = new System.Windows.Forms.Padding(4);
            this.adresyButton.Name = "adresyButton";
            this.adresyButton.Size = new System.Drawing.Size(218, 34);
            this.adresyButton.TabIndex = 13;
            this.adresyButton.Text = "Adresy";
            this.adresyButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.adresyButton.Click += new System.EventHandler(this.adresyButton_Click);
            // 
            // companyButton
            // 
            this.companyButton.Location = new System.Drawing.Point(171, 132);
            this.companyButton.Margin = new System.Windows.Forms.Padding(4);
            this.companyButton.Name = "companyButton";
            this.companyButton.Size = new System.Drawing.Size(218, 34);
            this.companyButton.TabIndex = 14;
            this.companyButton.Text = "Company";
            this.companyButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.companyButton.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // prodButton
            // 
            this.prodButton.Location = new System.Drawing.Point(171, 184);
            this.prodButton.Margin = new System.Windows.Forms.Padding(4);
            this.prodButton.Name = "prodButton";
            this.prodButton.Size = new System.Drawing.Size(218, 34);
            this.prodButton.TabIndex = 15;
            this.prodButton.Text = "Producenty";
            this.prodButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.prodButton.Click += new System.EventHandler(this.prodButton_Click);
            // 
            // towarButton
            // 
            this.towarButton.Location = new System.Drawing.Point(171, 236);
            this.towarButton.Margin = new System.Windows.Forms.Padding(4);
            this.towarButton.Name = "towarButton";
            this.towarButton.Size = new System.Drawing.Size(218, 34);
            this.towarButton.TabIndex = 16;
            this.towarButton.Text = "Towary";
            this.towarButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.towarButton.Click += new System.EventHandler(this.towarButton_Click);
            // 
            // dokButton
            // 
            this.dokButton.Location = new System.Drawing.Point(171, 287);
            this.dokButton.Margin = new System.Windows.Forms.Padding(4);
            this.dokButton.Name = "dokButton";
            this.dokButton.Size = new System.Drawing.Size(218, 34);
            this.dokButton.TabIndex = 17;
            this.dokButton.Text = "Dokumenty";
            this.dokButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dokButton.Click += new System.EventHandler(this.dokButton_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 425);
            this.ControlBox = false;
            this.Controls.Add(this.dokButton);
            this.Controls.Add(this.towarButton);
            this.Controls.Add(this.prodButton);
            this.Controls.Add(this.companyButton);
            this.Controls.Add(this.adresyButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.accessLabel);
            this.Name = "MenuForm";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "MenuForm";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel accessLabel;
        private MetroFramework.Controls.MetroButton exitButton;
        private MetroFramework.Controls.MetroButton adresyButton;
        private MetroFramework.Controls.MetroButton companyButton;
        private MetroFramework.Controls.MetroButton prodButton;
        private MetroFramework.Controls.MetroButton towarButton;
        private MetroFramework.Controls.MetroButton dokButton;
    }
}