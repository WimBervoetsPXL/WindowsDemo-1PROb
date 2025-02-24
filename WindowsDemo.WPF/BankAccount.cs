using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsDemo.WPF
{
    public class BankAccount
    {
		private List<Transaction> _transactions;

		public List<Transaction> Transactions
		{
			get { return _transactions; }
			set { _transactions = value; }
		}

        public BankAccount()
        {
            _transactions = new List<Transaction>();
        }

    }
}
