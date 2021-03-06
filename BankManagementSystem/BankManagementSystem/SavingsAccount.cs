using System;
using System.Collections.Generic;
using System.Text;

namespace BankManagementSystem
{
   public class SavingsAccount : Account
    {
        public SavingsAccount(string id, string name, string address, string dob) 
        {
           this.AccountID = id;
           this.CustomerName = name;
           this.Address = address;
           this.DateofBirth = dob;
        }

        List<string> customer = new List<string>();


        public IEnumerable<string> SendSavingsAccountDetail()
        {
            customer.Add(AccountID);
            customer.Add(Address);
            customer.Add(DateofBirth);
            customer.Add(CustomerName);

            return customer;
        }
    }
}
