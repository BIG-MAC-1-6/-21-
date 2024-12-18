using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КТ___21_Модификаторы_доступа
{
    public class Student
{
    public string Name;// Поле Name с открытым доступом (public).  Доступно из любого места кода.
    private int age;// Поле Age с закрытым доступом (private). Доступно только внутри класса Student. Используется для инкапсуляции данных, предотвращая случайную модификацию извне класса.
    public int Age// Свойство Age с открытым доступом (public), обеспечивающее контролируемый доступ к полю age.
    {
        get { return age; }
        set
        {
            if (value >= 0) //Проверка на корректность значения
            {
                age = value;
            }
            else
            {
                Console.WriteLine("Возраст не может быть отрицательным!");
            }
        }
    }

    protected string Group;// Поле Group с защищенным доступом (protected). Доступно внутри класса Student и его наследников. Используется для реализации наследования, позволяя дочерним классам обращаться к полю, но скрывая его от внешнего доступа.
    public Student(string name, int age, string group) // Конструктор с открытым доступом(public). Создает объект Student.
    {
        Name = name;
        Age = age;// Используется свойство Age для установки значения с проверкой
        Group = group;
    }

    public void PrintInfo() // Метод с открытым доступом (public). Выводит информацию о студенте.
    {
        Console.WriteLine($"Имя: {Name}, Возраст: {Age}, Группа: {Group}");
    }

    protected void SetGroup(string newGroup)// Метод с защищенным доступом (protected).  Доступен внутри класса и его производных классов. Например, может использоваться в дочернем классе для дополнительной обработки данных.
    {
        Group = newGroup;
    }

    internal int CalculateAgeFromBirthYear(int birthYear) // Метод с внутренним доступом(internal). Доступен только внутри текущей сборки. Используется для ограничения доступа к методу только внутри проекта.
    {
        return DateTime.Now.Year - birthYear;
    }
}
}
