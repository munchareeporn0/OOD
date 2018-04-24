using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SellClass = bookstore.Class.Sell;
using SelllineClass = bookstore.Class.Sellline;

namespace bookstore
{
    public partial class Sell : Form
    {
        Function iFt = new Function();
        SellClass item = new SellClass();

        public Sell(string IDem)
        {
            InitializeComponent();

            txtIDsell.Text = item.GetSellID();
            txtIDem.Text = IDem;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;

            txtDate.Text = today.ToString("yyyy-MM-dd");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Sell_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string id = txtIDbook.Text;
            string name = txtName.Text;
            string sql = "";

            if (id != string.Empty)
            {
                sql = string.Format("SELECT book_id, book_name, book_price " +
                                    "FROM book " +
                                    "WHERE book_id = \"{0}\" ", id);
            }
            else if (name != string.Empty)
            {
                sql = string.Format("SELECT book_id, book_name, book_price " +
                                    "FROM book " +
                                    "WHERE book_name = \"{0}\" ", name);
            }

            DataTable dt = iFt.Select(sql);

            foreach (DataRow row in dt.Rows)
            {
                txtIDbook.Text  = row[0].ToString();
                txtName.Text    = row[1].ToString();
                txtPrice.Text   = row[2].ToString();
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvProduct.Rows.Add(txtIDbook.Text, txtName.Text, txtAmount.Text, txtPrice.Text);
            txtSum.Text = (float.Parse(txtSum.Text) + (Int32.Parse(txtPrice.Text) * Int32.Parse(txtAmount.Text))).ToString();
        }

        private void txtGet_TextChanged(object sender, EventArgs e)
        {
            float sum = 0.0f;
            float num = 0.0f;

            float.TryParse(txtSum.Text, out sum);
            float.TryParse(txtGet.Text, out num);

            txtGet.Text = num.ToString();
            txtGive.Text = (num - sum).ToString();

            float tmp = 0.0f;
            float.TryParse(txtGet.Text, out tmp);
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selected = dgvProduct.SelectedRows;
            if (selected.Count > 0)
            {
                int price = Int32.Parse(selected[0].Cells[2].Value.ToString()) 
                          * Int32.Parse(selected[0].Cells[3].Value.ToString());

                txtSum.Text = (float.Parse(txtSum.Text) - price).ToString();
                dgvProduct.Rows.RemoveAt(selected[0].Index);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            item.sale_id = txtIDsell.Text;
            item.employee_id = txtIDem.Text;
            item.date = txtDate.Text;
            item.AddSell(dgvProduct.Rows);
            
            MessageBox.Show("บันทึกสำเร็จ");
        }


    }
}
