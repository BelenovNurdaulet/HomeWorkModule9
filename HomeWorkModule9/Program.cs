using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkModule9
{
    using System;

    class Employee
    {
        protected string name;
        protected int age;
        protected decimal salary;

        public Employee(string name, int age, decimal salary)
        {
            this.name = name;
            this.age = age;
            this.salary = salary;
        }

        public virtual void GetInfo()
        {
            Console.WriteLine($"Имя: {name}, Возраст: {age}, Зарплата: {salary}");
        }

        public virtual decimal CalculateAnnualSalary()
        {
            return salary * 12;
        }
    }

    class Manager : Employee
    {
        private decimal bonus;

        public Manager(string name, int age, decimal salary, decimal bonus)
            : base(name, age, salary)
        {
            this.bonus = bonus;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Бонус: {bonus}");
        }

        public override decimal CalculateAnnualSalary()
        {
            // Учитываем бонус
            return base.CalculateAnnualSalary() + bonus;
        }
    }

    class Developer : Employee
    {
        private int linesOfCodePerDay;

        public Developer(string name, int age, decimal salary, int linesOfCodePerDay)
            : base(name, age, salary)
        {
            this.linesOfCodePerDay = linesOfCodePerDay;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Количество строк кода в день: {linesOfCodePerDay}");
        }

        public override decimal CalculateAnnualSalary()
        {
            // Учитываем дополнительную оплату за количество строк кода
            return base.CalculateAnnualSalary() + (linesOfCodePerDay * 10); // Пример: 10 долларов за каждую строку кода
        }
    }

    class Program
    {
        static void Main()
        {
            Manager manager = new Manager("Евгений Александрович", 25, 700000, 5000);
            Developer developer = new Developer("Беленов Нурдаулет", 19, 1, 200000);

            Console.WriteLine("Информация о Менеджере:");
            manager.GetInfo();
            Console.WriteLine($"Годовая зарплата Менеджера: {manager.CalculateAnnualSalary()}");

            Console.WriteLine("\nИнформация о РазРАБотчике:");
            developer.GetInfo();
            Console.WriteLine($"Годовая зарплата Разработчика: {developer.CalculateAnnualSalary()}");
        }
    }

}
