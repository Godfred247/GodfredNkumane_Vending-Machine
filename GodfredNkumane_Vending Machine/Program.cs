using System;

namespace GodfredNkumane_Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            var machine = new VendingMachine();

            while (!machine.InsufficientCoins()) //As long as it returns a false statement, keep depositing more coins. It will loop until we have enough money to buy a snack
            {
                Console.WriteLine("Please enter a coin (1c, 2c, 5c, 10c, 20c, 50c): ");
                machine.TenderAmount(Convert.ToInt32(Console.ReadLine())); //Add the new amount to running total.
                Console.WriteLine();

                //Once we have enough money, we will display the selections to the user
                
            }
            machine.UIDisplay();

            Console.ReadLine();
        }
    }
}
