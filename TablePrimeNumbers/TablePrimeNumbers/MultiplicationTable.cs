using System.Collections.Generic;

namespace PrimeMultiplicationTable
{
    public class MultiplicationTable
    {
        public List<List<int>> returnTable(List<int> primeNumbers)
        {
            List<List<int>> table = new List<List<int>>();
            int index = 0;

            foreach (int p in primeNumbers)
            {
                table.Add(new List<int>());

                foreach (int j in primeNumbers)
                {
                    table[index].Add(p * j);
                }
                index++;
            }

            return table;
        }
    }
}