using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber7Take2
{
    class GetInput : ValidateInput
    {
        public string GetString(string code, string message = "Please enter a string: ", string error = "Error - oops, it looks like you forgot to enter something!\n")
        {
            Console.Write(message);
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                PrintInColor(error, ConsoleColor.Red);
                return GetString(code, message, error);
            }
            else if (code == "name")
            {
                if (ValidateName(input))
                {
                    return input;
                }
                else
                {
                    return GetString(code, message, error);
                }
            }
            else if (code == "email")
            {
                if (ValidateEmail(input))
                {
                    return input;
                }
                else
                {
                    return GetString(code, message, error);
                }
            }
            else if (code == "phone")
            {
                if (ValidatePhone(input))
                {
                    return input;
                }
                else
                {
                    return GetString(code, message, error);
                }
            }
            else if (code == "date")
            {
                if (ValidateDate(input))
                {
                    return input;
                }
                else
                {
                    return GetString(code, message, error);
                }
            }
            else if (code == "html")
            {
                if (ValidateHTML(input))
                {
                    return input;
                }
                else
                {
                    return GetString(code, message, error);
                }
            }
            else
            {
                return input;
            }
        }

        public static void PrintInColor(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(message);
            Console.ResetColor();
        }
    }
}
