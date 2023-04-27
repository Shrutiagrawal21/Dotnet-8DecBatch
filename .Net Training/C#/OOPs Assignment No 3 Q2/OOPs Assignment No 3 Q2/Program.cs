using System;

namespace OOPs_Assignment_No_3_Q2
{
    class MyStack : ICloneable
    {
        int top;
        int maxsize = 10;
        int[] arr = new int[10];





        public object Clone()
        {



            MyStack st = new MyStack();
            st.top = -1;



            return st;
        }



        Boolean push()
        {
            int val;
            if (top == maxsize - 1)
            {



                Console.WriteLine("\n Overflow");
                return false;
            }
            else
            {
                Console.WriteLine("Enter the value?");
                val = Convert.ToInt32(Console.ReadLine());
                top = top + 1;
                arr[top] = val;
                Console.WriteLine("Item pushed");
                return true;
            }
        }



        Boolean pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Underflow");
                return false;
            }



            else



            {
                top = top - 1;
                Console.WriteLine("Item popped");
                return true;
            }
        }
        void show()
        {



            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
            if (top == -1)
            {
                Console.WriteLine("Stack is empty");
            }
        }




        public static void Main()
        {
            MyStack st = new MyStack();
            st.top = -1;
            MyStack s1 = st.Clone() as MyStack;
            int choice = 0;

            Console.WriteLine("\n----------------------------------------------\n");
            while (choice != 4)
            {
                Console.WriteLine("Chose one from the below options...\n");
                Console.WriteLine("\n1.Push\n2.Pop\n3.Show\n4.Exit");
                Console.WriteLine("\n Enter your choice \n");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            st.push();
                            break;
                        }
                    case 2:
                        {
                            st.pop();
                            break;
                        }
                    case 3:
                        {
                            st.show();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Exiting....");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Please Enter valid choice ");
                            break;
                        }
                };
            }
        }




    }

   

}
