using System;
using System.Collections.Generic;
using System.Text;

namespace G_ASP_NET_83_OOP05
{
    public class Validations
    {
        public static bool IsValidName(string name)
        {

            foreach (char c in name)
            {
                if (char.IsDigit(c))
                    return false;
            }
            if (!string.IsNullOrEmpty(name) || name.Length < 4 || name.Length > 20)
                return false;

            return true;

        }
        public static string ReadValidString(string message)
        {

            string name;
            while (true)
            {
                Console.Write(message);
                name = Console.ReadLine();
                if (IsValidName(name))
                {
                    Console.WriteLine("Invalid input. Please enter a valid  string.");
                }
                else
                {

                    return name.Trim();
                }


            }
        }

        public static string ValidName_digitallowed(string message)
        {
            string name;
            while (true)
            {
                Console.Write(message);
                name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Invalid input. Please enter a valid name.");
                }
                else
                {
                    return name.Trim();
                }
            }

        }
        public static int ReadValidPositiveInt(string message)
        {
            int value;
            while (true)
            {
                Console.Write(message);
                if (!int.TryParse(Console.ReadLine(), out value) || value <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a valid positive integer.");
                }
                else
                {
                    return value;
                }
            }
        }


        public static decimal ReadValidPositiveDecimal(string message)
        {
            decimal value;
            while (true)
            {
                Console.Write(message);
                if (!decimal.TryParse(Console.ReadLine(), out value) || value <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a valid positive decimal.");
                }
                else
                {
                    return value;
                }
            }
        }

        public static string ValidPhoneNumber(string message)
        {
            string number;
            while (true)
            {
                Console.Write(message);
                number = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(number) || number.Length != 11)
                {
                    Console.WriteLine("Invalid input. Please enter a valid Phone Number.");
                }
                else
                {
                    return number;
                }
            }
        }

    }
}
