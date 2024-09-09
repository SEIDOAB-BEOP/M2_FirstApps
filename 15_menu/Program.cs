using Seido.Utilities.SeedGenerator;
using Seido.Utilities.ConsoleInput;

namespace _10_menu;

class Program
{
    public enum enSeason { Winter, Spring, Summer, Fall}
    public class appData {
        public string EnteredString { get; set; }
        public int EnteredInt { get; set; }
        public enSeason EnteredEnum { get; set; }
        public DateTime EnteredDate { get; set; }
    }

    private static appData _appData = new appData();

    static void Main(string[] args)
    {
        Console.WriteLine("15_menu");

        do
        {
            ShowMenu();

            int _menuSel;
            if (!GetMenuSelection(out _menuSel))
            {
                break;
            }

            ProcessMenuSelection(_menuSel, _appData);

        } while (true);

        Console.WriteLine("\nThank you for playing");
    }

    public static void ShowMenu()
    {
        Console.WriteLine("\n\nMenu:");
        Console.WriteLine("1 - Enter an integer");
        Console.WriteLine("2 - Enter a string");
        Console.WriteLine("3 - Enter a date and time");
        Console.WriteLine("4 - Enter an enum");
        Console.WriteLine("5 - Enter multiple input");
        Console.WriteLine("Q - Quit program");
    }

    public static bool GetMenuSelection(out int menuSelection)
    {
        if (!csConsoleInput.TryReadInt32("Enter your selection", 1, 5, out menuSelection))
        {
            return false;
        }
        return true;
    }

    private static void ProcessMenuSelection(int _menuSel, appData _appData)
    {
        switch (_menuSel)
        {
            case 1:
                int _intAnswer;
                if (csConsoleInput.TryReadInt32("Enter an integer", -1, 101, out _intAnswer))
                {
                    Console.WriteLine($"You entered {_intAnswer}");
                    _appData.EnteredInt = _intAnswer;
                }
                break;

            case 2:
                string _strAnswer = null;
                if (csConsoleInput.TryReadString("Enter a string", out _strAnswer))
                {
                    Console.WriteLine($"You entered {_strAnswer}");
                    _appData.EnteredString = _strAnswer;
                }

                break;

            case 3:
                DateTime _dtAnswer = default;
                if (csConsoleInput.TryReadDateTime("Enter a date and time (yy-mm-dd hh:mm)", out _dtAnswer))
                {
                    Console.WriteLine($"You entered {_dtAnswer}");
                    _appData.EnteredDate = _dtAnswer;
                }
                break;

            case 4:
                enSeason _enAnswer = default;
                if (csConsoleInput.TryReadEnum<enSeason>("Enter a Season", out _enAnswer))
                {
                    Console.WriteLine($"You entered {_enAnswer}");
                    _appData.EnteredEnum = _enAnswer;
                }
                break;

            case 5:
                enSeason _enAnswer1 = default;
                string _strAnswer1 = null;
                if (csConsoleInput.TryReadString("Enter first input (string)", out _strAnswer1) &&
                    csConsoleInput.TryReadEnum<enSeason>("Enter second input (Season)", out _enAnswer1))
                {
                    Console.WriteLine($"You entered {_enAnswer1}");
                    Console.WriteLine($"You entered {_strAnswer1}");

                    _appData.EnteredString = _strAnswer1;
                    _appData.EnteredEnum = _enAnswer1;

                }

                break;
        }
    }
}

