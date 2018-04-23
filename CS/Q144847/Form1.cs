using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;

namespace Q144847 {
    public partial class Form1 : Form {
        public Form1() {
            XpoDefault.ConnectionString = MSSqlConnectionProvider.GetConnectionString("(local)", "Northwind");
            InitializeComponent();
            UpdateLabel();
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            if (xpPageSelector1.CurrentPage == 0) return;
            xpPageSelector1.CurrentPage--;
            UpdateLabel();
        }

        private void UpdateLabel() {
            labelControl1.Text = string.Format("Page {0} of {1}", xpPageSelector1.CurrentPage,
                xpPageSelector1.PageCount);
        }

        private void simpleButton2_Click(object sender, EventArgs e) {
            if (xpPageSelector1.CurrentPage == xpPageSelector1.PageCount - 1) return;
            xpPageSelector1.CurrentPage++;
            UpdateLabel();
        }
    }
}