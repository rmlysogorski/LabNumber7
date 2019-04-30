using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber7Take2
{
    class Program
    {
        static void Main(string[] args)
        {
            GetInput G = new GetInput();

            string userName = G.GetString("name", "Please enter your first name: ");
            string userEmail = G.GetString("email", "Please enter your email address: ");
            string userPhone = G.GetString("phone", "Please enter your phone number: ");
            string userDate = G.GetString("date", "Please enter the date: ");
            string userHTML = G.GetString("html", "Please enter an HTML element: ");

        }


    }
}
