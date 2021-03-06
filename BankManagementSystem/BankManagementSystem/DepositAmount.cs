using System;
using System.Collections.Generic;
using System.Text;

namespace BankManagementSystem
{
    public class DepositAmount
    {
       
        Balance B = new Balance();
        public int Deposit(int amount)
        {
           B.Amount += amount;
            return B.Amount;
        }
    }
}