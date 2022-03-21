using System;
using System.Collections.Generic;
using System.Text;

namespace LabFinalProblemPractice
{
    class DhakaBank
    {
        public int Balance{ get; set; }
        private void PrintCurrentBalance()
        {
            Console.WriteLine("Your current balance is " + Balance);
        }
        public void Deposit(int amount)
        {
            Balance += amount;
            Console.WriteLine("You just deposit " + amount + " tk");
            PrintCurrentBalance();
        }

        public void Withdraw(int amount)
        {
            Balance -= amount;
            Console.WriteLine("You just withdraw " + amount + " tk");
            PrintCurrentBalance();
        }

    }
    class Qus4
    {
        static public void ans()
        {
            DhakaBank dhk = new DhakaBank();
            dhk.Deposit(250000);
            dhk.Withdraw(500);

        }
    }
}
