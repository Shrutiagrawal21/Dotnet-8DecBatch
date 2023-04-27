
using System;
using System.Data.SqlClient;
namespace SQLDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;

            SqlConnection con = null;
            Console.WriteLine("\n 1.insert");
            Console.WriteLine("\n 2.select");
            Console.WriteLine("\n 3.delete");
            Console.WriteLine("\n 4.update");
            Console.WriteLine("\n 5.search");
            int ch = Convert.ToInt32(Console.ReadLine());
            a = @" Data Source = LIN22004682\SQLEXPRESS; Database = Assignment; Integrated Security = SSPI;";
            try
            {



                con = new SqlConnection(a);
                con.Open();



                Console.WriteLine("Connection Open");
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("insertion:");
                        string name = Console.ReadLine();
                        int Sal = Convert.ToInt32(Console.ReadLine());
                        int empid = Convert.ToInt32(Console.ReadLine());



                        SqlCommand cm1 = new SqlCommand($"insert into Empployee values({empid},'{name}',{Sal})", con);
                        cm1.ExecuteNonQuery();
                        Console.WriteLine("successfully inserted");
                        break;
                    case 2:
                        Console.WriteLine("selection:");



                        SqlCommand cm2 = new SqlCommand("select * from Empployee ", con);
                        SqlDataReader a1 = cm2.ExecuteReader();
                        while (a1.Read())
                        {
                            Console.WriteLine(a1["empid"] + " " + a1["empName"] + " " + a1["empSalary"]);
                        }
                        Console.WriteLine("successfully executed");
                        break;
                    case 3:
                        Console.WriteLine("deletion:");
                        name = Console.ReadLine();



                        SqlCommand cm3 = new SqlCommand($"delete from Empployee where  empName = '{name}'", con);
                        cm3.ExecuteNonQuery();
                        Console.WriteLine("successfully delete");
                        break;
                    case 4:
                        Console.WriteLine("Updation:");
                        name = Console.ReadLine();
                        Sal = Convert.ToInt32(Console.ReadLine());




                        SqlCommand cm4 = new SqlCommand($"Update Empployee set empSalary={Sal} where empName ='{name}'", con);
                        cm4.ExecuteNonQuery();
                        Console.WriteLine("successfully Updated");
                        break;
                    case 5:
                        Console.WriteLine("Searching:");
                        Console.WriteLine("enter name:");
                        name = Console.ReadLine();




                        SqlCommand cm5 = new SqlCommand($"select * from Empployee where empName ='{name}'", con);
                        a1 = cm5.ExecuteReader();
                        while (a1.Read())
                        {
                            Console.WriteLine(a1["empid"] + " " + a1["empName"] + " " + a1["empSalary"]);
                        }
                        Console.WriteLine("successfully Updated");
                        break;



                }
            }
            catch (Exception e)
            {
                Console.WriteLine("something went wrong ");
            }
            finally
            {




                con.Close();
            }

        }
    }
}