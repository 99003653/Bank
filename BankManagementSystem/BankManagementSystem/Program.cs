using System;
using BankManagementSystem;
using BankManagementSystem;

namespace BankManagementSystem
{
   public class Program
    {
        static void Main(string[] args)
        {
            int option = 0;

            do
            {
                try
                {

                    Console.WriteLine("Please choose one option");
                    Console.WriteLine("Press 1 for Create New Account");
                    Console.WriteLine("Press 2 for Deposit");
                    Console.WriteLine("Press 3 for Withdraw");

                    string CustomerName;
                    string Address;
                    string DateofBirth;
                    string AccountType;
                    DepositAmount dm = new DepositAmount();
                    WithdrawAmount wm = new WithdrawAmount();
                    int amount;
                    int counter = 1;
                    int newamount;

                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter Your Name");
                            CustomerName = Console.ReadLine();
                            Console.WriteLine("Enter Address");
                            Address = Console.ReadLine();
                            Console.WriteLine("Enter DateofBith");
                            DateofBirth = Console.ReadLine();
                            Console.WriteLine("Enter Account Type Savings/Current");
                            AccountType = Console.ReadLine();
                            if (AccountType == "Savings")
                            {
                                SavingsAccount savings = new SavingsAccount(counter.ToString(), CustomerName, Address, DateofBirth);
                                counter++;
                                var customer = savings.SendSavingsAccountDetail();
                                Console.WriteLine("the Account details as follows ");
                                foreach (var item in customer)
                                {

                                    Console.WriteLine(item);
                                   




                                }
                                Console.WriteLine("Savings Account Created Successfully");
                            }
                            else if (AccountType == "Current")
                            {
                                CurrentAccount current = new CurrentAccount(counter.ToString(), CustomerName, Address, DateofBirth);
                                counter++;
                                var customer = current.SendCurrentAccountDetail();
                                foreach (var item in customer)
                                {
                                    Console.WriteLine(item);

                                }
                                Console.WriteLine("Current Account Created Successfully");
                            }
                            else
                            {
                                Console.WriteLine("Account Type can only be Savings and Current");
                            }
                            break;
                        case 2:
                            Console.WriteLine("Enter Amount to be deposit");
                            amount = Convert.ToInt32(Console.ReadLine());
                            newamount = dm.Deposit(amount);
                            Console.WriteLine("Deposited Successfully");
                            Console.WriteLine("New Amount is {0}", newamount);
                            break;
                        case 3:
                            Console.WriteLine("Enter Amount to be Withdraw");
                            amount = Convert.ToInt32(Console.ReadLine());
                            newamount = wm.Withdraw(amount);
                            Console.WriteLine("Withdraw Successfull");
                            Console.WriteLine("New Amount is {0}", newamount);
                            break;
                        default:
                            Console.WriteLine("Invalid Input");
                            break;
                    }

                    Console.WriteLine("Do you want to contniue again");
                    option = Convert.ToInt32(Console.ReadLine());



                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }
            } while (option == 1);


        }
    }
}