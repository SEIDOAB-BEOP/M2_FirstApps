using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Seido {
namespace Utilities {
namespace ConsoleInput
{
    public static class csConsoleInput
    {
        #region User interaction
        public static bool TryReadString(string question, out string answer)
        {
            answer = null;

            Console.WriteLine($"{question} (Empty to quit)?");
            string sInput = Console.ReadLine();
            if (!string.IsNullOrEmpty(sInput) && !string.IsNullOrWhiteSpace(sInput))
            {
                answer = sInput;
                return true;
            }

            return false;
        }
        public static bool TryReadInt32(string question, int minInt, int maxInt, out int answer)
        {
            answer = 0;
            string sInput;
            do
            {
                Console.WriteLine($"{question} (between {minInt} and {maxInt} or Q to quit)?");
                sInput = Console.ReadLine();
                if (int.TryParse(sInput, out answer) && answer >= minInt && answer <= maxInt)
                {
                    return true;
                }
                else if (sInput != "Q" && sInput != "q")
                {
                    Console.WriteLine("Wrong input, please try again.");
                }
            }
            while ((sInput != "Q" && sInput != "q"));
            return false;
        }
        public static bool TryReadDateTime(string question, out DateTime answer)
        {
            answer = default;
            string sInput;
            do
            {
                Console.WriteLine($"{question} (Empty or Q to quit)?");
                sInput = Console.ReadLine();
                if (!string.IsNullOrEmpty(sInput) && !string.IsNullOrWhiteSpace(sInput) &&
                    DateTime.TryParse(sInput, out answer))
                {
                    return true;
                }
                else if (string.IsNullOrEmpty(sInput) || string.IsNullOrWhiteSpace(sInput)
                    || (sInput == "Q") || sInput == "q")
                {
                    return false;
                }
                else if (sInput != "Q" && sInput != "q")
                {
                    Console.WriteLine("Wrong input, please try again.");
                }
            }
            while (true);
        }

        public static bool TryReadEnum<TEnum>(string question, out TEnum answer) where TEnum : struct
        {
            //Prepare submenu for the various Enum Names
            var _names = typeof(TEnum).GetEnumNames();
            var _subMenu = "";
            var _mi = 1;
            foreach (var item in _names)
            {
                _subMenu += $"\n   {_mi++} - {item}";
            }

            //Ask the user to enter an integer as submenu choice
            int _intAnswer = default;
            bool _continue = TryReadInt32(question + _subMenu + "\n", 1, _names.Length, out _intAnswer);

            //Convert menu choice to TEnum
            answer = Enum.Parse<TEnum>(_names[_intAnswer-1]);

            return _continue;

        }
        #endregion
    }

}
}}