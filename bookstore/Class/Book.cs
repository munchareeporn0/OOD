using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookstore.Class
{
    class Book
    {
        public string book_id { get; set; }
        public string book_type { get; set; }
        public string book_name { get; set; }
        public string author { get; set; }
        public float book_price { get; set; }
        public string publisher { get; set; }
        public int amount { get; set; }
        public Sellline sale_item { get; set; }

        public string GetBookID()
        {
            Function iFt = new Function();
            DataTable temp = iFt.Select("SELECT book_id FROM book ORDER BY book_id DESC LIMIT 1");

            if (temp.Rows.Count <= 0)
            {
                book_id = "S0001";
            }
            else
            {
                string res = temp.Rows[0][0].ToString();
                book_id = "B" + (Int32.Parse(res.Substring(1, res.Length - 1)) + 1).ToString("0000");
            }

            return book_id;
        }

        public void getBook()
        {
            Function iFt = new Function();
            string sql = "SELECT * FROM book WHERE book_id = '" + book_id + "'";

            DataTable Dtable = iFt.Select(sql);

            foreach (DataRow row in Dtable.Rows)
            {
                book_type = row[1].ToString();
                book_name = row[2].ToString();
                author = row[3].ToString();
                book_price = Int32.Parse(row[4].ToString());
                publisher = row[5].ToString();
                amount = Int32.Parse(row[6].ToString());
            }
        }

        public void UpdateBook()
        {
            Function iFt = new Function();
            string sql = "UPDATE book SET book_type = '" + book_type + "', book_name = '" + book_name + "', author = '" + author + "',book_price = '" + book_price + "', publisher = '" + publisher + "', amount = '" + amount + "' WHERE book_id = '" + book_id + "'" ;
            iFt.Update(sql);
        }

        public void InsertBook()
        {
            Function iFt = new Function();
            string sql = "INSERT book SET book_id = '" + book_id + "' ,book_type = '" + book_type + "', book_name = '" + book_name + "', author = '" + author + "',book_price = '" + book_price + "', publisher = '" + publisher + "', amount = '" + amount + "'";
            iFt.Update(sql);
        }


    }
}
