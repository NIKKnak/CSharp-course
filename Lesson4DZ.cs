using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpOOP
{
    // найти искомое значение из суммы трех чисел их списка
    public class SummNumbers
    {
        public void Summ(int result)
        {
            

            List<int> numbersDZ = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 45, 65, 98, 15, 87, 15, 854, 34, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            for (int i = 0; i < numbersDZ.Count - 2; i++)
            {
                for (int j = i + 1; j < numbersDZ.Count - 1; j++)
                {
                    for (int k = j + 1; k < numbersDZ.Count; k++)
                    {
                        if (numbersDZ[i] + numbersDZ[j] + numbersDZ[k] == result) // <--- искомая сумма
                        {
                            Console.WriteLine($"Найдены числа: {numbersDZ[i]}, {numbersDZ[j]}, {numbersDZ[k]}");
                          
                        }
                    }
                }
            }

            Console.WriteLine("Не найдены числа, сумма которых равна 10.");



        }


        


    }


}
