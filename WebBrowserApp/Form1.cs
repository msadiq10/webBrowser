using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowserApp
{
    public partial class Form1 : Form
    {
        string url = "https://www.google.com/"; // homepage
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            home();
        }

        private async Task home()
        {
            using var client = new HttpClient();

            searchBox.Text = url;

            string urlNotFound = "http://www.macs.hw.ac.uk/~hwloidl/Courses/F21SC/httpstat.us/404";

            var result = await client.GetAsync(url);

            richTextBox1.Text = "Loading...";

            if (result.StatusCode.ToString().Equals("BadRequest"))
            {
                label1.Text = "Error: Bad Request!";
                richTextBox1.Text = "";
            }
            else if (result.StatusCode.ToString().Equals("Forbidden"))
            {
                label1.Text = "Error: Forbidden!";
                richTextBox1.Text = "";
            }
            else if (result.StatusCode.ToString().Equals("NotFound"))
            {
                label1.Text = "Error: Not found!";
                richTextBox1.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                richTextBox1.Text = "ERROR 404: NOT FOUND";
            }
            else
            {
                label1.Text = "Status: "+result.StatusCode.ToString();
                richTextBox1.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                var content = await client.GetStringAsync(url);

                richTextBox1.Text = content;
            }
        }

        private void reload(object sender, EventArgs e)
        {
            url = searchBox.Text;
            home();
        }

        private void searchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                url = searchBox.Text;
                home();
            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            url = "https://www.google.com/";
            home();
        }

        private void homeButton_Click_1(object sender, EventArgs e)
        {
            url = "https://www.google.com/";
            home();
        }
    }
}
