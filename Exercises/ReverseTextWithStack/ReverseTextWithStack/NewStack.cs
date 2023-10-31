// Antony Gradillas 10/31/2023
// CIS262AD - Fall 2023
// Class 15677
//
namespace ReverseTextWithStack;

public class NewStack : List
{
    // Implement a stack
    // Pass name "stack" to List constructor
    public NewStack() : base("stack"){ }
    
    // Place data value at the top of the stack by inserting
    // data value at front of linked list
    public void Push(object dataValue)
    {
        InsertAtFront(dataValue);
    }
    
    // Remove item from top of stack by removing
    // item at front of linked list
    public object Pop()
    {
        return RemoveFromFront();
    }
}