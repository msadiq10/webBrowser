using System;
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

        public string searchText {
            get
            {
                return this.searchBox.Text;
            }
            set
            {
                this.searchBox.Text = value;
            }
        }

        public Panel Panel1
        {
            get
            {
                return this.favoritePanel;
            }
            set
            {
                this.favoritePanel = value;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            home();
            load();
            loadFavorites();
        }

        private void loadFavorites()
        {
            favoritePanel.Controls.Clear();
            StreamReader srf = new StreamReader(System.IO.Path.GetFullPath("favorites.txt").ToString().Replace((char)92, (char)47).Replace("/bin/Debug/netcoreapp3.1/", "/txtfiles/"));
            string fav = "";
            int countStep = 0;
            int y = 10;
            Favorites favoritesForm = new Favorites(this) { TopLevel = false };
            favoritesForm.FormBorderStyle = FormBorderStyle.None;
            while ((fav = srf.ReadLine()) != null)
            {
                Label favorite = new Label();
                favoritesForm.Controls.Add(favorite);
                favorite.AutoSize = true;
                favorite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                favorite.Location = new System.Drawing.Point(10, y+countStep*35);
                favorite.Name = "favorite"+(countStep+1).ToString();
                favorite.Size = new System.Drawing.Size(67, 20);
                favorite.TabIndex = 0;
                favorite.Text = fav;
                favorite.Click += new System.EventHandler(favoritesForm.favorite_Click);
                countStep += 1;
            }
            srf.Close();
            favoritePanel.Controls.Add(favoritesForm);
            favoritesForm.Show();
        }
        private void home()
        {
            string temp = "";
            StreamReader sr1 = new StreamReader(System.IO.Path.GetFullPath("home.txt").ToString().Replace((char)92, (char)47).Replace("/bin/Debug/netcoreapp3.1/", "/txtfiles/"));
            temp = sr1.ReadLine();
            if (temp != "")
                searchBox.Text = temp;
            else
                searchBox.Text = "https://www.google.com/";
            sr1.Close();
            url = searchBox.Text;
            searchText = searchBox.Text.ToString();
        }

        public async Task load()
        {
            using var client = new HttpClient();
            string hisString = "";
            int countStep = 0;
            int y = 10;
            url = searchText;
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

            StreamWriter swh = new StreamWriter(System.IO.Path.GetFullPath("history.txt").ToString().Replace((char)92, (char)47).Replace("/bin/Debug/netcoreapp3.1/", "/txtfiles/"), true);
            swh.WriteLine(url);
            swh.Close();

            History historyForm = new History(this) { TopLevel = false };
            historyForm.FormBorderStyle = FormBorderStyle.None;
            StreamReader srh = new StreamReader(System.IO.Path.GetFullPath("history.txt").ToString().Replace((char)92, (char)47).Replace("/bin/Debug/netcoreapp3.1/", "/txtfiles/"));
            historyPanel.Controls.Clear();
            while ((hisString = srh.ReadLine()) != null)
            {
                Label historyLabel = new Label();
                historyForm.Controls.Add(historyLabel);
                historyLabel.AutoSize = true;
                historyLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                historyLabel.Location = new System.Drawing.Point(10, y + countStep * 35);
                historyLabel.Name = "history" + (countStep + 1).ToString();
                historyLabel.Size = new System.Drawing.Size(67, 20);
                historyLabel.TabIndex = 0;
                historyLabel.Text = hisString;
                historyLabel.Click += new System.EventHandler(historyForm.history_Click);
                countStep += 1;
            }
            srh.Close();
            historyPanel.Controls.Add(historyForm);
            historyForm.Show();
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
                ////History historyForm = new History(this) { TopLevel = false};
                ////historyForm.FormBorderStyle = FormBorderStyle.None;
                ////historyPanel.Controls.Add(historyForm);
                ////historyForm.Show();
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
            //StreamReader srf = new StreamReader(System.IO.Path.GetFullPath("favorites.txt").ToString().Replace((char)92, (char)47).Replace("/bin/Debug/netcoreapp3.1/", "/txtfiles/"));
            string fav = "";
            int countStep = 0;
            int y = 10;
            if (favoritePanel.Visible == false)
            {
                favoritePanel.Visible = true;
                loadFavorites();
                //Favorites favoritesForm = new Favorites(this) { TopLevel = false };
                //favoritesForm.FormBorderStyle = FormBorderStyle.None;

                //while ((fav = srf.ReadLine()) != null)
                //{
                //    Label favorite = new Label();
                //    favoritesForm.Controls.Add(favorite);
                //    favorite.AutoSize = true;
                //    favorite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                //    favorite.Location = new System.Drawing.Point(10, y+countStep*35);
                //    favorite.Name = "favorite"+(countStep+1).ToString();
                //    favorite.Size = new System.Drawing.Size(67, 20);
                //    favorite.TabIndex = 0;
                //    favorite.Text = fav;
                //    favorite.Click += new System.EventHandler(favoritesForm.favorite_Click);
                //    countStep += 1;
                //}
                //srf.Close();

                //favoritePanel.Controls.Add(favoritesForm);
                //favoritesForm.Show();
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
