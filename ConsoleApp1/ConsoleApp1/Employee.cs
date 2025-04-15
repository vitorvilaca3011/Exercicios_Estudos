using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee
    {
        public int Id { get; private set;}
        public string Name { get; set; }
        public double Salary { get; set;}

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void increaseSalary(double percentage)
        {
            Salary = Salary + (percentage / 100 * Salary);
        }

        public override string ToString()
        {
            return Id
                + ", "
                + Name
                + ", $ "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
