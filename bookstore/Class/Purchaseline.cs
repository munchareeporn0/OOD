using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookstore.Class
{
    class Purchaseline
    {
        public string book_id { get; set; }
        public string book_name { get; set; }
        public string publisher { get; set; }
        public int amount { get; set; }
        public bool status { get; set; }
        public float price { get; set; }

        public void GetDetail()
        {
            string sql = string.Format(
                            "SELECT book_name, book_price, publisher " +
                            "FROM book " +
                            "WHERE book_id = '{0}'"
                            , book_id);
            
            foreach (DataRow row in (new Function()).Select(sql).Rows) {
                book_name = row[0].ToString();
                price = float.Parse(row[1].ToString());
                publisher = row[2].ToString();
            }
        }

        public void UpdateStock()
        {

        }

        public void Insert(string purchase_id) {
            Function iFt = new Function();

            string sql = string.Format("INSERT INTO purchaseline " +
                                       "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')"
                                       , purchase_id, book_id, amount, 0, price * amount);

            iFt.Update(sql);
        }
    }
}
