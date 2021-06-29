
namespace Magazyn.Forms
{
    partial class PozForm
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
            this.listPoz = new System.Windows.Forms.ListView();
            this.nrPoz = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tow = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.exitButton = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(66, 349);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(4);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(117, 30);
            this.metroButton1.TabIndex = 21;
            this.metroButton1.Text = "Back";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // listPoz
            // 
            this.listPoz.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nrPoz,
            this.tow,
            this.qty});
            this.listPoz.FullRowSelect = true;
            this.listPoz.GridLines = true;
            this.listPoz.HideSelection = false;
            this.listPoz.Location = new System.Drawing.Point(66, 83);
            this.listPoz.Name = "listPoz";
            this.listPoz.Size = new System.Drawing.Size(668, 207);
            this.listPoz.TabIndex = 20;
            this.listPoz.UseCompatibleStateImageBehavior = false;
            this.listPoz.View = System.Windows.Forms.View.Details;
            // 
            // nrPoz
            // 
            this.nrPoz.Text = "No";
            this.nrPoz.Width = 80;
            // 
            // tow
            // 
            this.tow.Text = "towar";
            this.tow.Width = 133;
            // 
            // qty
            // 
            this.qty.Text = "ilosc";
            this.qty.Width = 104;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(617, 349);
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
            this.metroButton2.Location = new System.Drawing.Point(333, 349);
            this.metroButton2.Margin = new System.Windows.Forms.Padding(4);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(117, 30);
            this.metroButton2.TabIndex = 22;
            this.metroButton2.Text = "CRUD";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // PozForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.listPoz);
            this.Controls.Add(this.exitButton);
            this.Name = "PozForm";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "PozForm";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.PozForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.ListView listPoz;
        private System.Windows.Forms.ColumnHeader nrPoz;
        private System.Windows.Forms.ColumnHeader tow;
        private System.Windows.Forms.ColumnHeader qty;
        private MetroFramework.Controls.MetroButton exitButton;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}