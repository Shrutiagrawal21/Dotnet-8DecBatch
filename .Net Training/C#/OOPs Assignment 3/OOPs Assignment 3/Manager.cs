using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs_Assignment_3
{
    class Manager : Employee 
    {
        private double PetrolA;
        private double FoodA;
        private double OtherA;
        private double GS;
        private int EmpNo;
        private string EmpName;
        private double salary;
        private double TD;
        private double PF;
        private double NetSalary;

        public Manager(int EmpNo, string EmpName, double salary) : base( EmpNo,  EmpName, salary)
        {
            this.EmpNo = EmpNo;
            this.EmpName = EmpName;
            this.salary = salary;
        }

        public new void Calculate()
        {
            PetrolA = (this.salary * 8 )/ 100;
            Console.WriteLine("\nThe Petrol Allowances : " + PetrolA);
            FoodA = (this.salary * 13 )/ 100;
            Console.WriteLine("\nThe Food Allowances: " + FoodA);
            OtherA = (this.salary * 3 )/ 100;
            Console.WriteLine("\nThe Other Allowances:" + OtherA);
            base.CalculateSalary();
            GS = PetrolA + FoodA + OtherA;
            Console.WriteLine("GrossSalary is: " + GS);
        }

        public  override void CalculateSalary()
        {
            PF = (GS * 10) / 100;
            TD = (GS * 18) / 100;
            NetSalary = GS - (PF - TD);
            Console.WriteLine("NetSalary is:" + NetSalary);

        }
    }
}
