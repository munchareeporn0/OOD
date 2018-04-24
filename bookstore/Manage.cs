using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BookClass = bookstore.Class.Book;




namespace bookstore
{
    public partial class Manage : Form
    {
        Function iFt = new Function();
        string IDem;
        string book_id;
        //

        //

        public Manage(string IDem)
        {
            InitializeComponent();
            txtIDem.Text = IDem;
            this.IDem = IDem;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add from = new Add(IDem);
            from.ShowDialog();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Function iFt = new Function();
            string sql = "SELECT book_id, book_name, amount FROM book WHERE book_id = '" + txtIDBook.Text + "' OR book_name = '" + txtName.Text + "' OR Publisher = '" + txtPur.Text + "' OR book_type = '" + cbbType.Text + "'";
            DataTable Dtable = iFt.Select(sql);
            dgvProduct.Rows.Clear();
            foreach (DataRow row in Dtable.Rows)
            {
                dgvProduct.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString());
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;

            txtDate.Text = today.ToString("yyyy-MM-dd");
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvProduct.Columns["Cedit"].Index)
                {
                    string book_id = dgvProduct.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                    Edit from = new Edit(IDem, book_id);
                    from.Location = this.Location;
                    from.ShowDialog();
                }
                else if (e.ColumnIndex == dgvProduct.Columns["Cdelete"].Index)
                {
                    string book_id = dgvProduct.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                    deleteProduct(book_id);
                    loadProduct();

                }
            }
        }

        private void loadProduct()
        {
            Function iFt = new Function();
            string sql = "SELECT book_id, book_name, amount FROM book WHERE book_id = '" + txtIDBook.Text + "' OR book_name = '" + txtName.Text + "' OR Publisher = '" + txtPur.Text + "' OR book_type = '" + cbbType.Text + "'";
            DataTable Dtable = iFt.Select(sql);
            dgvProduct.Rows.Clear();
            foreach (DataRow row in Dtable.Rows)
            {
                dgvProduct.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString());
            }
        }

        private void deleteProduct(string book_id)
        {
            Function iFt = new Function();

            DialogResult dialogResult = MessageBox.Show("ต้องการลบสินค้าหรือไม่", "", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                string sql = "DELETE FROM book WHERE book_id = '" + book_id + "'";
                iFt.Update(sql);
                MessageBox.Show("ลบสำเร็จ");

            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
    }
}
