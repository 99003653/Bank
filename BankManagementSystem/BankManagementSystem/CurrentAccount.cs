using System;
using System.Collections.Generic;
using System.Text;

namespace BankManagementSystem
{
   public class CurrentAccount : Account
    {
        public CurrentAccount(string id, string name, string address, string dob) 
        {
            AccountID = id;
            CustomerName = name;
            Address = address;
            DateofBirth = dob;
        }
        List<string> customer = new List<string>();
        public IEnumerable<string> SendCurrentAccountDetail()
        {
            customer.Add(AccountID);
            customer.Add(Address);
            customer.Add(DateofBirth);
            customer.Add(CustomerName);
            return customer;
        }
    }
}