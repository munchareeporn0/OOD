using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookstore.Class
{
    class Owner
    {
        public string owner_id { get; set; }
        public string name { get; set; }

        public bool CheckOwner(string username, string password)
        {
            Function iFt = new Function();

            username = "\"" + username + "\"";
            password = "\"" + password + "\"";

            string sql = String.Format("SELECT * FROM user WHERE user_id = {0} AND user.password = {1} AND type = 1", username, password);

            return iFt.Select(sql).Rows.Count != 0;
        }

        public void UpdateOwner()
        {

        }
    }
}
