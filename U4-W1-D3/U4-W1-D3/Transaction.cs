using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U4_W1_D3
{
    public class Transaction
    {
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string Causal { get; set; }

        public Transaction(DateTime date, decimal amount, string causal)
        {
            Date = date;
            Amount = amount;
            Causal = causal;
        }
    }

}
