using System;
using System.Linq;
namespace ComputerAverageApp{
public class ComputerAverageProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Enter 5 grades seperated by new line:");
        double[] grades = new double[5];
            for (int i = 0; i < 5; i++)
            {
                grades[i] = Convert.ToDouble(Console.ReadLine());
            }

           
       double average = grades.Average();
       int roundedAverage = (int)Math.Round(average); 
       
        Console.WriteLine ("The average is " + average + " and round off to " + roundedAverage);
       
       
        
        
        
    }
}}