
namespace Magazyn.Forms
{
    partial class TowForm
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
            this.listTow = new System.Windows.Forms.ListView();
            this.idTow = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nazwa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nrSer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            // listTow
            // 
            this.listTow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idTow,
            this.nazwa,
            this.nrSer,
            this.dim,
            this.prod});
            this.listTow.FullRowSelect = true;
            this.listTow.GridLines = true;
            this.listTow.HideSelection = false;
            this.listTow.Location = new System.Drawing.Point(66, 89);
            this.listTow.Name = "listTow";
            this.listTow.Size = new System.Drawing.Size(668, 207);
            this.listTow.TabIndex = 20;
            this.listTow.UseCompatibleStateImageBehavior = false;
            this.listTow.View = System.Windows.Forms.View.Details;
            // 
            // idTow
            // 
            this.idTow.Text = "idTow";
            this.idTow.Width = 80;
            // 
            // nazwa
            // 
            this.nazwa.Text = "nazwa";
            this.nazwa.Width = 132;
            // 
            // nrSer
            // 
            this.nrSer.Text = "numer serijny";
            this.nrSer.Width = 131;
            // 
            // dim
            // 
            this.dim.Text = "wymiary";
            this.dim.Width = 132;
            // 
            // prod
            // 
            this.prod.Text = "producent";
            this.prod.Width = 184;
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
            this.metroButton2.Location = new System.Drawing.Point(330, 358);
            this.metroButton2.Margin = new System.Windows.Forms.Padding(4);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(117, 30);
            this.metroButton2.TabIndex = 22;
            this.metroButton2.Text = "CRUD";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // TowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.listTow);
            this.Controls.Add(this.exitButton);
            this.Name = "TowForm";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Towary";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Towform_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.ListView listTow;
        private System.Windows.Forms.ColumnHeader idTow;
        private System.Windows.Forms.ColumnHeader nazwa;
        private System.Windows.Forms.ColumnHeader nrSer;
        private System.Windows.Forms.ColumnHeader dim;
        private System.Windows.Forms.ColumnHeader prod;
        private MetroFramework.Controls.MetroButton exitButton;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}