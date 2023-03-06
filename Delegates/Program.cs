using System;

namespace Delegates
{
    class Program
    {
        public delegate void MyDelegate();// void olan ve parametre almayan operasyonlara "delegelik yapıyor." deriz.
        public delegate void MyDelegate2(string text);
        public delegate int MyDelegate3();
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.SendMessage();
            customerManager.ShowAlert();

            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.ShowAlert; //Show alertteki mesajıda ekrana yazar.
            myDelegate -= customerManager.SendMessage; //Send message mesajı ekrana yazmaz.

            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            myDelegate2 += customerManager.ShowAlert2;

            Mathematics mathematics = new Mathematics();
         //   MyDelegate3 myDelegate3 = mathematics.Sum;
         //   var result = myDelegate3(4,5);

            myDelegate();
            Console.ReadLine();
        }
    }

    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello");
        }

        public void ShowAlert()
        {
            Console.WriteLine("Be Careful!");
        }
        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }

        public void ShowAlert2(string alert)
        {
            Console.WriteLine(alert);
        }
    }
    public class Mathematics
    {
        public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Multiplicalition(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
