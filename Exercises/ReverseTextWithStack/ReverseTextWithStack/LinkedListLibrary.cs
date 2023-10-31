// Antony Gradillas 10/31/2023
// CIS262AD - Fall 2023
// Class 15677
//
namespace ReverseTextWithStack;

public class ListNode
{
    // automatic read-only property Data
    public object Data { get; private set; }
    
    // automatic property Next
    public ListNode Next { get; set; }
    
    //  Constructor to create ListNode that refers to dataValue
    // and is last node in List
    public ListNode(object dataValue) : this(dataValue, null){ }
    
    // Constructor to create ListNode that refers to dataValue
    // and refers to next ListNode in List
    public ListNode(object dataValue, ListNode nextNode)
    {
        Data = dataValue;
        Next = nextNode;
    }
}

// Class List Declaration
public class List
{
    private ListNode firstNode;
    private ListNode lastNode;
    private string name; // String like "list" yo display
    
    // Construct empty List with specified name
    public List(string listName)
    {
        name = listName;
        firstNode = lastNode = null;
    }
    
    // Construct empty List with "list" as its name
    public List() : this("list") { }
    
    // Insert object at front of List. If List is empty,
    // firstNode and lastNode will refer to the same object.
    // Otherwise, firstNode refers to new node
    public void InsertAtFront(object insertItem)
    {
        if (IsEmpty())
        {
            firstNode = lastNode = new ListNode(insertItem);
        }
        else
        {
            firstNode = new ListNode(insertItem, firstNode);
        }
    }
    
    // We dont need to insert at back for stack
    
    // Remove first node from List
    public object RemoveFromFront()
    {
        if (IsEmpty())
        {
            throw new EmptyListException(name);
        }

        object removeItem = firstNode.Data; // Retrieves data
        
        // reset firstNode and lastNode references
        if (firstNode == lastNode)
        {
            firstNode = lastNode = null;
        }
        else
        {
            firstNode = firstNode.Next;
        }

        return removeItem; // Return the removed item
    }
    
    // Don't need to remove last node from List for stack
    
    // Return true if List is empty
    public bool IsEmpty()
    {
        return firstNode == null;
    }
    
    // Output List Contents
    public void Display()
    {
        

        ListNode current = firstNode;
        
        // Output current node data while not at end of list
        while (current != null)
        {
            Console.Write($"{current.Data}");
            current = current.Next;
        }
        
        Console.WriteLine("\n");
    }
}

// Class EmptyList declaration
public class EmptyListException : Exception
{
    // parameterless constructor
    public EmptyListException() : base("The list is empty"){ }
    
    // One-parameter constructor
    public EmptyListException(string name) : base($"The {name} is empty"){ }
    
    // two-parameter constructor
    public EmptyListException(string exception, Exception inner) : base(exception, inner) { }
}