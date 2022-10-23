using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WebBrowserApp
{
    public partial class Settings : Form
    {
        Form1 f1;
        public Settings(Form1 frm1)
        {
            InitializeComponent();
            this.f1 = frm1;
        }

        private void setHome_Click(object sender, EventArgs e)
        {
            //Form1 f = new Form1();
            string home = f1.searchText;
            StreamWriter sw = new StreamWriter(System.IO.Path.GetFullPath("home.txt").ToString().Replace((char)92, (char)47).Replace("/bin/Debug/netcoreapp3.1/", "/txtfiles/")); 
            sw.Write(home);
            sw.Close();
            MessageBox.Show("Successfully changed Homepage.");
        }

        private void addToFavorites_Click(object sender, EventArgs e)
        {
            int countLabels = 0;
            int y = 10;
            string fav = f1.searchText;
            string s = "";
            StreamReader sr = new StreamReader(System.IO.Path.GetFullPath("favorites.txt").ToString().Replace((char)92, (char)47).Replace("/bin/Debug/netcoreapp3.1/", "/txtfiles/"), true);
            while ((s = sr.ReadLine()) != null)
            {
                countLabels += 1;
            }
            sr.Close();
            StreamWriter sw = new StreamWriter(System.IO.Path.GetFullPath("favorites.txt").ToString().Replace((char)92, (char)47).Replace("/bin/Debug/netcoreapp3.1/", "/txtfiles/"), true);
            sw.WriteLine(fav);
            sw.Close();
            f1.Panel1.Controls.Clear();
            Favorites favoritesForm = new Favorites(f1) { TopLevel = false };
            favoritesForm.FormBorderStyle = FormBorderStyle.None;
            //f1.Panel1.Visible = true;

            label1.Text = countLabels.ToString();

            Label favorite = new Label();
            favoritesForm.Controls.Add(favorite);
            favorite.AutoSize = true;
            favorite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            favorite.Location = new System.Drawing.Point(10, y + (countLabels + 1) * 35);
            favorite.Name = "favorite" + (countLabels + 1).ToString();
            favorite.Size = new System.Drawing.Size(67, 20);
            favorite.TabIndex = 0;
            favorite.Text = fav;
            favorite.Click += new System.EventHandler(favoritesForm.favorite_Click);

            f1.Panel1.Controls.Add(favoritesForm);
            favoritesForm.Show();

            MessageBox.Show("Successfully added to Favorites.");
        }
    }
}
