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
    public partial class Add : Form
    {
        BookClass item = new BookClass();
        string IDem;
        public Add(string IDem)
        {
            InitializeComponent();
            txtIDem.Text = IDem;
            txtIDBook.Text = item.GetBookID();
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            item.book_id = txtIDBook.Text;
            item.book_type = cbbType.Text;
            item.book_name = txtName.Text;
            item.author = txtAuther.Text;
            item.publisher = txtPur.Text;
            item.book_price = Int32.Parse(txtPrice.Text);
            item.amount = Int32.Parse(txtAmount.Text);

            item.InsertBook();

            MessageBox.Show("เพิ่มสำเร็จ");

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;

            txtDate.Text = today.ToString("yyyy-MM-dd");
        }

        private void ged(object sender, EventArgs e)
        {

        }
    }
}
