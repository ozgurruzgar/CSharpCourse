using System;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //FourProcess fourProcess = new FourProcess(2,3);
            //Console.WriteLine(fourProcess.Sum(1,2));
            //Console.WriteLine(fourProcess.Sum2());
            //Console.WriteLine(fourProcess.Multiplicalition2());

            var type = typeof(FourProcess);

            //FourProcess fourProcess1 = (FourProcess)Activator.CreateInstance(type,5,6); //Çalışma Anında örnek üretir.
            //Console.WriteLine(fourProcess1.Sum(2,9));
            //Console.WriteLine(fourProcess1.Sum2());

            var instance = (FourProcess)Activator.CreateInstance(type, 5, 6);
            MethodInfo methodInfo=instance.GetType().GetMethod("Sum2");

            Console.WriteLine(methodInfo.Invoke(instance, null));
            Console.WriteLine("------------------------------------------");

            var methods = type.GetMethods();

            foreach (var item in methods)
            {
                Console.WriteLine("Method Name {0}",item.Name);
                foreach (var parameterInfo in item.GetParameters())
                {
                    Console.WriteLine("Parameter Name {0}",parameterInfo.Name);
                }

                foreach (var attribute in item.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute Name : {0}",attribute.GetType().Name);
                }
            }

            Console.ReadLine();
        }
    }
    class FourProcess
    {
        int _num1;
        int _num2;
        public FourProcess(int num1, int num2)
        {
            _num1 = num1;
            _num2 = num2;
        }
        public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Multiplicalition(int num1, int num2)
        {
            return num1 * num2;
        }
        public int Sum2()
        {
            return _num1 + _num2;
        }
        public int Multiplicalition2()
        {
            return _num1 * _num2;
        }
    }
}
