using System;
using System.Collections.Generic;
using System.Linq;

namespace PrimeMultiplicationTable
{
    public class PrimeGenerator
    {
        public List<int> returnPrimes(int n)
        {
            List<int> primeList = new List<int>() { 2 };
            int count = 1, nextPrimeNumber = 3;

            while ((int)primeList.Count() < n)
            {
                int index = 0;

                while (primeList[index] <= Math.Sqrt(nextPrimeNumber) && (nextPrimeNumber % primeList[index] != 0))
                {
                    index++;
                }

                if (primeList[index] > Math.Sqrt(nextPrimeNumber) && count == 1)
                {
                    primeList.Add(nextPrimeNumber);
                    count = 2;
                    nextPrimeNumber = nextPrimeNumber + 2;
                }

                else if (primeList[index] > Math.Sqrt(nextPrimeNumber) && count == 2)
                {
                    primeList.Add(nextPrimeNumber);

                    if (nextPrimeNumber == 5)
                    {
                        count = 1;
                        nextPrimeNumber = nextPrimeNumber + 2;
                    }

                    else
                    {
                        count = 1;
                        nextPrimeNumber = nextPrimeNumber + 4;
                    }
                }

                else
                {
                    count = 1;
                    nextPrimeNumber = nextPrimeNumber + 2;
                }
            }

            return primeList;
        }
    }
}
