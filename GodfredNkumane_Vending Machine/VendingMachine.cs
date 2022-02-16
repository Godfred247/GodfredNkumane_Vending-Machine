using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GodfredNkumane_Vending_Machine
{
    class VendingMachine
    {
        const int costOfSnack = 125; //values in cents (1.25 pounds)

        public int total { get; set; }

        public VendingMachine()
        {
            total = 0;
        }

        public void TenderAmount(int coin)
        {
            //Only coins allowed are {1, 2, 5, 10, 20, 50}
            //int[] coin = { 1, 2, 5, 10, 20, 50 };

            switch (coin)
            {
                case 1:
                    total += 1;
                    break;
                case 2:
                    total += 2;
                    break;
                case 5:
                    total += 5;
                    break;
                case 10:
                    total += 10;
                    break;
                case 20:
                    total += 20;
                    break;
                case 50:
                    total += 50;
                    break;
                default:
                    Console.WriteLine("Invalid Entry.");
                    break;
            }

        }
        public void UIDisplay()
        {
            Console.WriteLine("==================");
            Console.WriteLine("=  L - Lunch Bar =");
            Console.WriteLine("=  K - Kit Kat   =");
            Console.WriteLine("=  M - Milo      =");
            Console.WriteLine("=  C - Crunch    =");
            Console.WriteLine("==================");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Please choose a snack:");
            SnackSelected(Convert.ToChar(Console.ReadLine().ToUpper()));
            Console.WriteLine("");
        }

        private void SnackSelected(char snackCode)
        {
            bool validSelection = false;

            while (!validSelection)
            {
                switch(snackCode)
                {
                    case 'L':
                        Console.WriteLine("Thank you for choosing a Lunch Bar chocolate.");
                        Console.WriteLine();
                        validSelection = true;
                        CalculateChange();
                        break;
                    case 'K':
                        Console.WriteLine("Thank you for choosing a Kit Kat chocolate.");
                        Console.WriteLine();
                        validSelection = true;
                        CalculateChange();
                        break;
                    case 'M':
                        Console.WriteLine("Thank you for choosing a Milo chocolate.");
                        Console.WriteLine();
                        validSelection = true;
                        CalculateChange();
                        break;
                    case 'C':
                        Console.WriteLine("Thank you for choosing a Crunch chocolate.");
                        Console.WriteLine();
                        validSelection = true;
                        CalculateChange();
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Please select a valid snack");
                        snackCode = Convert.ToChar(Console.ReadLine().ToUpper());
                        validSelection = false;
                        break;
                }
            }
        }

        public void CalculateChange()
        {
            if (total > costOfSnack)
            {
                Console.WriteLine();
                Console.WriteLine("========================================================");
                Console.WriteLine("* Thank you for using this machine. Your change is {0}c *", total - costOfSnack);
                Console.WriteLine("========================================================");
            }
        }

        public bool InsufficientCoins() //To check if the amount entered is enough for the snack
        {
            if (total >= costOfSnack)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
