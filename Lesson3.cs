using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CsharpOOP
{
    internal class Lesson3
    {

        public void getArray()
        {




            List<int> ints = new List<int> { 0, 1, 1, -1, 101, 102, 101, 11, 1111, 11 };

            List<int> array = new List<int>();

            foreach (var item in ints)
            {
                if (!array.Contains(item))
                {
                    array.Add(item);
                }
            }


            array.ForEach(Console.WriteLine);

        }


        public void getArray2()
        {
            List<int> ints = new List<int> { 0, 1, 1, -1, 101, 102, 101, 11, 1111, 11 };

            ints = ints.Distinct().ToList();


            ints.ForEach(Console.WriteLine);


        }


        /*Дан список целых чисел(числа не последовательны), 
        в котором некоторые числа повторяются.Выведите список чисел на экран,
        расположив их в порядке возрастания частоты повторения*/



        public void getArray3()
        {
            List<int> ints = new List<int> { 1, 2, 2, 2, 3, 4, 4, 5, 5, 5, 5, 6, 7, 0 };

            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach (var value in ints)
            {

                if (dict.ContainsKey(value))
                {
                    dict[value]++;
                }
                else
                {
                    dict.Add(value, 1);
                }
            }
            dict = dict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in dict)
            {
                Console.WriteLine(item);
            }




        }


        public void getArray33()
        {
            List<int> ints2 = new List<int> { 1, 2, 2, 2, 3, 4, 4, 5, 5, 5, 5, 6, 7, 0 };

            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();


            foreach (int i in ints2)
            {
                if (!dict.ContainsKey(i))
                {
                    var list = new List<int>
        {
            i
        };
                    dict[i] = list;
                }
                else
                {
                    var list = dict[i];
                    list.Add(i);
                    dict[i] = list;
                }
            }

            var dict2 = dict.OrderByDescending(x => x.Value.Count).ToDictionary(x => x.Key, x => x.Value);
            var listResult = new List<int>();
            foreach (var item in dict2)
            {
                foreach (int value in item.Value)
                {
                    listResult.Add(value);
                }
            }

            listResult.ForEach(Console.Write);





        }



        /*Есть лабиринт описанный в виде двумерного массива
        где 1 это стены, 0 - проход, 2 - искомая цель.

        Напишите алгоритм определяющий наличие выхода из лабиринта
        и выводящий на экран  координаты точки выхода если таковые имеются.



        Модифицируйте код предыдущей задачи таким
        образом чтобы вывод элементов был в порядке
        убывания частоты их повторения*/

        /* startI,startJ это точка начала пути-откуда мы начинаем проходить лабиринт.
        l - массив описывающий лабиринт.*/

        public void getArray4()
        {
            List<int> ints = new List<int> { 1, 2, 2, 2, 3, 4, 4, 5, 5, 5, 5, 6, 7, 0 };

            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach (var value in ints)
            {

                if (dict.ContainsKey(value))
                {
                    dict[value]++;
                }
                else
                {
                    dict.Add(value, 1);
                }
            }
            dict = dict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in dict)
            {
                Console.WriteLine(item);
            }


            

        }








    }

}
