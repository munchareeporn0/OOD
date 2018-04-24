using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookstore.Class
{
    class Purchaseline
    {
        public string book_id { get; set; }
        public string publisher { get; set; }
        public int amount { get; set; }
        public bool status { get; set; }
        public float price { get; set; }

        public void GetPublisher()
        {
            string sql = "SELECT publisher FROM book WHERE book id'" + book_id + "'";
        }

        public void UpdateStock()
        {

        }
    }
}
