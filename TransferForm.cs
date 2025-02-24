using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banking
{
    public partial class TransferForm: Form
    {
        public TransferForm()
        {
            InitializeComponent();
            loaddate();
        }

        private void loaddate()
        {
            datelbl.Text = DateTime.UtcNow.ToString("dd/MM/yyyy");
        }

        private void detailsbtn_Click(object sender, EventArgs e)
        {
            banking_dbEntities dbe = new banking_dbEntities();
            decimal b = Convert.ToDecimal(fromacctxt.Text);
            var item = (from u in dbe.userAccount where u.Account_No == b select u).FirstOrDefault();
            nametxt.Text = item.Name;
            amounttxt.Text = Convert.ToString(item.balance);
        }

        private void transferbtn_Click(object sender, EventArgs e)
        {
            banking_dbEntities dbe = new banking_dbEntities();
            decimal b = Convert.ToDecimal(fromacctxt.Text);
            var item = (from u in dbe.userAccount where u.Account_No == b select u).FirstOrDefault();
            decimal b1 = Convert.ToDecimal(item.balance);
            decimal totalbal = Convert.ToDecimal(transfertxt.Text);
            decimal transferacc = Convert.ToDecimal(desaccounttxt.Text);
            if(b1>totalbal)
            {
                userAccount item2 = (from u in dbe.userAccount where u.Account_No == transferacc select u).FirstOrDefault();

                item2.balance += totalbal;
                item.balance -= totalbal;

                Transfer transfer = new Transfer();
                transfer.Account_No = Convert.ToDecimal(fromacctxt.Text);
                transfer.Name = nametxt.Text;
                transfer.Date = DateTime.UtcNow.ToString("dd/MM/yyyy");
                transfer.ToTransfer = Convert.ToDecimal(desaccounttxt.Text);
                transfer.balance = Convert.ToDecimal(transfertxt.Text);

                dbe.Transfer.Add(transfer);
                dbe.SaveChanges();
                MessageBox.Show("Transfered Money Successfully");
            }
        }
    }
}
