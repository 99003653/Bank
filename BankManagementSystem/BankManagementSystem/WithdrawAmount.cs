using System;
using System.Collections.Generic;
using System.Text;

namespace BankManagementSystem
{
    public class WithdrawAmount
    {
    
        Balance B = new Balance();

        public int Withdraw(int amount)
        {
            if (amount > B.Amount)
            {
                return -1;
            }
            else
            {
                B.Amount -= amount;
                return B.Amount;
            }
        }
    }
}