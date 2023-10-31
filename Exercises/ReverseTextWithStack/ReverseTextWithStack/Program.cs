// Antony Gradillas 10/31/2023
// CIS262AD - Fall 2023
// Class 15677
//
using ReverseTextWithStack;

// Create a new stack
NewStack stack = new NewStack();

Console.Write("Enter a phrase: ");
string enteredMessage = Console.ReadLine();

// Break the entered string into individual characters
// add to the stack
foreach (char c in enteredMessage)
{   
    // Add each element to the stack
    stack.Push(c);
}

// Return each element of the stack (should be in reverse order).
Console.Write("The stack returns: ");
stack.Display();

// End commands
Console.WriteLine("Press any key to continue.");
Console.ReadKey();