using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banking
{
    public partial class UpdationForm: Form
    {
        banking_dbEntities dbe;
        MemoryStream ms;
        BindingList<userAccount> bi;

        public UpdationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Details Button
            bi = new BindingList<userAccount>();
            dbe = new banking_dbEntities();
            decimal accno = Convert.ToDecimal(acctxt.Text);
            var item = dbe.userAccount.Where(a => a.Account_No == accno);
            foreach(var item1 in item)
            {
                bi.Add(item1);
            }
            dataGridView1.DataSource = bi;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Search Button
            bi = new BindingList<userAccount>();
            dbe = new banking_dbEntities();
            
            var item = dbe.userAccount.Where(a => a.Name == nametxt.Text);
            foreach (var item1 in item)
            {
                bi.Add(item1);
            }
            dataGridView1.DataSource = bi;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dbe = new banking_dbEntities();
            decimal accno = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            var item = dbe.userAccount.Where(a => a.Account_No == accno).FirstOrDefault();
            acctxt.Text = item.Account_No.ToString();
            nametxt.Text = item.Name;
            momtxt.Text = item.Mothers_Name;
            dadtxt.Text = item.Fathers_Name;
            phonetxt.Text = item.PhoneNo;
            addresstxt.Text = item.Address;
            byte[] img = item.Picture;
            MemoryStream ms = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(ms);
            statetxt.Text = item.State;
            if(item.Gender == "male")
            {
                maleradio.Checked = true;
            }
            else if (item.Gender == "female")
            {
                femaleradio.Checked = true;
            }
            if(item.maritial_status == "married")
            {
                marriedradio.Checked = true;
            }
            else if(item.maritial_status == "single")
            {
                singleradio.Checked = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Upload File Button
            OpenFileDialog opendlg = new OpenFileDialog();

            if(opendlg.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(opendlg.FileName);
                pictureBox1.Image = img;
                ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Delete Button and deleting ONE ROW
            bi.RemoveAt(dataGridView1.SelectedRows[0].Index);
            dbe = new banking_dbEntities();
            decimal a = Convert.ToDecimal(acctxt.Text);
            userAccount acc = dbe.userAccount.First(s => s.Account_No.Equals(a));
            dbe.userAccount.Remove(acc);
            dbe.SaveChanges();
        }
    }
}
