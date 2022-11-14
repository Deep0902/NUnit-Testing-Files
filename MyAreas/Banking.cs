using System;
using System.Collections.Generic;
using System.Text;

namespace MyAreas
{
    public class Banking
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Balance { get; set; }

        public void Debit(int amt)
        {
            if (amt < 0) throw new ArgumentException("Amount<0");
            if (amt > Balance) throw new ArgumentException("Connot Withdraw");
            if (amt == Balance) throw new ArgumentException("Now balance = 0");
            Balance = Balance - amt;
        }

        public void Credit(int amt)
        {
            if (amt < 0) throw new ArgumentException("Amount<0");
            Balance = Balance + amt;
        }
    }
}
