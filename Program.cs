using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSolution
{
    internal class Program
    {
        enum Gender
        {
            Male=1,Female,Unknown=0
        }
        static void Main(string[] args)
        {
			try
			{
                DoTask();
			}
			catch (Exception ex)
			{

                Console.WriteLine(ex.Message);
			}
            finally
            {
                Console.ReadLine();
            }
        }

        private static void DoTask()
        {
            

            QuestionNoA();
            Console.WriteLine();
            QuestionNoB();
            Console.WriteLine();
            QuestionNoC();
            Console.WriteLine();
            QuestionNoD();
            Console.WriteLine();
            QuestionNoF();
            Console.WriteLine();
            QuestionNoE();
        }

        private static void QuestionNoF()
        {
            
            Console.WriteLine("----------------------");
            Console.WriteLine("Exception Handle");
            Console.WriteLine("------------------");         

            int num1 = 50;
            int num2 = 5;
            int result = 0;
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException dobj)
            {

                Console.WriteLine(dobj.Message);
            }
            catch (ArithmeticException aobj)
            {
                Console.WriteLine(aobj.Message);
            }
            catch (FormatException fobj)
            {
                Console.WriteLine(fobj.Message);
            }
            catch (OutOfMemoryException oobj)
            {
                Console.WriteLine(oobj.Message);
            }
            catch (Exception obj) 
            {
                Console.WriteLine(obj.Message);
            }
            finally
            {
                Console.WriteLine("I Am Block");
            }
            Console.WriteLine();
        }

        private static void QuestionNoE()
        {
            Console.WriteLine("Unchecked");
            Console.WriteLine("-----------");

            int max1 = int.MaxValue;
            unchecked
            {
                max1++;
                Console.WriteLine(max1);
            }
            Console.WriteLine();
            Console.WriteLine("Checked");
            Console.WriteLine("---------");

            int max=int.MaxValue;
            checked
            {
                max++;
                Console.WriteLine(max);
            }
        }

        private static void QuestionNoD()
        {
            Console.WriteLine("Method Scope");
            Console.WriteLine("--------------");
            int number1 = 15;
            int number2 = 14;
            SubtractNumber(number1,number2);
            count++;
            SubtractNumber(15,14);
            count++;
            SubtractNumber(num1:15,num2:14);
            count++;
            SubtractNumber(num2:14, num1:15);
            count++;
            SubtractNumber();
            count++;
            SubtractNumber(num1: 15);
            count++;
            SubtractNumber(num2:9);
            count++;
            Console.WriteLine($"The Subtract Method called for: {count}");


        }
        static int count = 0;
        private static void SubtractNumber(int num1=12,int num2=10)
        {
            int result = 0;
            result= num1 - num2;
            Console.WriteLine($"Result is {result}");
        }

        private static void QuestionNoC()
        {
            Console.WriteLine("Arithmatic Operators");
            Console.WriteLine("----------------------");

            int num1 = 25;
            int num2 = 15;
            int result = 0;
            Console.WriteLine();

            result = num1 + num2;
            Console.WriteLine($"Result of {num1} + {num2} = {result}");
            Console.WriteLine();

            result = num1 - num2;
            Console.WriteLine($"Result of {num1} - {num2} = {result}");
            Console.WriteLine();

            result = num1 * num2;
            Console.WriteLine($"Result of {num1} * {num2} = {result}");
            Console.WriteLine();

            result = num1 / num2;
            Console.WriteLine($"Result of {num1} / {num2} = {result}");
            Console.WriteLine();

            Console.WriteLine("Prefix & Postfix");
            Console.WriteLine("-------------------");

            int a = 9;
            Console.WriteLine($"Prefix increment of {a} is {++a}");
            Console.WriteLine();

            int b = 9;
            Console.WriteLine($"Prefix decrement of {b} is {--b}");
            Console.WriteLine();

            int c = 9;
            Console.WriteLine($"Postfix increment of {c} is {c++}");
            Console.WriteLine();

            int d = 9;
            Console.WriteLine($"Postfix decrement of {d} is {d--}");
            Console.WriteLine();
        }

        private static void QuestionNoB()
        {
            Console.WriteLine("Short Circuit");
            Console.WriteLine("-------------");

            int mark = 60;
            if (mark >= 70 && mark < 100)
            {
                Console.WriteLine("Pass");
            } 
            if (mark >50 || mark > 100)
            {
                Console.WriteLine("Ok");
            }
        }

        private static void QuestionNoA()
        {
           
            Console.WriteLine();
            Console.WriteLine("If");
            Console.WriteLine("---------");
           

            int age = 18;
            if (age == 18) 
            {
                Console.WriteLine("You Can Vote");
            }

            Console.WriteLine();
            Console.WriteLine("If Else");
            Console.WriteLine("-----------");
            

            int age1 = 25;
            if (age1 >= 18) 
            {
                Console.WriteLine("You Can Vote");
            }
            else
            {
                Console.WriteLine("You Cant Vote");
            }

            Console.WriteLine();
            Console.WriteLine("If Else If Else");
            Console.WriteLine("-------------");
           

            int age3 = 15;
            if (age3 == 18)
            {
                Console.WriteLine("You Can Vote");
            }
            else if (age3 >= 18) 
            {
                Console.WriteLine("You Can Vote");
            }
            else if(age3 <= 18)
            {
                Console.WriteLine("You Can't Vote");
            }
            Console.WriteLine();
            Console.WriteLine("Switch");
            Console.WriteLine("----------");

            int number = 1;
            switch (number) 
            {
                case 1:
                    Console.WriteLine(Gender.Male);
                    break;
                case 2:
                    Console.WriteLine(Gender.Female);
                    break;
                default:
                    Console.WriteLine(Gender.Unknown);
                    break;

            }
            Console.WriteLine();
            Console.WriteLine("While");
            Console.WriteLine("------------");

            int start = 1;
            int end = 10;
            while (start <= end) 
            {
                Console.WriteLine(start);
                start++;
            }
            Console.WriteLine();
            Console.WriteLine("For");
            Console.WriteLine("-----------");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine("For Each");
            Console.WriteLine("-------------");

            int[] marks = { 80, 60, 40, 20, 10 };
            foreach (int mark in marks)
            {
                Console.WriteLine(mark);
            }
            Console.WriteLine();
            Console.WriteLine("For Each With String Array");
            Console.WriteLine("-----------------------------");

            string[] friends = { "Birds", "Trees", "Mountain", "Animal" };
            foreach (string friend in friends)
            {
                Console.Write(friend+" ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Do While");
            Console.WriteLine("------");

            int start1 = 1;
            int end1 = 10;
            do
            {
                Console.WriteLine(start1);
                start1++;
            }
            while (start1 <= end1);


            

            
        }
    }
}
