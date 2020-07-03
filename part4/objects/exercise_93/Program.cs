using System;

namespace exercise_93
{
    class Program
    {
        public static void Main(string[] args)
        {
            // DO NOT TOUCH THE OTHER FILE!
            // Do your code here!
           Account petrinasAccount = new Account("Petrina's account", 100.00);
           
           petrinasAccount.Deposit(20);
         
           Console.WriteLine(petrinasAccount.balance);
        }
    }
}



