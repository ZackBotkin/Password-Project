using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Infrastructure
{
    public class Account
    {

        private string _service;
        private string _userName;
        private string _passWord;

        public Account(string service, string userName, string passWord)
        {
            _service = service;
            _userName = userName;
            _passWord = passWord;
        }

    }
}
