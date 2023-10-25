using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpOOP
{
    public class Lesson3DZ
    {


        
            /*
            Есть лабиринт описанный в виде двумерного массива 
            где 1 это стены, 0 - проход, 2 - искомая цель.
            Пример лабиринта:
            1 1 1 1 1 1 1
            1 0 0 0 0 0 1
            1 0 1 1 1 0 1
            0 0 0 0 1 0 2
            1 1 0 0 1 1 1
            1 1 1 1 1 1 1
            1 1 1 1 1 1 1
            Напишите алгоритм определяющий наличие выхода из 
            лабиринта и выводящий на экран координаты точек выхода если таковые имеются.
            */

            int[,] l = new int[,]
            {
            {1, 1, 1, 1, 1, 2, 1 },
            {1, 0, 0, 0, 0, 0, 1 },
            {1, 0, 1, 1, 1, 0, 1 },
            {0, 0, 0, 0, 1, 0, 2 },
            {1, 1, 0, 0, 1, 1, 1 },
            {1, 1, 1, 1, 1, 1, 1 },
            {1, 1, 1, 1, 1, 1, 1 }
            };

            public List<Tuple<int, int>> FindExits(int startI, int startJ)
            {
                var exits = new List<Tuple<int, int>>();

                if (l[startI, startJ] == 1)
                {
                    Console.WriteLine("Начальная точка находится в стене!");
                    return exits;
                }
                else if (l[startI, startJ] == 2)
                {
                    Console.WriteLine("Выход находится на входе!");
                    exits.Add(new Tuple<int, int>(startI, startJ));
                    return exits;
                }

                var stack = new Stack<Tuple<int, int>>();
                stack.Push(new Tuple<int, int>(startI, startJ));

                while (stack.Count > 0)
                {
                    var temp = stack.Pop();

                    if (l[temp.Item1, temp.Item2] == 2)
                    {
                        Console.WriteLine("Выход найден!");
                        exits.Add(new Tuple<int, int>(temp.Item1, temp.Item2));
                    }

                    l[temp.Item1, temp.Item2] = 1;

                    if (temp.Item2 >= 0 && l[temp.Item1, temp.Item2 - 1] != 1)
                        stack.Push(new Tuple<int, int>(temp.Item1, temp.Item2 - 1)); // вверх

                    if (temp.Item2 + 1 < l.GetLength(1) && l[temp.Item1, temp.Item2 + 1] != 1)
                        stack.Push(new Tuple<int, int>(temp.Item1, temp.Item2 + 1)); // низ

                    if (temp.Item1 >= 0 && l[temp.Item1 - 1, temp.Item2] != 1)
                        stack.Push(new Tuple<int, int>(temp.Item1 - 1, temp.Item2)); // лево

                    if (temp.Item1 + 1 < l.GetLength(0) && l[temp.Item1 + 1, temp.Item2] != 1)
                        stack.Push(new Tuple<int, int>(temp.Item1 + 1, temp.Item2)); // право
                }

                return exits;
            }
        }
    }


