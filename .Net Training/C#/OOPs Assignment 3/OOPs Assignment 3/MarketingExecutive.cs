using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs_Assignment_3
{
    class MarketingExecutive : Employee
    {
        private double KilometerTravel;
        private double TourA;
        private double TelephoneA;
        private double GrossS;
        private double EmpNo;
        private string EmpName;
        private double salary;
        private double TD;
        private double PF;
        private double NetSalary;



        public MarketingExecutive (int EmpNo, string EmpName, double salary,double KilometerTravel):base(EmpNo,EmpName,salary)
        {
            this.EmpNo = EmpNo;
            this.EmpName = EmpName;
            this.salary = salary;
            this.KilometerTravel = KilometerTravel;
        }
        public new void Calculate()
        {
            TourA = 5 * this.KilometerTravel;
            Console.WriteLine("Tour Allowance is:" + TourA);
            TelephoneA = 1000;
            Console.WriteLine("Telephone Allowances is:" + TelephoneA);
            base.CalculateSalary();
            GrossS = GrossSalary + TourA + TelephoneA;
            Console.WriteLine("GrossSalary :" + GrossS);

                 
        }
        public override void CalculateSalary()
        {
            PF = (GrossS * 10) / 100;
            TD = (GrossS * 18) / 100;
            NetSalary = GrossS - (PF - TD);
            Console.WriteLine("NetSalary is:" + NetSalary);

        }

    }
}
