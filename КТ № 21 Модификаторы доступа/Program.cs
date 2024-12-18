using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КТ___21_Модификаторы_доступа
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Student student1 = new Student("Иван Иванов", 20, "ИВТ-1");
            student1.PrintInfo();

            student1.Name = "Петр Петров";
            student1.Age = 22;

            student1.PrintInfo();

            Console.ReadKey();

        }
    }

}
