using System;
using System.Collections.Generic;
using System.Text;

namespace AtmSimulator
{
    class Deposit : AddAmount
    {
        public override int SelectAmount(int balance)
        {
            Console.WriteLine("Please indicate the amount: ");
            string total = Console.ReadLine();
            return this.AddToTotal(balance, Convert.ToInt32(total));            
        }

        public int AddToTotal(int balance, int amount)
        {
            Balance bal = new Balance(balance);
            return bal.AddToBalance(amount);
        }
    }
}
