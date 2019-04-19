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
            IList<string> accountNames = ab.GetAllAccountStrings();
            foreach(string accountName in accountNames)
            {
                this.listBox1.Items.Add(accountName);
            }
            UpdateAccount(accountNames[0]);
        }

        private void UpdateAccount(string serviceName)
        {
            _currentAccount = _accountBank.GetAccount(serviceName);
            this.textBox1.Text = _currentAccount.UserName;
            this.textBox2.Text = _currentAccount.PassWord;
            this.panel1.Visible = true;
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string serviceName = this.listBox1.SelectedItem.ToString();
            UpdateAccount(serviceName);            
        }
    }
}
