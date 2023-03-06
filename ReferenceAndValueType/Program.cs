using System;

namespace ReferenceAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            int number2 = 20;
            number2 = number;
            number = 30;

            Console.WriteLine(number2);

            string[] cities1 = new string[]{ "Ankara", "İstanbul","İzmir" };
            string[] cities2 = new string[]{ "Bursa", "Boly","Balıkesir" };
            cities2 = cities1;
            cities1[0] = "Antalya";
            Console.ReadLine();
        }
    }
}
