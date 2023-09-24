//
// Antony Gradillas 09/17/2023
// CIS262AD - Fall 2023
// Class 15677
//

try
{
    // input miles driven
    Console.Write("Miles driven: ");
    var milesDriven = double.Parse(Console.ReadLine());
    // input gallons used
    Console.Write("Gallons used: ");
    var gallonsUsed = double.Parse(Console.ReadLine());
    // calculate MPG
    var milesPerGallon = milesDriven / gallonsUsed;
    Console.WriteLine($"Miles per gallon = {milesPerGallon}");
}
catch (FormatException formatException)
{
    Console.WriteLine("Both entries need to be a valid double.");
}
catch (DivideByZeroException divideByZeroException)
{
    Console.WriteLine("You can not divide by zero.");
}


Console.WriteLine("Press any key to continue.");
Console.ReadKey();