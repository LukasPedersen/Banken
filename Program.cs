using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banken
{
    class Program
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
                        Menu
                            (
                            "**************** Deposit money ****************\n",
                            $"",
                            $"",
                            $"",
                            $""
                            );
                        Console.ReadLine();
                        break;
                    #endregion
                    #region Case4
                    case '4':
                        Menu
                            (
                            "**************** Withdraw money ****************\n",
                            $"",
                            $"",
                            $"",
                            $""
                            );
                        Console.ReadLine();
                        break;
                    #endregion
                    case 'X':
                        break;
                }
                Menu(title, "(1): Show all accounts", "(2): Create an account", "(3): Deposit money", "(4): Withdraw money");
            }
            while (keyinfo.KeyChar != 'x');
        }
        public static void Menu(string title, string _text1, string _text2, string _text3, string _text4)
        {


            Console.Clear();
            Console.Write("┌───────────────────────────────────────────────┐\n", TextColor(2));
            Console.Write("│", TextColor(2)); Console.Write($"{title}\n", TextColor(1));
            Console.Write("├───────────────────────────────────────────────┤\n", TextColor(2));
            Console.Write("│", TextColor(2)); Console.Write($"{_text1}\n", TextColor(1));
            Console.Write("│", TextColor(2)); Console.Write($"{_text2}\n", TextColor(1));
            Console.Write("│", TextColor(2)); Console.Write($"{_text3}\n", TextColor(1));
            Console.Write("│", TextColor(2)); Console.Write($"{_text4}\n", TextColor(1));
            Console.Write("│", TextColor(2)); Console.Write($"(X): Exit/Back\n", TextColor(1));
            Console.Write("└───────────────────────────────────────────────┘", TextColor(2));
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
        public static string TextColor(int colorCode)
        {
            switch (colorCode)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    return "";
                case 2:
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    return "";
                case 3:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    return "";
                default:
                    return "";
            }
        }
    }
}
