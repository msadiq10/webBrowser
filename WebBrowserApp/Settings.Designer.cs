
namespace WebBrowserApp
{
    partial class Settings
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
            this.setHome = new System.Windows.Forms.Label();
            this.addToFavorites = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // setHome
            // 
            this.setHome.AutoSize = true;
            this.setHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setHome.Location = new System.Drawing.Point(12, 9);
            this.setHome.Name = "setHome";
            this.setHome.Size = new System.Drawing.Size(127, 20);
            this.setHome.TabIndex = 0;
            this.setHome.Text = "Set as Homepage";
            this.setHome.Click += new System.EventHandler(this.setHome_Click);
            // 
            // addToFavorites
            // 
            this.addToFavorites.AutoSize = true;
            this.addToFavorites.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addToFavorites.Location = new System.Drawing.Point(12, 39);
            this.addToFavorites.Name = "addToFavorites";
            this.addToFavorites.Size = new System.Drawing.Size(117, 20);
            this.addToFavorites.TabIndex = 1;
            this.addToFavorites.Text = "Add to Favorites";
            this.addToFavorites.Click += new System.EventHandler(this.addToFavorites_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(148, 268);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addToFavorites);
            this.Controls.Add(this.setHome);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label setHome;
        private System.Windows.Forms.Label addToFavorites;
        private System.Windows.Forms.Label label1;
    }
}