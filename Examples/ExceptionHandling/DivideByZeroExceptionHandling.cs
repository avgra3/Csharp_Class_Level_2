using System;

namespace ExceptionHandling;

public class DivideByZeroExceptionHandling
{
    static void Main(string [] args)
    {
        // Determines whether to keep looping
        var continueLoop = true;

        do
        {
            // retrieve user input and calculate quotient
            try
            {
                // int.Parse generates FormatExpression
                // if argument cannot be converted to an integer
                // get numerator
                Console.Write("Please enter an integer numerator: ");
                var numerator = int.Parse(Console.ReadLine());

                // get denominator
                Console.Write("Please enter an integer denominator: ");
                var denominator = int.Parse(Console.ReadLine());

                // Divide the 2 integers, display result
                var result = numerator / denominator;
                var remainder = numerator % denominator;
                if (remainder == 0)
                {
                    Console.WriteLine($"\nResult: {numerator} / {denominator} = {result}10");
                }
                else
                {
                    Console.WriteLine($"\nResult: {numerator} / {denominator} = {result} remainder {remainder}");
                }
                

                // Exit Loop
                continueLoop = false;
            }
            catch (FormatException formatException)
            {
                Console.WriteLine($"\n{formatException.Message}");
                Console.WriteLine("You must enter two integers. Please try again.\n");
            }
            catch (DivideByZeroException divideByZeroException)
            {
                Console.WriteLine($"\n{divideByZeroException.Message}");
                Console.WriteLine("Zero is an invalid denominator. Please try again.\n");
            }
        } while (continueLoop);
        

    }
}