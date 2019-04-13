using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Infrastructure;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        private Account _currentAccount;
        private AccountBank _accountBank;

        public Form1(AccountBank ab)
        {
            _accountBank = ab;
            InitializeComponent();
            IList<string> allAccounts = ab.GetAllAccountStrings();

            foreach (string account in allAccounts)
            {
                this.comboBox1.Items.Add(account);
            }

        }

        private void SetCurrentAccount(string serviceName)
        {
            _currentAccount = _accountBank.GetAccount(serviceName.ToString());
            this.label1.Text = _currentAccount.Service;
            this.textBox1.Text = _currentAccount.UserName;
            this.textBox2.Text = _currentAccount.PassWord;
            this.label1.Show();
            this.label2.Show();
            this.label3.Show();
            this.textBox1.Show();
            this.textBox2.Show();
        }

        private void ResetToBlank()
        {
            this.label1.Hide();
            this.label2.Hide();
            this.label3.Hide();
            this.textBox1.Hide();
            this.textBox2.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            object service = this.comboBox1.SelectedItem;
            if (service == null)
            {
                MessageBox.Show("Please pick a valid value!");
                ResetToBlank();
            }
            else
            {
                SetCurrentAccount(service.ToString());
            }
        }
    
    }
}
