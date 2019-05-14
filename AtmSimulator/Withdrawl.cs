using System;
using System.Collections.Generic;
using System.Text;
namespace AtmSimulator
{
    class Withdrawl : AddAmount
    {
        public override int SelectAmount(int balance)
        {
            Console.WriteLine("Please indicate the amount: ");
            string total = Console.ReadLine();
            return this.SubstractFromTotal(balance, Convert.ToInt32(total));
        }

        private int SubstractFromTotal(int balance, int amount)
        {
            Balance bal = new Balance(balance);
            return bal.SubstractFromBalance(amount);
        }
    }
}
