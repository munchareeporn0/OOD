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
    public partial class Buy1 : Form
    {
        BookClass item = new BookClass();

        string IDem;
        public Buy1(string IDem)
        {
            InitializeComponent();
            txtIDem.Text = IDem;
            this.IDem = IDem;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvGetproduct.SelectedRows)
            {

            }

            Buy2 from = new Buy2(IDem);
            from.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvProduct.SelectedRows)
            {
                dgvGetproduct.Rows.Add(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;

            txtDate.Text = today.ToString("yyyy-MM-dd");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Function iFt = new Function();
            string sql = "SELECT book_id, book_name, book_price, amount FROM book WHERE book_id = '" + txtIDbook.Text + "' OR book_name = '" + txtName.Text + "' OR book_type = '" + cbbType.Text + "'";
            DataTable Dtable = iFt.Select(sql);
            dgvProduct.Rows.Clear();
            foreach (DataRow row in Dtable.Rows)
            {
                dgvProduct.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvGetproduct.SelectedRows)
            {
                dgvGetproduct.Rows.Clear();
            }
        }

        private void dgvGetproduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvGetproduct.Columns["Cdelete"].Index)
            {
                dgvGetproduct.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}
