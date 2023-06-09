using BinarySearchTree;

public class BinaryTree3
{
    private TreeNode root;

    public BinaryTree3()
    {
        root = null;
    }

    public void Add(int value)
    {
        root = AddNode(root, value);
    }

    private TreeNode AddNode(TreeNode node, int value)
    {
        if (node == null)
        {
            return new TreeNode(value);
        }

        if (value < node.Value)
        {
            node.Left = AddNode(node.Left, value);
        }
        else if (value > node.Value)
        {
            node.Right = AddNode(node.Right, value);
        }

        return node;
    }

    public bool Search(int value)
    {
        return SearchNode(root, value);
    }

    private bool SearchNode(TreeNode node, int value)
    {
        if (node == null)
        {
            return false;
        }

        if (node.Value == value)
        {
            return true;
        }

        if (value < node.Value)
        {
            return SearchNode(node.Left, value);
        }
        else
        {
            return SearchNode(node.Right, value);
        }
    }
}