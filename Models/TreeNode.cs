namespace PracticingDataStructurePartTwo.Models;

public class TreeNode
{
    public int Data { get; set; }
    public TreeNode Left { get; set; }
    public TreeNode Right { get; set; }

    public TreeNode(int data)
    {
        Data = data;
        Left = null;
        Right = null;
    }
}