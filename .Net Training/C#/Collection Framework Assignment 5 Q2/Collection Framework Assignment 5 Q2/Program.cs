using System;
using System.Collections;
namespace Collection_Framework_Assignment_5_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of Employees you want to store:");
            int size = Convert.ToInt32(Console.ReadLine());
            ArrayList employeeList = new ArrayList();



            Console.WriteLine("Enter employee data");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter Id");
                int id = Convert.ToInt32(Console.ReadLine());



                Console.WriteLine("Enter Name");
                string name = Console.ReadLine();



                Console.WriteLine("Enter Salary");
                double sal = Convert.ToDouble(Console.ReadLine());



                //creating employee object
                employeeList.Add(new Employee(id, name, sal));
            }
            Console.WriteLine("------Displaying Employee List--------");
            foreach (Object o in employeeList)
            {
                Console.WriteLine(o + "\n");
            }
        }
    }
}
