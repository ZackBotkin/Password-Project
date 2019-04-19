using System;
using System.Data;
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
            DBQuery query = new DBQuery();
            DataTable table = query.GetData();

            _allAccounts = new Dictionary<string, Account>();

            foreach (DataRow row in table.Rows)
            {
                _allAccounts[row[0].ToString()] = new Account(
                    row[0].ToString(),
                    row[1].ToString(), 
                    row[2].ToString()
                );
            }
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
