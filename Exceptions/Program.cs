using System;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();

            //TryCatch();

            //burda ben sana parametresiz bir kod bloğu göndereceğim ve bunun karşılığı kod kümesi

            //ActionDemo();

            Func<int, int, int> add = Sum;
            
            Console.WriteLine(add(3,5));

            Func<int> getRandomNumber = delegate()
            {
                Random random = new Random();
                return random.Next(1,100);
            };

            Console.WriteLine(getRandomNumber);

            Func<int> getRandomNumber2 = () => new Random().Next(1,100);

            Console.WriteLine(getRandomNumber2);

            Console.WriteLine(Sum(2,3));

            static int Sum(int x, int y)
            {
                return x + y;
            }
            Console.ReadLine();
        }

        private static void ActionDemo()
        {
            HandleException(() =>
            {
                Find();
            });
        }

        private static void TryCatch()
        {
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke(); //Çalıştır demek Invoke
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }
        }

        private static void Find()
        {
            List<string> students = new List<string> { "Engin", "Derin", "Salih" };

            if (!students.Contains("Veli"))
            {
                throw new RecordNotFoundException ("Record Not Found.");
            }
            else
            {
                Console.WriteLine("Record Found.");
            }
        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] students = new string[3] { "Engin", "Derin", "Salih" };

                students[3] = "Ahmet";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //InnerExcepiton hata hakkında daha detaylı bilgi verir.
            }
        }
    }
}
