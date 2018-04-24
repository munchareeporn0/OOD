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
    public partial class Edit : Form
    {
        BookClass item = new BookClass();
        string IDem;
        string Bookid;
        private object txtIDbook;

        public Edit(string IDem, string Bookid)
        {
            InitializeComponent();
            this.IDem = IDem;
            txtIDem.Text = IDem;

            this.Bookid = Bookid;
            txtIDBook.Text = Bookid;

            item.book_id = Bookid;
            item.getBook();

            txtType.Text = item.book_type;
            txtName.Text = item.book_name;
            txtAuther.Text = item.author;
            txtPur.Text = item.publisher;
            txtPrice.Text = item.book_price.ToString();
            txtAmount.Text = item.amount.ToString();
           
        }

        

        private void btnEdit_Click(object sender, EventArgs e)
        {
            item.book_type = txtType.Text;
            item.book_name = txtName.Text;
            item.author = txtAuther.Text;
            item.publisher = txtPur.Text;
            item.book_price = Int32.Parse(txtPrice.Text);
            item.amount = Int32.Parse(txtAmount.Text);

            item.UpdateBook();
            MessageBox.Show("แก้ไขสำเร็จ");

            item.getBook();
            txtType.Text = item.book_type;
            txtName.Text = item.book_name;
            txtAuther.Text = item.author;
            txtPur.Text = item.publisher;
            txtPrice.Text = item.book_price.ToString();
            txtAmount.Text = item.amount.ToString();

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
    }
}
