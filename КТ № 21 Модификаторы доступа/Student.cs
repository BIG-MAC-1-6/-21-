using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КТ___21_Модификаторы_доступа
{
    public class Student
    {
        public string Name;
        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Возраст не может быть отрицательным!");
                }
            }
        }

        protected string Group;
        public Student(string name, int age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Имя: {Name}, Возраст: {Age}, Группа: {Group}");
        }

        protected void SetGroup(string newGroup)
        {
            Group = newGroup;
        }

        internal int CalculateAgeFromBirthYear(int birthYear)
        {
            return DateTime.Now.Year - birthYear;
        }
    }
}
