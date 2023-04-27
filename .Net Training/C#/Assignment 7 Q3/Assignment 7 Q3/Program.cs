using System;

namespace Assignment_7_Q3
{
   
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Emp Id : ");
                int id = Convert.ToInt32(Console.ReadLine());



                Console.WriteLine("Enter Emp name : ");
                string name = Console.ReadLine();



                Console.WriteLine("Enter Emp salary : ");
                double sal = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("How much Kilometer to Travel:");
                double KilometerTravel = Convert.ToDouble(Console.ReadLine());

                if (id == null || id <= 0)
                {
                    Console.WriteLine("ID cannot be null or zero");
                }
                else if (name == null)
                {
                    Console.WriteLine("Invalid Name");
                }
                else if (sal == 0)
                {
                    Console.WriteLine("Invalid Salary");
                }

                else
                {

                    Employee e = new Employee(id, name, sal);
                    e.CalculateSalary();
                    e.displayDetails();
                    Manager m = new Manager(id, name, sal);
                    m.Calculate();
                    m.CalculateSalary();

                    MarketingExecutive V = new MarketingExecutive(id, name, sal, KilometerTravel);
                    V.Calculate();
                    V.CalculateSalary();


                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }


        }
    }
}
