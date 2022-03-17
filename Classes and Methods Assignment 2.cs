using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
  public class Class2{
    //takes two integers , sums them it and returns the result
    public int method_two(int required, int optional = 1){
      return required + optional;
    }
    
    
  }
  
	public class Program
	{
		public static void Main(string[] args)
		{
		  Class2 c1 = new Class2();
		  
		  int required;
		  int optional = 1;
		  int result = 0;
		  
		  Console.WriteLine("Please enter two integers, the first one is required, the second is optional");
		  
		    Console.WriteLine("Enter first integer value (required):");
			required = Convert.ToInt32(Console.ReadLine());
			
		
			Console.WriteLine("Enter second integer value (optional) Hit ENTER key to skip optional value:");
            try 
    		  {
    		    optional = Convert.ToInt32(Console.ReadLine());
    		    Console.WriteLine("Calling method_two method with two values ");
                result = c1.method_two( required, optional);
              }
              catch (FormatException) {
                  Console.WriteLine("Calling method_two method with one value ");
                   result = c1.method_two( required);
              }
		  
			Console.WriteLine("method_two method returned : " + result);
			
		}
		
	}
	
}
