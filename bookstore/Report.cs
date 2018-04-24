using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookstore
{
    public partial class Report : Form
    {
        string IDem;
        public Report(string IDem)
        {
            InitializeComponent();
            txtIDowner.Text = IDem;
            txtIDowner1.Text = IDem;
            txtIDowner2.Text = IDem;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
