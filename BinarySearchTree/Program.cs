

public class Program
{
    static void Main(string[] args)
    {
        // Use Case 1: Creating a Binary Search Tree
        BinaryTree1 binaryTreeUC1 = new BinaryTree1();
        binaryTreeUC1.Add(56);
        binaryTreeUC1.Add(30);
        binaryTreeUC1.Add(22);
        binaryTreeUC1.Add(40);
        binaryTreeUC1.Add(11);
        binaryTreeUC1.Add(3);
        binaryTreeUC1.Add(16);
        binaryTreeUC1.Add(70);
        binaryTreeUC1.Add(60);
        binaryTreeUC1.Add(95);
        binaryTreeUC1.Add(65);
        binaryTreeUC1.Add(63);
        binaryTreeUC1.Add(67);
        Console.WriteLine("Use Case 1: Binary tree size: " + binaryTreeUC1.Size());

        // Use Case 2: Checking the size of the Binary Tree
        BinaryTree2 binaryTreeUC2 = new BinaryTree2();
        binaryTreeUC2.Add(56);
        binaryTreeUC2.Add(30);
        binaryTreeUC2.Add(70);
        binaryTreeUC2.Add(22);
        binaryTreeUC2.Add(40);
        binaryTreeUC2.Add(11);
        binaryTreeUC2.Add(3);
        binaryTreeUC2.Add(16);
        binaryTreeUC2.Add(60);
        binaryTreeUC2.Add(65);
        binaryTreeUC2.Add(63);
        binaryTreeUC2.Add(67);
        binaryTreeUC2.Add(95);
        Console.WriteLine("Use Case 2: Binary tree size: " + binaryTreeUC2.Size());

        // Use Case 3: Searching for a value in the Binary Tree
        BinaryTree3 binaryTreeUC3 = new BinaryTree3();
        binaryTreeUC3.Add(56);
        binaryTreeUC3.Add(30);
        binaryTreeUC3.Add(22);
        binaryTreeUC3.Add(40);
        binaryTreeUC3.Add(11);
        binaryTreeUC3.Add(3);
        binaryTreeUC3.Add(16);
        binaryTreeUC3.Add(70);
        binaryTreeUC3.Add(60);
        binaryTreeUC3.Add(95);
        binaryTreeUC3.Add(65);
        binaryTreeUC3.Add(63);
        binaryTreeUC3.Add(67);

        int searchValue = 63;
        bool found = binaryTreeUC3.Search(searchValue);

        if (found)
        {
            Console.WriteLine($"Use Case 3: Value {searchValue} found in the binary tree.");
        }
        else
        {
            Console.WriteLine($"Use Case 3: Value {searchValue} not found in the binary tree.");
        }
    }
}
