using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Methods
{
    class Program
    {
      
        static void Main(string[] args)
        {
            //argument
            //int result = Sum(3,9);
            //Console.WriteLine(Sum(3,7));
            //Sum(21, 32);
            //Sum(9, 20);

            //Console.WriteLine(result);
            //int number1 = 9;
            //int number2 = 20;
            //Multiply(number1,number2);
            //Console.WriteLine(Avg(7,9));

            //Test(3);
            //int[] arr3 = { 3, 46, 7, 8, 9 };
           
            //Console.WriteLine(Task(arr3));

        }

        static int Task(params int[] arr)
        {
            int result = 0;
            foreach (int num in arr)
            {
                result += num;
            }
            return result;
        }
        static void Test(int number1, int number2 = 6)
        {
            Console.WriteLine(number1 + number2);
        }
        static void Test(int num1)
        {
            Console.WriteLine(num1);
        }
        static void Test(string word)
        {
            Console.WriteLine(word);
        }

      

        static int Sum(int num1,int num2)//parametr
        {
            if (num1 > num2)
            {
                return num1 + num2;
            }
          
                return 0;
            
            
          
        }

       

        static void Multiply(int num1,int num2)
        {
            Console.WriteLine(num1*num2);
        }

        static double Avg(int x,int y)
        {

            int res = Sum(4,9) / 2;
            return res;
        }
        //static void Sum1()
        //{
        //    int num1 = 4;
        //    int num2 = 20;
        //    Console.WriteLine(num1 + num2);
        //}

      
    }
}
