public class BstNode
{
    public int value { get; set; }
    public BstNode? leftChild;
    public BstNode? rightChild;

    public BstNode(int value)
    {
        this.value = value;
    }
}

public class BinarySearchTree
{
    public BstNode? root;

    public void addValue(int value)
    {
        root = insert(value, root);
    }

    private BstNode insert(int value, BstNode? node)
    {
        if (node == null)
            node = new BstNode(value);
        else if (value < node.value)
            node.leftChild = insert(value, node.leftChild);
        else if (value > node.value)
            node.rightChild = insert(value, node.rightChild);

        return node;
    }
    public void showTree()
    {
        var contentInOrder= TreeHelper.getValuesInOrder(root);
        Console.WriteLine("InOrder: " + string.Join("-",contentInOrder));
        var contentPreOrder= TreeHelper.getValuesPreOrder(root);
        Console.WriteLine("PreOrder: " + string.Join("-",contentPreOrder));
        var contentPostOrder= TreeHelper.getValuesPostOrder(root);
        Console.WriteLine("InOrder: " + string.Join("-",contentPostOrder));
        var contentDepthFirst = TreeHelper.getValuesDepthSearch(root);
        Console.WriteLine("Depth-First: "+$"{root?.value}-" + string.Join("-", contentDepthFirst));
        TreeHelper.displayTree(root);
    }
    


    public void addRangeofValues(List<int> rangeOfValues)
    {
        foreach(var i in rangeOfValues)
        {
            addValue(i);
        }
    }
}
