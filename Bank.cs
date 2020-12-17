using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banken
{
    class Bank : Konti
    {
        Program pg = new Program();

        //Fields
        List<Konti> accounts = new List<Konti>();
        string bankName;
        double bankVault;

        //Constructor
        public Bank(string name, int vault, string _accountname, int _accountNumber) : base(_accountname, _accountNumber)
        {
            bankName = name;
            bankVault = vault;
            NewAccount("lukas", 1);
        }
        /// <summary>
        /// Displays the bank name and how much money the bank has
        /// </summary>
        /// <returns></returns>
        public string Status()
        {
            return $"************** Wellcome to {bankName} ************ \n Money in the vault:               {bankVault:c} ";
        }
        /// <summary>
        /// Takes all accounts and writes them out
        /// </summary>
        public void WriteAll()
        {
            int positionCount = 4;
            foreach (Konti account in accounts)
            {
                Console.SetCursorPosition(0, positionCount);
                Console.Write($"│       ID: ", Program.TextColor(2));
                Console.Write($"{account.AccountNumber}", Program.TextColor(1));
                Console.Write($" │ Name: ", Program.TextColor(2));
                Console.Write($"{account.Name}", Program.TextColor(1));
                Console.Write($" │ Balance: ", Program.TextColor(2));
                Console.Write($"{account.Balance}", Program.TextColor(1));
                positionCount++;
            }
        }
        /// <summary>
        /// Deposit money into an account
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="id"></param>
        public void Deposit(double amount, int id)
        {
            foreach (Konti account in accounts)
            {
                if (account.AccountNumber == id)
                {
                    account.Balance += amount;
                    bankVault += amount;
                    Program.Menu
                    (
                    "************** Deposit money ***************\n",
                    $"{amount}$ has been deposited",
                    $"On the account with the ID of: {id}",
                    $"",
                    $""
                    );
                }
                else
                {
                    Program.Menu
                    (
                    "************** Deposit money ***************\n",
                    $"Couldn't find the account with the ID of {id}",
                    $"Please try again",
                    $"",
                    $""
                    );
                }
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Withdraw money from an account
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="id"></param>
        public void Withdraw(double amount, int id)
        {
            foreach (Konti account in accounts)
            {
                if (account.AccountNumber == id)
                {
                    account.Balance -= amount;
                    bankVault -= amount;
                    Program.Menu
                    (
                    "************** Withdraw money ***************\n",
                    $"{amount}$ has been Withdrawn",
                    $"On the account with the ID of :{id}",
                    $"",
                    $""
                    );
                }
                else
                {
                    Program.Menu
                    (
                    "************** Withdraw money ***************\n",
                    $"Couldn't find the account with the ID of {id}",
                    $"Please try again",
                    $"",
                    $""
                    );
                }
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Creates a new account
        /// </summary>
        /// <param name="name"></param>
        /// <param name="accountNumber"></param>
        public void NewAccount(string name, int accountNumber)
        {
            Konti kon = new Konti(name, accountNumber);
            accounts.Add(kon);
        }
    }
}
