using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace dotNET_module_13_practice
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            
            List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
            numbers.Sort();
            int secondMax = numbers[numbers.Count - 2]; 
            int secondMaxIndex = numbers.LastIndexOf(secondMax); 
            Console.WriteLine($"Позиция второго максимального значения: {secondMaxIndex}, значение: {secondMax}");
            numbers.RemoveAll(n => n % 2 != 0); 

            
            List<double> doubles = new List<double> { 10.5, 20.7, 30.2, 40.1, 50.9 };
            double average = doubles.Average(); 
            var greaterThanAverage = doubles.Where(d => d > average); 
            foreach (var number in greaterThanAverage)
            {
                Console.WriteLine(number);
            }

           
            List<string> lines = File.ReadAllLines("input.txt").ToList(); 
            lines.Reverse();
            File.WriteAllLines("output.txt", lines);

      
            List<Employee> employees = new List<Employee>(); 



            var underTenThousand = employees.Where(emp => emp.Salary < 10000); 
            var aboveTenThousand = employees.Where(emp => emp.Salary >= 10000); 

            foreach (var emp in underTenThousand.Concat(aboveTenThousand)) 
            {
                Console.WriteLine($"{emp.LastName}, {emp.FirstName}, {emp.Salary}");
            }
        }
    }

}
