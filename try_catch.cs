//C# Example of try-catch block 

using System;

class TryCatch
{
public static void Main(String[] ar)
{
	//Local variables 
	int a=10, b=0, c;
		
	//Defining the try-catch block
	try
	{
		//ArithmeticException i.e. Divide by zero exception is thrown here
		c=a/b; 	
		
		Console.WriteLine(c);
	}	
	catch(DivideByZeroException exp) //matching ArithmeticExcecption is declared in "catch block"
	{
		//Printing the message associated to the caught exception	
		Console.WriteLine("We have an Exception - "+ exp); 
	}		

	Console.WriteLine("Outside try-catch block");
} 		
}