using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookstore.Class
{
    class Employee
    {
        public string employee_id { get; set; }
        public string name { get; set; }

        public bool CheckUser(string username, string password)
        {
            Function iFt = new Function();
            string sql = String.Format("SELECT * FROM user WHERE user_id = {0} AND password = {1}  AND type = 2", "\"" + username + "\"", "\""  + password + "\"");

            return iFt.Select(sql).Rows.Count != 0;
        }

        public void UpdateEmployee()
        {

        }


    }
}
