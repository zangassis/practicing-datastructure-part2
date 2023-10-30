namespace PracticingDataStructurePartTwo.Models;

public class BinaryTree
{
    public TreeNode Root { get; set; } // Reference to the root node

    public BinaryTree()
    {
        Root = null;
    }

    // Insert a node with the specified data
    public void Insert(int data)
    {
        Root = InsertRecursive(Root, data);
    }

    // Recursive method to insert a node
    private TreeNode InsertRecursive(TreeNode root, int data)
    {
        // If the current node is null, create a new node with the data
        if (root == null)
        {
            root = new TreeNode(data);
            return root;
        }

        // If the data is less than the current node's data, insert on the left
        if (data < root.Data)
        {
            root.Left = InsertRecursive(root.Left, data); // Left child
        }
        // If the data is greater, insert on the right
        else if (data > root.Data)
        {
            root.Right = InsertRecursive(root.Right, data); // Right child
        }

        return root;
    }

    // In-order traversal of the binary tree
    public void InorderTraversal(TreeNode node)
    {
        if (node != null)
        {
            InorderTraversal(node.Left); // Traverse left subtree
            Console.Write(node.Data + " "); // Print current node's data
            InorderTraversal(node.Right); // Traverse right subtree
        }
    }

    public bool BinarySearch(TreeNode node, int target)
    {
        // Base case: If the node is null, the target is not found.
        if (node == null)
        {
            return false;
        }
        // Compare the target value with the current node's data.
        if (target == node.Data)
        {
            return true;  // Found the target value.
        }
        else if (target < node.Data)
        {
            // If the target is smaller, search in the left subtree.
            return BinarySearch(node.Left, target);
        }
        else
        {
            // If the target is larger, search in the right subtree.
            return BinarySearch(node.Right, target);
        }
    }
}