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
    public partial class newAccount: Form
    {
        string gender = string.Empty;
        string m_status = string.Empty;
        decimal no;
        banking_dbEntities BSE;
        MemoryStream ms;
        public newAccount()
        {
            InitializeComponent();
            loaddate();
            loadaccount();
            loadstate();
        }

        private void loadstate()
        {
           // throw new NotImplementedException();
        }

        private void loadaccount()
        {
            BSE = new banking_dbEntities();
            var item = BSE.userAccount.ToArray();
            no = item.LastOrDefault().Account_No + 1; // hesapno yu 100000'den baslattigimiz icin +1 ekledik.
            accnotxt.Text = Convert.ToString(no);
        }

        private void loaddate()
        {
            datelbl.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void newAccount_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendlg = new OpenFileDialog();
            if(opendlg.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(opendlg.FileName);
                pictureBox1.Image = img;
                ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if(maleradio.Checked)
            {
                gender = "Male";
            }
            else if ( femaleradio.Checked)
            {
                gender = "Female";
            }
            else
            {
                MessageBox.Show("Gender field cannot be left blank!");
            }
            if(marriedradio.Checked)
            {
                m_status = "married";
            }
            else if (singleradio.Checked)
            {
                m_status = "single";
            }
            else
            {
                MessageBox.Show("Maritial Status field cannot be left blank!");
            }

            BSE = new banking_dbEntities();
            userAccount acc = new userAccount(); // Data Table userAccount 

            acc.Account_No = Convert.ToDecimal(accnotxt.Text);
            acc.Name = nametxt.Text;
            acc.DOB = dateTimePicker1.Value.ToString();
            acc.PhoneNo = phonetxt.Text;
            acc.Address = addresstxt.Text;
            acc.State = comboBox1.SelectedItem.ToString();
            acc.Gender = gender;
            acc.maritial_status = m_status;
            acc.Mothers_Name = momtxt.Text;
            acc.Fathers_Name = dadtxt.Text;
            acc.balance = Convert.ToDecimal(balancetxt.Text);
            acc.Date = datelbl.Text;
            acc.Picture = ms.ToArray();
            BSE.userAccount.Add(acc);
            BSE.SaveChanges();
            MessageBox.Show("File Saved");
        }
    }
}
