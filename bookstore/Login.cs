using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using EmployeeClass = bookstore.Class.Employee;
using UserClass = bookstore.Class.Employee;
using OwnerClass = bookstore.Class.Owner;

namespace bookstore
{
    public partial class Login : Form
    {
        public string keep = "";

        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

            UserClass uc = new UserClass();
            OwnerClass oc = new OwnerClass();

            keep = txtUsername.Text;

            if (oc.CheckOwner(txtUsername.Text, txtPassword.Text))
            {
                Menu from = new Menu(1, keep);
                from.ShowDialog();
            }
            else if (uc.CheckUser(txtUsername.Text, txtPassword.Text))
            {
                Menu from = new Menu(2, keep);
                from.ShowDialog();
            }
            else
            {
                MessageBox.Show("กรุณาตรวจสอบรหัสผ่าน");
            }

        }
    }
}
