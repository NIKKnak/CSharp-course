using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpOOP
{
    
        internal static class EnumerableExtensions
        {
            public static IEnumerable<T> MyWhere<T>(this IEnumerable<T> values, Func<T, bool> predicate)
            {
                foreach (var value in values)
                {
                    if (predicate(value))
                    {
                        yield return value;
                    }
                }
            }

        }

    /*
    Задача 1: Фильтрация и проекция данных с использованием LINQ
    Предоставьте студентам некоторую коллекцию объектов(например, список студентов) и попросите их решить следующие задачи:

    Найти всех студентов, чей возраст меньше 25 лет.
    Вывести имена всех студентов в алфавитном порядке.
    Выбрать студентов, обучающихся на факультете инженерии.
    Посчитать средний возраст студентов.
    Попросите студентов использовать LINQ для решения этих задач.
    */

    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Faculty { get; set; }
    }

    /*
Отсортировать заказы по сумме в убывающем порядке.
Сгруппировать заказы по клиентам и вывести количество заказов для каждого клиента.
Найти клиента с наибольшей суммой заказов.
Вывести список клиентов и общую сумму их заказов.
Попросите студентов использовать LINQ для сортировки и группировки данных.
    */


    class Order
    {
        public int OrderID { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalAmount { get; set; }
    }



}
