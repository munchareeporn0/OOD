using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PurchaseOrderClass = bookstore.Class.PurchaseOrder;

namespace bookstore
{
    public partial class Buy2 : Form
    {
        PurchaseOrderClass item = new PurchaseOrderClass();

        public Buy2(string IDem)
        {
            InitializeComponent();
            txtIDbuy.Text = item.GetPurchaseID();
            txtIDem.Text = IDem;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;

            txtDate.Text = today.ToString("yyyy-MM-dd");
        }
    }
}
