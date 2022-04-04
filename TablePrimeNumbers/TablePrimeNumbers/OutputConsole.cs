using System;
using System.Collections.Generic;
using System.Linq;

namespace PrimeMultiplicationTable
{
    class OutputConsole
    {
        static void Main(string[] args)
        {
            PrimeGenerator prime = new PrimeGenerator();
            MultiplicationTable calculation = new MultiplicationTable();
            OutputConsole outputConsole = new OutputConsole();

            while (true)
            {
                List<int> primeNumbers = prime.returnPrimes(outputConsole.InputConsole());
                List<List<int>> multiplicationTable = calculation.returnTable(primeNumbers);

                Console.Write("{0,0}{1,7}", " ", " ");

                foreach (int p in primeNumbers)
                {
                    Console.Write("{0,5}{1,2}", p, " ");
                }

                Console.WriteLine();

                for (int i = 0; i < multiplicationTable.Count(); i++)
                {
                    Console.Write("{0,0}{1,5}{2,2}", " ", primeNumbers[i], " ");

                    for (int j = 0; j < multiplicationTable.Count(); j++)
                    {
                        Console.Write("{0,5}{1,2}", multiplicationTable[i][j], " ");
                    }

                    Console.WriteLine();
                }
            }
        }

        private int InputConsole()
        {
            string inputvalue = "";
            int n = 0;

            while (!(int.TryParse(inputvalue, out n) && n >= 1))
            {
                Console.WriteLine("Write whole number on the console:");
                inputvalue = Console.ReadLine();
            }

            return n;
        }
    }
}