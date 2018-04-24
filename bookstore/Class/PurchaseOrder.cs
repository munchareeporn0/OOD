using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookstore.Class
{
    class PurchaseOrder
    {
        public string purchase_id { get; set; }
        public string employee_id { get; set; }
        public string date { get; set; }
        public List<Purchaseline> purchase_item { get; set; }

        public string GetPurchaseID()
        {
            Function iFt = new Function();
            DataTable temp = iFt.Select("SELECT purchase_id FROM purchaseorder ORDER BY purchase_id DESC LIMIT 1");

            if (temp.Rows.Count <= 0)
            {
                return "P0001";
            }
            else
            {
                string res = temp.Rows[0][0].ToString();
                return "P" + (Int32.Parse(res.Substring(1, res.Length - 1)) + 1).ToString("0000");
            }
        }
 
        public void ReceiptOrder()
        {
            
        }

        public void AddPurchase(DataGridViewRowCollection data_rows)
        {
            foreach (DataGridViewRow dr in data_rows)
            {
                Purchaseline temp = new Purchaseline();
                temp.book_id = dr.Cells["ID"].ToString();
                temp.GetPublisher();
                purchase_item.Add(temp);
            }
        }
    }

}
