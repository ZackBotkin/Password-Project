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

        private AccountBank _accountBank;

        public Form1(AccountBank ab)
        {
            _accountBank = ab;
            InitializeComponent();
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            string service = "Service";
        }
    }
}
