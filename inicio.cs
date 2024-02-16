            
            using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace test1
{
    internal class exercicios
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How many employees will be registred? ");
            int amount = int.Parse(Console.ReadLine());

            List<Employee> employeeList = new List<Employee>();

            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine($"Emplyooe {i + 1}");

                Console.Write("Id:");
                int id = int.Parse(Console.ReadLine());


                Console.Write("Name:");
                string name = (Console.ReadLine());


                Console.Write("Salary:");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                employeeList.Add(new Employee(id, name, salary));
            }

            Console.Write($"Enter the employee ID that wil have salary increase: ");
            double select = double.Parse(Console.ReadLine());

            Employee selectedEmployee = employeeList.FirstOrDefault(x => x.Id == select);


            if (selectedEmployee != null)
            {
                Console.Write($"Enter the percentage: ");
                double increase = double.Parse(Console.ReadLine());
                selectedEmployee.IncraseSalary(increase);

            }
            else 
            {
                Console.WriteLine("Id not exist");
            }

            Console.WriteLine("Update list of employees");
            foreach (var employee in employeeList)
            {
                Console.WriteLine($"{employee}");
            }
        }
    }
}