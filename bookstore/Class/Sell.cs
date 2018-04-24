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
    class Sell
    {
        public string sale_id { get; set; }
        public string employee_id { get; set; }
        public string date { get; set; }
        public Sellline sale_item { get; set; }

        public string GetSellID()
        {
            Function iFt = new Function();
            DataTable temp = iFt.Select("SELECT sale_id FROM sell ORDER BY sale_id DESC LIMIT 1");

            if (temp.Rows.Count <= 0)
            {
                sale_id = "S0001";
            }
            else
            {
                string res = temp.Rows[0][0].ToString();
                sale_id = "S" + (Int32.Parse(res.Substring(1, res.Length - 1)) + 1).ToString("0000");
            }

            return sale_id;
        }

        public void AddSell(DataGridViewRowCollection data_rows)
        {
            Function iFt = new Function();

            string sql = "INSERT INTO sell SET sale_id =  '" + sale_id + "', employee_id = '" + employee_id + "', sale_date = '" + date + "'";
            //string sql = String.Format("INSERT INTO sell SET sale_id = '{0}', employee_id = '{1}', sale_date = '{2}'", sale_id, employee_id, date);

            iFt.Update(sql);
            
            foreach (DataGridViewRow dr in data_rows)
            {
                sale_item = new Sellline();
                sale_item.sale_id = sale_id;
                sale_item.book_id = dr.Cells["ID"].Value.ToString();
                sale_item.amount = Int32.Parse(dr.Cells["qty"].Value.ToString());
                sale_item.AddSelline();
            }
        }

        public void CalculatePrice()
        {

        }

        public void PrintReceipt()
        {

        }

        public void PrintSaleReporte()
        {

        }


    }
}
