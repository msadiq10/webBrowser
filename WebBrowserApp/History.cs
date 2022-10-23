using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WebBrowserApp
{
    public partial class History : Form
    {
        Form1 f1;
        public History(Form1 frm1)
        {
            InitializeComponent();
            this.f1 = frm1;
        }

        public void history_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            f1.searchText = lbl.Text;
            f1.load();
        }
    }
}
