using System;

namespace _3TypeBasics
{
    class Program
    {
        static void Main(string[] args)
        {

            var payer = new User { Balance = int.Parse(Console.ReadLine()) };
            var payee = new User { Balance = int.Parse(Console.ReadLine()) };
            var amount = int.Parse(Console.ReadLine());

            Console.WriteLine(payer.PayTo(payee, amount));
            Console.ReadLine();
        }
    }

    public class User
    {
        public int Balance { get; set; }

        public bool PayTo(User payee, int amount)
        {
            // TODO: Add code here

            // Working Code:
            if (Balance >= amount && payee.Balance + amount > payee.Balance)
            {
                Balance -= amount;
                payee.Balance += amount;
                return true;
            }

            return false;
        }
    }
}
