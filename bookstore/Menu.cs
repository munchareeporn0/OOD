using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookstore
{
    public partial class Menu : Form
    {
        string keep;

        public Menu(int type, string keep)
        {
            InitializeComponent();
            
            if (type == 2)
            {
                btnReport.Enabled = false;
            }
            else
            {
                btnSell.Enabled = false;
                btnBuy.Enabled = false;
                btnReceive.Enabled = false;
                btnManage.Enabled = false;
            }

            this.keep = keep;
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            Sell from = new Sell(keep);
            from.Location = this.Location;
            from.ShowDialog();
        }

        private void btnbuy_Click(object sender, EventArgs e)
        {
            Buy1 from = new Buy1(keep);
            from.Location = this.Location;
            from.ShowDialog();
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            Receive from = new Receive();
            from.Location = this.Location;
            from.ShowDialog();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            Manage from = new Manage(keep);
            from.Location = this.Location;
            from.ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Report from = new Report(keep);
            from.Location = this.Location;
            from.ShowDialog();
        }


        void OnBack()
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
