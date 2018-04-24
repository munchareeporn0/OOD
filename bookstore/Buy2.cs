using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PurchaseClass = bookstore.Class.PurchaseOrder;
using PurchaseLineClass = bookstore.Class.Purchaseline;

namespace bookstore
{
    public partial class Buy2 : Form
    {
        PurchaseClass item;

        internal Buy2(string IDem, PurchaseClass item)
        {
            InitializeComponent();

            txtIDem.Text = IDem;
            txtIDbuy.Text = item.purchase_id;

            this.item = item;

            item.purchase_item
                .ForEach(row => dgvListofbuy.Rows.Add(
                    row.book_id, 
                    row.book_name, 
                    row.price, 
                    row.amount, 
                    row.publisher));
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

        private void btnConfirm_Click(object sender, EventArgs e) {
            item.Insert();

            MessageBox.Show("สั่งซื้อสำเร็จ");
            this.Close();
        }
    }
}
