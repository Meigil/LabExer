using System;
namespace DataTypesApp{

public class DataTypesProgram {
    public static void Main(string[] args) {
        Console.WriteLine ("Enter a pieces of apple: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine ("Enter total price of 6 apple(6): ");
        double b = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine ("=====================================");
        Console.WriteLine ("the total price of 6 apple(6) is " + b);
        Console.WriteLine ("the value of original price is " + b);
        
        int c = (int) b;
        Console.WriteLine ("the value of converted price is " + c);
        Console.WriteLine ("=====================================");
          
       
    }
}
}