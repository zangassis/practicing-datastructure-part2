
using PracticingDataStructurePartTwo.Models;
using System.Collections;
using System.Security.Cryptography;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

BinaryTree tree = new BinaryTree();

// Insert nodes into the binary tree    
tree.Insert(50);
tree.Insert(30);
tree.Insert(70);
tree.Insert(20);
tree.Insert(40);
tree.Insert(60);
tree.Insert(80);

#region Inorder Traversal
Console.WriteLine("Inorder Traversal:");
tree.InorderTraversal(tree.Root);
#endregion

#region Binary Search Tree
int target = 40;
bool found = tree.BinarySearch(tree.Root, target);

if (found)
{
    Console.WriteLine($"Value {target} found in the tree.");
}
else
{
    Console.WriteLine($"Value {target} not found in the tree.");
}
#endregion

#region Heap
// Create a PriorityQueue with string elements and their priorities as int
var queue = new PriorityQueue<string, int>();

// Add elements with their associated priorities
queue.Enqueue("Red", 0);
queue.Enqueue("Blue", 4);
queue.Enqueue("Green", 2);
queue.Enqueue("Gray", 1);

// Dequeue and print elements based on their priorities
while (queue.TryDequeue(out var color, out var priority))
    Console.WriteLine($"Color: {color} - Priority: {priority}");

#endregion

#region Hash
Hashtable hashtable = new Hashtable();

// Implementation a hash function using SHA256
int HashFunction(string key)
{
    using (SHA256 sha256 = SHA256.Create())
    {
        byte[] inputBytes = Encoding.UTF8.GetBytes(key);
        byte[] hashBytes = sha256.ComputeHash(inputBytes);
        return BitConverter.ToInt32(hashBytes, 0); // Convert the first 4 bytes of the hash to an integer
    }
}

// Add key-value pairs to the table
hashtable[HashFunction("2023001")] = "Bob";
hashtable[HashFunction("2023002")] = "Alice";
hashtable[HashFunction("2023003")] = "John";

// Retrieve values using keys
int key1 = HashFunction("2023001");
int key2 = HashFunction("2023002");
int key3 = HashFunction("2023003");

string value1 = (string)hashtable[key1];
string value2 = (string)hashtable[key2];
string value3 = (string)hashtable[key3];

Console.WriteLine("Index associated with key 2023001: " + key1);
Console.WriteLine("Index associated with key 2023002: " + key2);
Console.WriteLine("Index associated with key 2023003: " + key3);

Console.WriteLine("Value associated with key 2023001: " + value1);
Console.WriteLine("Value associated with key 2023002: " + value2);
Console.WriteLine("Value associated with key 2023003: " + value3);

#endregion

app.Run();
