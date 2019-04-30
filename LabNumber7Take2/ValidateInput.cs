using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LabNumber7Take2
{
    class ValidateInput
    {
        public bool ValidateName(string name, string message = "The name {0} is valid!")
        {
            try
            {
                if (!Regex.IsMatch(name[0].ToString(), "([A-Z])") || Regex.IsMatch(name.Substring(1), "([^a-z])") || name.Length > 30)
                {
                    throw new Exception("Names must start with a capital letter, contain only letters, and be 30 characters or less.");
                }
                else
                {
                    GetInput.PrintInColor(string.Format(message, name) + "\n", ConsoleColor.Green);
                }
                return true;
            }
            catch (Exception E)
            {
                GetInput.PrintInColor(E.Message + "\n", ConsoleColor.Red);
                return false;
            }
            
        }

        public bool ValidateEmail(string email, string message = "The email address {0} is valid!")
        {
            try
            {
                if (!Regex.IsMatch(email, @"([0-9a-zA-Z]){5,30}(@)([a-zA-Z]){5,10}(.)([a-zA-Z]){2,3}"))
                {
                    throw new Exception("Email addresses must be in the following format:\n{5-30 alphanumeric characters}@{5-10 alphanumeric characters}.{com/co/net/etc.}");
                }
                else
                {
                    GetInput.PrintInColor(string.Format(message, email) + "\n", ConsoleColor.Green);
                }
                return true;
            }
            catch(Exception E)
            {
                GetInput.PrintInColor(E.Message + "\n", ConsoleColor.Red);
                return false;
            }   
        }

        public bool ValidatePhone(string phone, string message = "The phone number {0} is valid!")
        {
            try
            {
                if ("(".Any(phone.Contains))
                {
                    phone = phone.Replace('(', ' ');

                }

                if (")".Any(phone.Contains))
                {
                    phone = phone.Replace(')', ' ');
                }

                if ("-".Any(phone.Contains))
                {
                    phone = phone.Replace('-', ' ');
                }

                phone = Regex.Replace(phone, " ", "");

                if (!Regex.IsMatch(phone, @"^\d{10}$"))
                {
                    throw new Exception("Phone number should be only 10 digits ###-###-####. ");
                }
                else
                {
                    GetInput.PrintInColor(string.Format(message, phone.Insert(6, "-").Insert(3, "-")) + "\n", ConsoleColor.Green);
                }
                return true;
            }
            catch(Exception E)
            {
                GetInput.PrintInColor(E.Message + "\n", ConsoleColor.Red);
                return false;
            }            
        }

        public bool ValidateDate(string date, string message = "The date {0} is valid!")
        {
            try
            {
                if (!Regex.IsMatch(date, @"^\d{2}\/\d{2}\/\d{4}$"))
                {
                    throw new Exception("Please enter the date in the format DD/MM/YYYY.");
                }
                else
                {
                    if(!DateTime.TryParse(date, out DateTime D))
                    {
                        throw new Exception("Please enter a valid date. ");
                    }
                    else
                    {
                        GetInput.PrintInColor(string.Format(message, date) + "\n", ConsoleColor.Green);
                    }                    
                }
                return true;
            }
            catch (Exception E)
            {
                GetInput.PrintInColor(E.Message + "\n", ConsoleColor.Red);
                return false;
            }

        }

        public bool ValidateHTML(string html, string message = "The html element {0} is valid!")
        {
            try
            {
                if (!Regex.IsMatch(html, @"^(<)([a-zA-Z0-9]+)(>)(.*)(<)(\/)([a-zA-Z0-9]+)(>)$"))
                {
                    throw new Exception("Please enter an HTML element in the format <tag> text </tag>.");
                }
                else
                {
                    GetInput.PrintInColor(string.Format(message, html) + "\n", ConsoleColor.Green);
                }
                return true;
            }
            catch (Exception E)
            {
                GetInput.PrintInColor(E.Message + "\n", ConsoleColor.Red);
                return false;
            }

        }
    }
}
