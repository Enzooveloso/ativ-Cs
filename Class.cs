    using System.Globalization;
using System.Numerics;
using System.Linq;

namespace test1
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employee(int id, string name, double salary)
        {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
        }

        public void IncraseSalary(double cash)
        {
            Salary += Salary * cash / 100.0;
        }
        
        public override string ToString()
        {
            return $"{Id} ,{Name}, {Salary}";
        }
    
    }
}