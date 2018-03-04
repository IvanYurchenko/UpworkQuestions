using System;

namespace _16ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
            var number = int.Parse(str);
            
            Console.WriteLine(number.IsFibonacci());
            Console.ReadKey();
        }
    }

    static class ExtensionInt
    {
        // TODO: Add your code here

        #region Code
        public static bool IsFibonacci(this int n)
        {
            if (n == 0 && n == 1) return true;

            var a = 0;
            var b = 1;
            while (a <= n)
            {
                var tmp = a + b;
                a = b;
                b = tmp;
                if (n == a) return true;
            }

            return false;
        }
        #endregion
    }
}
