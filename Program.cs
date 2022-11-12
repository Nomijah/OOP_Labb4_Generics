using System;
using System.Collections.Generic;

namespace OOP_Labb4_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create employees
            Employee e1 = new Employee(101, "Anas", "Male", 20000);
            Employee e2 = new Employee(102, "Hanna", "Female", 30000);
            Employee e3 = new Employee(103, "Tobias", "Male", 40000);
            Employee e4 = new Employee(104, "Sara", "Female", 40000);
            Employee e5 = new Employee(105, "Anna", "Female", 50000);

            // Create stack
            Stack<Employee> empStack = new Stack<Employee>();
            // Put objects in stack
            empStack.Push(e1);
            empStack.Push(e2);
            empStack.Push(e3);
            empStack.Push(e4);
            empStack.Push(e5);

            // Print all objects in stack
            foreach (Employee e in empStack)
            {
                Console.WriteLine($"{e._id} - {e._name} - {e._gender}" +
                    $" - {e._salary}");
                Console.WriteLine($"Items left in the stack = {empStack.Count}");
            }

            Console.WriteLine("----------------------------------");

            Console.WriteLine("Retrieved using Pop method.");

            // Print and remove objects in stack
            for (int i = empStack.Count; i>0; i--)
            {
                Employee e = empStack.Pop();
                Console.WriteLine($"{e._id} - {e._name} - {e._gender}" +
                    $" - {e._salary}");
                Console.WriteLine($"Items left in the stack = {empStack.Count}");
            }

            // Put objects back in stack
            empStack.Push(e1);
            empStack.Push(e2);
            empStack.Push(e3);
            empStack.Push(e4);
            empStack.Push(e5);

            Console.WriteLine("----------------------------------");

            // Print two objects using Peek method
            for (int i = 2; i > 0; i--)
            {
                Employee e = empStack.Peek();
                Console.WriteLine($"{e._id} - {e._name} - {e._gender}" +
                    $" - {e._salary}");
                Console.WriteLine($"Items left in the stack = {empStack.Count}");
            }

            Console.WriteLine("----------------------------------");

            // Check if stack contains e3
            if (empStack.Contains(e3))
            {
                Console.WriteLine("e3 is in the stack.");
            }
            else
            {
                Console.WriteLine("e3 is not in the stack");
            }

            Console.WriteLine("----------------------------------");

            // Create a list and put the employees in it
            List<Employee> empList = new List<Employee>() { e1, e2, e3, e4, e5 };

            // Check if employee 2 is in the list
            if (empList.Contains(e2))
            {
                Console.WriteLine("Employee2 object exists in the list.");
            }
            else
            {
                Console.WriteLine("Employee2 object does not exist in the list.");
            }

            Console.WriteLine("----------------------------------");

            // Find and print the first male in the list
            Employee emp = empList.Find(e => e._gender == "Male");
            Console.WriteLine($"{emp._id} - {emp._name} - {emp._gender}" +
                    $" - {emp._salary}");

            Console.WriteLine("----------------------------------");

            // Find and print all male employees in the list
            List<Employee> maleList = empList.FindAll(e => e._gender == "Male");
            foreach (Employee em in maleList)
            {
                Console.WriteLine($"{em._id} - {em._name} - {em._gender}" +
                    $" - {em._salary}");
            }
        }
    }
}
