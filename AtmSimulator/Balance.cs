using System;
using System.Collections.Generic;
using System.Text;

namespace AtmSimulator
{
    class Balance
    {
        public static int TotalBalance = 0;

        public Balance(int balance)
        {
            TotalBalance = balance;
        }

        public int SubstractFromBalance(int amount)
        {
            return TotalBalance -= amount;
        }

        public int AddToBalance(int amount)
        {
            return TotalBalance += amount;
        }
    }
}
