﻿using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;

namespace CsharpOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*new Lesson3().getArray();
            Console.WriteLine();*/
            //new Lesson3().getArray33();
            /*
                        Men men = new Men("Nik",DateTime.Parse("01.01.2000"),Men.HairStile.Black);
                        GrandFather grandFather = new GrandFather("Alex",DateTime.Parse("01.01.1990"),GrandFather.Beard.Short);
                        Women women = new Women("Julia", DateTime.Parse("02.06.2000"),Women.Decoration.Clock);
                        GrandMother grandMother = new GrandMother("Mari", DateTime.Parse("12.12.1991"),GrandMother.Glasses.Bleck);


                        Men son1 = new Men("Nik", DateTime.Parse("01.01.2000"), Men.HairStile.Black);
                        Men son2 = new Men("Nik", DateTime.Parse("01.01.2000"), Men.HairStile.Black);





                        men.AddFamilyInfo(women, men,grandMother,grandFather,son1,son2);
                        //men.PrintFamelyInfo();

                        for (int i = 0; i < men.Count; i++)
                        {
                            men[i].PrintPerson();
                        }




                        //////////Lesson2//////////////////////////////////

                        var value = new Bits(7);

                        var a = "";
                        try
                        {
                            for (int i = 0; i < 8; i++)
                            {
                                a += value.GetBit(i) ? 1 : 0;

                            }
                            a = string.Join("", a.Reverse());

                            Console.WriteLine(a);
                            Console.WriteLine(value.GetBit(2));

                            value.SetBit(false, 2);
                            Console.WriteLine(value.Value);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }*/

            /*//lesson4 ------------------------------------------------------------------------------------------
             * 
            static void Main(string[] args)
            {
                var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7 };

                var numbers2 = numbers.MyWhere<int>(x => x > 3);

                foreach (var number in numbers2)
                {
                    Console.WriteLine(number);
                }
                //var numbers3 = EnumerableExtensions.MyWhere<int>(numbers, x => x > 3);
            }*/

            /*
    Задача 1: Фильтрация и проекция данных с использованием LINQ
    Предоставьте студентам некоторую коллекцию объектов(например, список студентов) и попросите их решить следующие задачи:

    Найти всех студентов, чей возраст меньше 25 лет.
    Вывести имена всех студентов в алфавитном порядке.
    Выбрать студентов, обучающихся на факультете инженерии.
    Посчитать средний возраст студентов.
    Попросите студентов использовать LINQ для решения этих задач.
    */

            List<Student> students = new List<Student>
            {
                new Student { Name = "Alice", Age = 22, Faculty = "Engineering" },
                new Student { Name = "Bob", Age = 25, Faculty = "Science" },
                new Student { Name = "Bob", Age = 25, Faculty = "Science" },
                new Student { Name = "Charlie", Age = 19, Faculty = "Engineering" },
                new Student { Name = "David", Age = 30, Faculty = "Arts" },
                new Student { Name = "Eve", Age = 21, Faculty = "Science" },
                // Добавьте других студентов по вашему усмотрению
            };

            var findAge = students.Where(x => x.Age < 25);
            var sortName = students.OrderBy(x => x.Name).Select(x => x.Name);
            var findEngeners = students.Where(x => x.Faculty.Equals("Engineering"));
            var aceraEge = students.Average(x => x.Age);

            findAge.ToList().ForEach(x => Console.WriteLine($"{x.Name} - {x.Age}"));
            sortName.ToList().ForEach(x => Console.WriteLine($"{x}, "));
            findEngeners.ToList().ForEach(x => Console.WriteLine($"{x.Name} - {x.Faculty}"));


            // ----------------------------------------------------------------------

            /*
Отсортировать заказы по сумме в убывающем порядке.
Сгруппировать заказы по клиентам и вывести количество заказов для каждого клиента.
Найти клиента с наибольшей суммой заказов.
Вывести список клиентов и общую сумму их заказов.
Попросите студентов использовать LINQ для сортировки и группировки данных.
    */

            List<Order> orders = new List<Order>
            {
                new Order { OrderID = 1, CustomerName = "Alice", OrderDate = new DateTime(2023, 6, 1), TotalAmount = 150.0 },
                new Order { OrderID = 2, CustomerName = "Bob", OrderDate = new DateTime(2023, 6, 2), TotalAmount = 75.5 },
                new Order { OrderID = 3, CustomerName = "Charlie", OrderDate = new DateTime(2023, 6, 2), TotalAmount = 220.0 },
                new Order { OrderID = 4, CustomerName = "David", OrderDate = new DateTime(2023, 6, 3), TotalAmount = 100.0 },
                new Order { OrderID = 5, CustomerName = "Eve", OrderDate = new DateTime(2023, 6, 4), TotalAmount = 85.5 },
            };

            //Отсортировать заказы по сумме в убывающем порядке.
            var sum = orders.OrderByDescending(x => x.TotalAmount);

            var sum2 = from order in orders
                       orderby order.OrderDate
                       select order;
            //Сгруппировать заказы по клиентам и вывести количество заказов для каждого клиента.
            var totalAmountForClient = orders.GroupBy(x => x.CustomerName).Select(x => new { name = x.Key, count = x.Count() });
            //Найти клиента с наибольшей суммой заказов.
            var richClient = orders.GroupBy(x => x.CustomerName)
                .Select(x => new { name = x.Key, sumTotalAmount = x.Sum(ta => ta.TotalAmount) })
                .OrderBy(ta => ta.sumTotalAmount).First().name;
            //Вывести список клиентов и общую сумму их заказов.
            var clientTA = orders.GroupBy(x => x.CustomerName)
                .Select(x => new { name = x.Key, sumTotalAmount = x.Sum(ta => ta.TotalAmount) });



            sum.ToList().ForEach(x => Console.WriteLine($"{x.TotalAmount} - {x.TotalAmount}"));
            totalAmountForClient.ToList().ForEach(x => Console.WriteLine($"{x.name} {x.count} "));
            Console.WriteLine(richClient);
            clientTA.ToList().ForEach(x => Console.WriteLine($"{x.name} {x.sumTotalAmount} "));

            // ----------------------------------------------------------------------


            //В этой задаче у вас есть список строк, и ваша задача – отсортировать этот список
            //в порядке возрастания длины строк,используя лямбда - выражение.
            //Ниже приведены начальные данные и возможное решение:
            List<string> strings = new List<string>
        {
            "Apple",
            "Banana",
            "Cherry",
            "Date",
            "Fig",
            "Grapes"
        };

            var sortList = strings.OrderBy(x => x.Length).ToList();
            sortList.ForEach(Console.WriteLine);
            //или
            strings.OrderBy(x => x.Length).ToList().ForEach(x => Console.WriteLine(x));


            // ----------------------------------------------------------------------

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 45, 65, 98, 15, 87, 15, 854, 34, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            numbers.Sort((x, y) => x.CompareTo(y));

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            // ----------------------------------------------------------------------
           // хотим выбрать все строки, содержащие определенную подстроку,
           // с использованием лямбда-выражения.Вот начальные данные и решение задачи:


            List<string> words = new List<string>
        {
            "apple",
            "banana",
            "cherry",
            "date",
            "grape",
            "kiwi",
            "lemon",
        };

            string searchTerm = "an";

            words.Where(x => x.Contains(searchTerm)).ToList().ForEach(x => Console.WriteLine($"{searchTerm}: содержит: {x}"));


            // ----------------------------------------------------------------------




            List<int> numbers2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 45, 65, 98, 15, 87, 15, 854, 34, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            numbers2.Select(x => x * 2).ToList().ForEach(x => Console.WriteLine(x));

            // ----------------------------------------------------------------------

            //что у нас есть список объектов, и мы хотим отфильтровать этот список
            //по определенному критерию, используя лямбда - выражение.
            //Вот начальные данные и решение задачи:


            List<Order> orders2 = new List<Order>
            {
                new Order { OrderID = 1, CustomerName = "Alice", OrderDate = new DateTime(2023, 6, 1), TotalAmount = 150.0 },
                new Order { OrderID = 2, CustomerName = "Bob", OrderDate = new DateTime(2023, 6, 2), TotalAmount = 75.5 },
                new Order { OrderID = 3, CustomerName = "Charlie", OrderDate = new DateTime(2023, 6, 2), TotalAmount = 220.0 },
                new Order { OrderID = 4, CustomerName = "David", OrderDate = new DateTime(2023, 6, 3), TotalAmount = 100.0 },
                new Order { OrderID = 5, CustomerName = "Eve", OrderDate = new DateTime(2023, 6, 4), TotalAmount = 85.5 },
            };

            string str = "A";

            orders2.Where(x => x.CustomerName.StartsWith("A")).ToList().ForEach(x => Console.WriteLine(x.CustomerName));

            // ----------------------------------------------------------------------

            HashSet<int> hashSet = new HashSet<int> { 1, 2, 3, 4, 5 };
            List<int> list = new List<int> { 3, 4, 5, 6, 7 };


            var result = hashSet.Intersect(list);


            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            // ----------------------------------------------------------------------
            //Дан массив и число. Найдите три числа в массиве сумма которых р
            //авна искомому числу. Подсказка: если взять первое число в массиве,
            //можно ли найти в оставшейся его части два числа равных по сумме первому.

            // Test delegate
            MyDelegate myDelegate = new MyDelegate(DelegateTest.Print);
            myDelegate();


            DelegateTest.Print4();

        }



     

    }


    

}
