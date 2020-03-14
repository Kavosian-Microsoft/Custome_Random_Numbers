﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Number_Generator
{
    /// <summary>
    /// This simple projects gets two numbers as upper and lower limits of the
    /// range and generates a random number in this range
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Random Number Generator (RNG)";
            try
            {
                int intStart, intEnd;
                Console.Write("\n\tEnter start number of the the range:");
                intStart = int.Parse(Console.ReadLine());
                Console.Write("\n\tEnter Last number of the the range:");
                intEnd= int.Parse(Console.ReadLine());
                Random rnd = new Random(DateTime.Now.Second);
                Console.Clear();
                Console.Write("\n\tRange [{0},{1}) : ===> {2}",intStart,intEnd,rnd.Next(intStart,intEnd)); ;
                
            }//try
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n\tAn exception has occured");                
            }//catch
            Console.Write("\n\tPlease press any key to exit...");
            Console.ReadKey();
        }//Main
    }//Program
}//Random_Number_Generator
