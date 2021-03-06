using System;
using System.Collections.Generic;
using System.Text;

namespace BankManagementSystem
{ 
    public class Account
    {
        public string AccountID { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string DateofBirth { get; set; }
        public Account()
        {

        }
        public Account(string id, string name, string address, string dob)
        {
            this.AccountID = id;
            this.CustomerName = name;
            this.Address = address;
           this.DateofBirth = dob;

        }


    }
}