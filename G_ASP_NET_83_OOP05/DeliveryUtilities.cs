using System;
using System.Collections.Generic;
using System.Text;

namespace G_ASP_NET_83_OOP05
{

    // Static Class
    public static class DeliveryUtilities
    {

        public static void PrintSeparator_single() {
            Console.WriteLine("-------------------------------");

        }

        public static void PrintSeparator() {
            Console.WriteLine("===============================");
        }
        public static void PrintSystemTitle(string title)
        {
            Console.WriteLine($"{title}");
        }
    }
}
