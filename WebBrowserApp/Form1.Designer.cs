
namespace WebBrowserApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.status = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.historyPanel = new System.Windows.Forms.Panel();
            this.favoritePanel = new System.Windows.Forms.Panel();
            this.historyButton = new System.Windows.Forms.Button();
            this.favoriteButton = new System.Windows.Forms.Button();
            this.downloadButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.downloadPanel = new System.Windows.Forms.Panel();
            this.bulkDownload = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.downloadPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(650, 84);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(119, 20);
            this.status.TabIndex = 1;
            this.status.Text = "Status: Loading...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(11, 118);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1311, 646);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(255, 12);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(677, 27);
            this.searchBox.TabIndex = 4;
            this.searchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchBox_KeyPress);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(11, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Reload";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.reload);
            // 
            // homeButton
            // 
            this.homeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeButton.Location = new System.Drawing.Point(111, 12);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(94, 29);
            this.homeButton.TabIndex = 6;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click_1);
            // 
            // historyPanel
            // 
            this.historyPanel.BackColor = System.Drawing.Color.White;
            this.historyPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.historyPanel.Location = new System.Drawing.Point(938, 50);
            this.historyPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.historyPanel.Name = "historyPanel";
            this.historyPanel.Size = new System.Drawing.Size(186, 513);
            this.historyPanel.TabIndex = 7;
            this.historyPanel.Visible = false;
            // 
            // favoritePanel
            // 
            this.favoritePanel.BackColor = System.Drawing.Color.White;
            this.favoritePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.favoritePanel.Location = new System.Drawing.Point(1030, 50);
            this.favoritePanel.Name = "favoritePanel";
            this.favoritePanel.Size = new System.Drawing.Size(194, 513);
            this.favoritePanel.TabIndex = 13;
            this.favoritePanel.Visible = false;
            // 
            // historyButton
            // 
            this.historyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.historyButton.Location = new System.Drawing.Point(938, 12);
            this.historyButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(86, 29);
            this.historyButton.TabIndex = 8;
            this.historyButton.Text = "History";
            this.historyButton.UseVisualStyleBackColor = true;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // favoriteButton
            // 
            this.favoriteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.favoriteButton.Location = new System.Drawing.Point(1030, 12);
            this.favoriteButton.Name = "favoriteButton";
            this.favoriteButton.Size = new System.Drawing.Size(94, 29);
            this.favoriteButton.TabIndex = 9;
            this.favoriteButton.Text = "Favorites";
            this.favoriteButton.UseVisualStyleBackColor = true;
            this.favoriteButton.Click += new System.EventHandler(this.favoriteButton_Click);
            // 
            // downloadButton
            // 
            this.downloadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.downloadButton.Location = new System.Drawing.Point(1130, 12);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(94, 29);
            this.downloadButton.TabIndex = 10;
            this.downloadButton.Text = "Dowload";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsButton.Location = new System.Drawing.Point(1230, 12);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(94, 29);
            this.settingsButton.TabIndex = 11;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "URL:";
            // 
            // downloadPanel
            // 
            this.downloadPanel.BackColor = System.Drawing.Color.White;
            this.downloadPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.downloadPanel.Controls.Add(this.bulkDownload);
            this.downloadPanel.Controls.Add(this.label4);
            this.downloadPanel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.downloadPanel.Location = new System.Drawing.Point(1130, 50);
            this.downloadPanel.Name = "downloadPanel";
            this.downloadPanel.Size = new System.Drawing.Size(135, 63);
            this.downloadPanel.TabIndex = 14;
            this.downloadPanel.Visible = false;
            // 
            // bulkDownload
            // 
            this.bulkDownload.AutoSize = true;
            this.bulkDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bulkDownload.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bulkDownload.Location = new System.Drawing.Point(3, 15);
            this.bulkDownload.Name = "bulkDownload";
            this.bulkDownload.Size = new System.Drawing.Size(111, 20);
            this.bulkDownload.TabIndex = 0;
            this.bulkDownload.Text = "Bulk Dowload...";
            this.bulkDownload.Click += new System.EventHandler(this.bulkDownload_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Location:";
            // 
            // settingsPanel
            // 
            this.settingsPanel.BackColor = System.Drawing.Color.White;
            this.settingsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.settingsPanel.Location = new System.Drawing.Point(1169, 50);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(155, 315);
            this.settingsPanel.TabIndex = 17;
            this.settingsPanel.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "label3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 776);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.downloadPanel);
            this.Controls.Add(this.favoritePanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.favoriteButton);
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.historyPanel);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.status);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MSBrowser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.downloadPanel.ResumeLayout(false);
            this.downloadPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Panel historyPanel;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favoritesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bulkDownloadToolStripMenuItem;
        private System.Windows.Forms.Button favoriteButton;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel favoritePanel;
        private System.Windows.Forms.Panel downloadPanel;
        private System.Windows.Forms.Label bulkDownload;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.Label label5;
    }
}

