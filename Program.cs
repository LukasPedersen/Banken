using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banken
{
    //Abstract class to prohibited creation of program object
    public class Program
    {

        static void Main()
        {
            Bank minBank = new Bank("EUC Syd", 49413, "", 0);
            string title;
            Console.Title = "Banken";
            title = minBank.Status();
            Menu(title, "(1): Show all accounts", "(2): Create an account", "(3): Deposit money", "(4): Withdraw money");
            ConsoleKeyInfo keyinfo = new ConsoleKeyInfo();
            do
            {
                keyinfo = Console.ReadKey(true);
                switch (keyinfo.KeyChar)
                {
                    #region Case1
                    case '1':
                        Menu
                            (
                            "************** Show all accounts **************\n",
                            $"",
                            $"",
                            $"",
                            $""
                            );
                        minBank.WriteAll();
                        Console.ReadLine();
                        break;
                    #endregion
                    #region Case2
                    case '2':
                        Menu
                            (
                            "************** Create an account ***************\n",
                            $"Account name: ",
                            $"",
                            $"",
                            $""
                            );
                        Console.SetCursorPosition(15, 4);
                        string name = Console.ReadLine();
                        Console.Clear();
                        Menu
                            (
                            "************** Create an account ***************\n",
                            $"Account name: {name}",
                            $"Account ID:",
                            $"",
                            $""
                            );
                        Console.SetCursorPosition(13, 5);
                        int id = 0;
                        try
                        {
                            id = Convert.ToInt32(Console.ReadLine()); 
                        }
                        catch (FormatException e)
                        {
                            Console.Clear();
                            Console.WriteLine($"An error occurred errormessage: {e.Message}");
                            Console.ReadKey();
                        }
                        
                        Console.Clear();
                        Menu
                            (
                            "************** Create an account ***************\n",
                            $"Account name: {name}",
                            $"Account ID: {id}",
                            $"",
                            $"Is the information displayed correct? Y/N"
                            );
                        Console.SetCursorPosition(30, 6);
                        string key = Console.ReadKey().KeyChar.ToString();
                        Console.Clear();
                        switch (key)
                        {
                            case "y":
                                minBank.NewAccount(name, id);
                                Menu
                            (
                            "************** Create an account ***************\n",
                            $"An account with the Name: {name}",
                            $"And ID: {id} has been created",
                            $"",
                            $""
                            );
                                Console.ReadKey();
                                break;
                            case "n":
                                Main();
                                break;
                            default:
                                Main();
                                break;
                        }
                        break;
                    #endregion
                    #region Case3
                    case '3':
                        double depositAmount = 0;
                        int depositAccountId = 0;
                        Menu
                            (
                            "**************** Deposit money ****************\n",
                            $"Input amount: ",
                            $"",
                            $"",
                            $""
                            );
                        Console.SetCursorPosition(15, 4);
                        try
                        {
                            depositAmount = Convert.ToDouble(Console.ReadLine());
                        }
                        catch (FormatException e)
                        {
                            Console.Clear();
                            Console.WriteLine($"An error occurred errormessage: {e.Message}");
                            Console.ReadKey();
                        }
                        Menu
                            (
                            "**************** Deposit money ****************\n",
                            $"Amount: {depositAmount}$",
                            $"Input account ID: ",
                            $"",
                            $""
                            );
                        Console.SetCursorPosition(19, 5);
                        try
                        {
                            depositAccountId = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (FormatException e)
                        {
                            Console.Clear();
                            Console.WriteLine($"An error occurred errormessage: {e.Message}");
                            Console.ReadKey();
                        }
                        Menu
                            (
                            "**************** Deposit money ****************\n",
                            $"Amount: {depositAmount}$",
                            $"account ID: {depositAccountId}",
                            $"",
                            $"Is the information displayed correct? Y/N"
                            );
                        string key1 = Console.ReadKey().KeyChar.ToString();
                        Console.Clear();
                        switch (key1)
                        {
                            case "y":
                                minBank.Deposit(depositAmount, depositAccountId);
                                break;
                            case "n":
                                Menu
                                (
                                "**************** Deposit money ****************\n",
                                $"Deposit was canceled",
                                $"",
                                $"",
                                $""
                                );
                                Console.ReadKey();
                                break;
                            default:
                                Main();
                                break;
                        }
                        break;

                    #endregion
                    #region Case4
                    case '4':
                        double withdrawAmount = 0;
                        int withdrawAccountId = 0;
                        Menu
                            (
                            "**************** Withdraw money ****************\n",
                            $"Withdraw amount: ",
                            $"",
                            $"",
                            $""
                            );
                        Console.SetCursorPosition(18, 4);
                        try
                        {
                            withdrawAmount = Convert.ToDouble(Console.ReadLine());
                        }
                        catch (FormatException e)
                        {
                            Console.Clear();
                            Console.WriteLine($"An error occurred errormessage: {e.Message}");
                            Console.ReadKey();
                        }
                        Menu
                            (
                            "**************** Withdraw money ****************\n",
                            $"Amount: {withdrawAmount}$",
                            $"Input account ID: ",
                            $"",
                            $""
                            );
                        Console.SetCursorPosition(20, 5);
                        try
                        {
                            withdrawAccountId = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (FormatException e)
                        {
                            Console.Clear();
                            Console.WriteLine($"An error occurred errormessage: {e.Message}");
                            Console.ReadKey();
                        }
                        Menu
                            (
                            "**************** Withdraw money ****************\n",
                            $"Amount: {withdrawAmount}$",
                            $"account ID: {withdrawAccountId}",
                            $"",
                            $"Is the information displayed correct? Y/N"
                            );
                        string key2 = Console.ReadKey().KeyChar.ToString();
                        Console.Clear();
                        switch (key2)
                        {
                            case "y":
                                minBank.Withdraw(withdrawAmount, withdrawAccountId);
                                break;
                            case "n":
                                Menu
                                (
                                "**************** Withdraw money ****************\n",
                                $"Withdraw was canceled",
                                $"",
                                $"",
                                $""
                                );
                                Console.ReadKey();
                                break;
                            default:
                                Main();
                                break;
                        }
                        break;
                    #endregion
                    case 'X':
                        break;
                }
                title = minBank.Status();
                Menu(title, "(1): Show all accounts", "(2): Create an account", "(3): Deposit money", "(4): Withdraw money");
            }
            while (keyinfo.KeyChar != 'x');
        }
        public static void Menu(string title, string _text1, string _text2, string _text3, string _text4)
        {
            Time tm = new Time();
            Day dy = new Day();
            Date dt = new Date();
            Console.Clear();
            Console.Write("┌───────────────────────────────────────────────┐\n", TextColor(Colors.DarkMagenta));
            Console.Write("│", TextColor(Colors.DarkMagenta)); Console.Write($"{title}\n", TextColor(Colors.DarkBlue));
            Console.Write("├───────────────────────────────────────────────┤\n", TextColor(Colors.DarkMagenta));
            Console.Write("│", TextColor(Colors.DarkMagenta)); Console.Write($"{_text1}\n", TextColor(Colors.DarkBlue));
            Console.Write("│", TextColor(Colors.DarkMagenta)); Console.Write($"{_text2}\n", TextColor(Colors.DarkBlue));
            Console.Write("│", TextColor(Colors.DarkMagenta)); Console.Write($"{_text3}\n", TextColor(Colors.DarkBlue));
            Console.Write("│", TextColor(Colors.DarkMagenta)); Console.Write($"{_text4}\n", TextColor(Colors.DarkBlue));
            Console.Write("│", TextColor(Colors.DarkMagenta)); Console.Write($"(X): Exit/Back\n", TextColor(Colors.DarkBlue));
            Console.Write("└───────────────────────────────────────────────┘", TextColor(Colors.DarkMagenta));
            Console.SetCursorPosition(0,10);
            Console.Write($"Time of day: {tm.GetDate()}\nToday is: {dy.GetDate()}\nso it is : {dt.GetDate()}");
            WriteChar(0, 2);
            WriteChar(48, 1);
            WriteChar(48, 2);
            WriteChar(48, 4);
            WriteChar(48, 5);
            WriteChar(48, 6);
            WriteChar(48, 7);
            WriteChar(48, 8);
        }
        public static void WriteChar(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write("│");
        }
        //A enumeration
        public enum Colors { DarkBlue = 1, DarkMagenta = 2 }
        public static string TextColor(Colors c)
        {
            switch (c)
            {
                case Colors.DarkBlue:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    return "";
                case Colors.DarkMagenta:
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    return "";
                    default:
                    return "";
            }
        }
    }
}
