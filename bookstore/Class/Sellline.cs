using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookstore.Class
{
    class Sellline
    {
        public string sale_id { get; set; }
        public string book_id { get; set; }
        public int amount { get; set; }

        public void AddSelline()
        {
            Function iFt = new Function();

            string sql = "INSERT INTO sellline SET sale_id = '" + sale_id + "', book_id = '" + book_id + "', amount = '" + amount + "'";

            iFt.Update(sql);
            UpdateStock();
        }

        public void UpdateStock()
        {
            Function iFt = new Function();
            string sql1 = "SELECT amount FROM book WHERE book_id = '" + book_id + "'";
            DataTable Dtable = iFt.Select(sql1);

            string temp = "";

            foreach (DataRow row in Dtable.Rows)
            {
                temp = row[0].ToString();
            }

            string sql = "UPDATE book SET amount = '" + (Int32.Parse(temp) - amount).ToString() + "' WHERE book_id = '" + book_id +"'";
            iFt.Update(sql);

        }

    }


}
