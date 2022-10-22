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
            string fav = f1.searchText;
            StreamWriter sw = new StreamWriter(System.IO.Path.GetFullPath("favorites.txt").ToString().Replace((char)92, (char)47).Replace("/bin/Debug/netcoreapp3.1/", "/txtfiles/"), true);
            sw.WriteLine(fav);
            sw.Close();
            MessageBox.Show("Successfully added to Favorites.");
        }
    }
}
