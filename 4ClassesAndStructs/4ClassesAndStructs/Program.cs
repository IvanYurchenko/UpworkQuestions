﻿namespace _4ClassesAndStructs
{
    struct User
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int Balance { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var account = new Account();
        }
    }

    class Account
    {
        private User _user;

        public User User
        {
            get { return _user; }
            set { _user = value; }
        }

        public void IncreaseUserBalance(int amount)
        {
            if (User.Balance + amount > User.Balance && amount > 0)
            {
                User.Balance += amount;
            }
        }

        public Account()
        {
            User.Balance = 0;
        }
    }
}