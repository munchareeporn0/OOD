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

        public PurchaseOrder() {
            purchase_item = new List<Purchaseline>();
        }

        public void GetPurchaseID()
        {
            Function iFt = new Function();
            DataTable temp = iFt.Select("SELECT purchase_id FROM purchaseorder ORDER BY purchase_id DESC LIMIT 1");

            if (temp.Rows.Count <= 0)
            {
                purchase_id = "P0001";
            }
            else
            {
                string res = temp.Rows[0][0].ToString();
                purchase_id = "P" + (int.Parse(res.Substring(1, res.Length - 1)) + 1).ToString("0000");
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
                temp.book_id = dr.Cells[0].Value.ToString();
                temp.amount = int.Parse(dr.Cells[2].Value.ToString());
                temp.GetDetail();
                purchase_item.Add(temp);
            }
        }

        public void Insert() {
            // Insert this item and item.line into database

            Function iFt = new Function();

            string sql = "";

            sql = string.Format("INSERT INTO purchaseorder " +
                                "VALUES ('{0}', '{1}', NOW()) "
                                , purchase_id, employee_id);

            iFt.Update(sql);
            purchase_item.ForEach(item => item.Insert(purchase_id));
        }
    }

}
