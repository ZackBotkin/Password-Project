using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Infrastructure
{
    public class AccountBank
    {

        private Dictionary<string, Account> _allAccounts;

        public AccountBank()
        {
            _allAccounts = new Dictionary<string, Account>();
            _allAccounts["Microsoft"] = new Account("Microsoft", "foo", "bar");
            _allAccounts["Facebook"] = new Account("Facebook", "bot", "baz");
        }


        public IList<string> GetAllAccountStrings() {
            return _allAccounts.Keys.ToList();
        }

        public Account GetAccount(string service)
        {
            return _allAccounts[service];
        }

    }
}
