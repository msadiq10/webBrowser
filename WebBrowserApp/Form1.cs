﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowserApp
{
    public partial class Form1 : Form
    {
        string url = ""; // homepage
        int countH = 0;
        int countF = 0;
        int countD = 0;


        public Form1()
        {
            InitializeComponent();
        }

        public string searchText { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            home();
            load();
        }

        private void home()
        {
            string temp = "";
            StreamReader sr1 = new StreamReader(System.IO.Path.GetFullPath("home.txt").ToString().Replace((char)92, (char)47).Replace("/bin/Debug/netcoreapp3.1/", "/txtfiles/"));
            temp = sr1.ReadLine();
            if (temp != null)
                url = temp;
            sr1.Close();
            searchBox.Text = url;
            searchText = searchBox.Text.ToString();
        }

        private async Task load()
        {
            using var client = new HttpClient();
            string temp1 = "";
            if(url == "")
                url = searchBox.Text;
            //searchBox.Text = url;
            searchText = searchBox.Text.ToString();
            label3.Text = searchText;
            string urlNotFound = "http://www.macs.hw.ac.uk/~hwloidl/Courses/F21SC/httpstat.us/404";

            var result = await client.GetAsync(url);
            richTextBox1.Text = "Loading...";

            if (result.StatusCode.ToString().Equals("BadRequest"))
            {
                status.Text = "Error: Bad Request!";
                richTextBox1.Text = "";
            }
            else if (result.StatusCode.ToString().Equals("Forbidden"))
            {
                status.Text = "Error: Forbidden!";
                richTextBox1.Text = "";
            }
            else if (result.StatusCode.ToString().Equals("NotFound"))
            {
                status.Text = "Error: Not found!";
                richTextBox1.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                richTextBox1.Text = "ERROR 404: NOT FOUND";
            }
            else
            {
                status.Text = "Status: "+result.StatusCode.ToString();
                richTextBox1.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                var content = await client.GetStringAsync(url);

                richTextBox1.Text = content;
            }
            try
            {
                temp1 = System.IO.Path.GetFullPath("home.txt").ToString().Replace((char)92, (char)47).Replace("/bin/Debug/netcoreapp3.1/","/txtfiles/");
                label5.Text = temp1;
            }
            catch(Exception e)
            {
                label5.Text = e.Message.ToString();
            }
        }

        private void reload(object sender, EventArgs e)
        {
            url = searchBox.Text;
            load();
            settingsPanel.Visible = false;
            downloadPanel.Visible = false;
            historyPanel.Visible = false;
            favoritePanel.Visible = false;
        }

        private void searchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                url = searchBox.Text;
                load();
            }
        }

        private void homeButton_Click_1(object sender, EventArgs e)
        {
            settingsPanel.Visible = false;
            downloadPanel.Visible = false;
            historyPanel.Visible = false;
            favoritePanel.Visible = false;
            home();
            load();
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            if(historyPanel.Visible == false)
            {
                historyPanel.Visible = true;
                History historyForm = new History() { TopLevel = false};
                historyForm.FormBorderStyle = FormBorderStyle.None;
                historyPanel.Controls.Add(historyForm);
                historyForm.Show();
                favoritePanel.Visible = false;
                downloadPanel.Visible = false;
                settingsPanel.Visible = false;
            }
            else
            {
                historyPanel.Visible = false;
            }
        }

        private void favoriteButton_Click(object sender, EventArgs e)
        {
            if (favoritePanel.Visible == false)
            {
                favoritePanel.Visible = true;
                Favorites favoritesForm = new Favorites() { TopLevel = false };
                favoritesForm.FormBorderStyle = FormBorderStyle.None;
                favoritePanel.Controls.Add(favoritesForm);
                favoritesForm.Show();
                historyPanel.Visible = false;
                downloadPanel.Visible = false;
                settingsPanel.Visible = false;
            }
            else
            {
                favoritePanel.Visible = false;
            }
        }

        private void bulkDownload_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select file to be upload.";
            openFileDialog1.Filter = "Select Valid Document(*.txt)|*.txt";
            openFileDialog1.ShowDialog();
            string path = System.IO.Path.GetFullPath(openFileDialog1.FileName);
            label4.Text = label4.Text + " " + path;
            download(path);
        }

        private async Task download(string p)
        {
            downloadPanel.Visible = false;
            using var client = new HttpClient();
            StreamReader sr = new StreamReader(p);
            string link = "";
            richTextBox1.Text = "";
            var lineCount = File.ReadLines(p).Count();
            var countStep = 0;
            while ((link = sr.ReadLine()) != null)
            {
                countStep += 1;
                richTextBox1.Text = richTextBox1.Text+"Loading..." + "(" +countStep.ToString() + "/" + lineCount.ToString()+")" +"\n";
                var result = await client.GetAsync(link);
                if (result.StatusCode.ToString().Equals("OK"))
                {
                    var bytes = await client.GetByteArrayAsync(link);
                    richTextBox1.Text = richTextBox1.Text + result.StatusCode + " " + bytes.Length.ToString() + " " + link + "\n";
                }
                else
                {
                    richTextBox1.Text = richTextBox1.Text + "ERROR, Skipping. (URL: "+ link +")" + "\n";
                    countStep -= 1;
                }
            }
            sr.Close();
            richTextBox1.Text = richTextBox1.Text +"\n" + "Download Complete " + "(" + countStep.ToString() + "/" + lineCount.ToString() + ").";
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            if (downloadPanel.Visible == false)
            {
                downloadPanel.Visible = true;
                historyPanel.Visible = false;
                favoritePanel.Visible = false;
                settingsPanel.Visible = false;
            }
            else
            {
                downloadPanel.Visible = false;
            }
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            if (settingsPanel.Visible == false)
            {
                settingsPanel.Visible = true;
                Settings settingsForm = new Settings(this) { TopLevel = false };
                settingsForm.FormBorderStyle = FormBorderStyle.None;
                settingsPanel.Controls.Add(settingsForm);
                settingsForm.Show();
                downloadPanel.Visible = false;
                historyPanel.Visible = false;
                favoritePanel.Visible = false;
            }
            else
            {
                settingsPanel.Visible = false;
            }
        }
    }
}
