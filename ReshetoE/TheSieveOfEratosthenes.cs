using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReshetoE
{
    public class TheSieveOfEratosthenes
    {
        private int N { get; set; }
        public void LimitNumbers(int n)
        {
            if ((n > 0) && (n < 51))
            {
                N = n;
            }
            else
            {
                N = 0;
            }
        }
        public List<int> ResultGrid() // количество простых чисел.
        {
            if (N == 0)
            {
                return null;
            }
            List<int> NumbersList = new List<int>(); //создаем список из n элементов
            int Number = 2; //первое простое число
            while (NumbersList.Count != N)
            {
                NumbersList.Add(Number); // добавляем каждый элемент

                // производим выкол составных чисел
                for (int i = 0; i < NumbersList.Count; ++i)
                {
                    for (int j = 2; j < Number; ++j)
                    {
                        NumbersList.Remove(NumbersList[i] * j); //составное число
                    }
                }
                Number++; //переходим к след. элементу
            }
            return NumbersList; //возвращаем список
        }
    }
}
