using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnPar_Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enter a two digit number
            int num, sum = 0, r;
            Console.WriteLine("Enter a Number : ");
            num = int.Parse(Console.ReadLine());
            while (num != 0)
            {
                r = num % 10;
                num = num / 10;
                sum = sum + r;
            }
            Console.WriteLine("Sum of Digits of the Number : " + sum);
            Console.Write("Do you want to enter another number?(YES/No):" + "\n");
            char y = (char)Console.Read();

            if (Char.IsLetter(y))
            {
                if (Char.IsUpper(y))
                {
                    Console.WriteLine("Continue");
                }
                else
                {
                    Console.WriteLine("Goodbye:");
                }
            }
        }
              

                       

                                  
                    
                    

                    
                    

         
                    

                    
                
       

   