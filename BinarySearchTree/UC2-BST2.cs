using BinarySearchTree;

public class BinaryTree2
{
    private TreeNode root;

    public BinaryTree2()
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

    public int Size()
    {
        return Size(root);
    }

    private int Size(TreeNode node)
    {
        if (node == null)
        {
            return 0;
        }

        return 1 + Size(node.Left) + Size(node.Right);
    }
}