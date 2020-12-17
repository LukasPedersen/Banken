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
        List<Konti> accounts = new List<Konti>();
        string bankName;
        double bankVault;
        public Bank(string name, int vault, string _accountname, int _accountNumber) : base(_accountname, _accountNumber)
        {
            bankName = name;
            bankVault = vault;
        }
        public string Status()
        {
            return $"************** Wellcome to {bankName} ************ \n Money in the vault:               {bankVault:c} ";
        }
        public void WriteAll()
        {
            int positionCount = 4;
            foreach (Konti account in accounts)
            {
                Console.SetCursorPosition(0, positionCount);
                Console.Write($"│   ID: ");
                Console.Write($"{account.AccountNumber}", Program.TextColor(1));
                Console.Write($"   │   Name: ", Program.TextColor(2));
                Console.Write($"{account.Name}", Program.TextColor(1));
                Console.Write($"   │   Balance: ", Program.TextColor(2));
                Console.Write($"{account.Balance}", Program.TextColor(1));
                positionCount++;
            }
        }
        public void NewAccount(string name, int accountNumber)
        {
            Konti kon = new Konti(name, accountNumber);
            accounts.Add(kon);
        }
    }
}
