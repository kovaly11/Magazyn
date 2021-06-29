
namespace Magazyn.Forms
{
    partial class ErrorForm
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
            this.errorLabel = new MetroFramework.Controls.MetroLabel();
            this.okButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // errorLabel
            // 
            this.errorLabel.AllowDrop = true;
            this.errorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.errorLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.errorLabel.Location = new System.Drawing.Point(37, 63);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(381, 89);
            this.errorLabel.Style = MetroFramework.MetroColorStyle.Purple;
            this.errorLabel.TabIndex = 10;
            this.errorLabel.Text = "Error";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errorLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.errorLabel.UseStyleColors = true;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(168, 178);
            this.okButton.Margin = new System.Windows.Forms.Padding(4);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(100, 28);
            this.okButton.TabIndex = 11;
            this.okButton.Text = "Ok";
            this.okButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // ErrorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 245);
            this.ControlBox = false;
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.errorLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "ErrorForm";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Message";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.ErrorForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel errorLabel;
        private MetroFramework.Controls.MetroButton okButton;
    }
}