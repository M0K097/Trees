public class BstNode
{
    public int value { get; set; }
    public BstNode? leftChild;
    public BstNode? rightChild;
    public int height = 1;
    public int balanceFactor = 0;

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

    public virtual BstNode insert(int value, BstNode? node)
    {
        if (node == null)
            node = new BstNode(value);
        else if (value < node.value)
            node.leftChild = insert(value, node.leftChild);
        else if (value > node.value)
            node.rightChild = insert(value, node.rightChild);
        TreeHelper.updateSingleNodeHeight(node);
        return node;
    }
    public void showTree()
    {
        var contentInOrder = TreeHelper.getValuesInOrder(root);
        Console.WriteLine("InOrder: " + string.Join("-", contentInOrder));
        var contentPreOrder = TreeHelper.getValuesPreOrder(root);
        Console.WriteLine("PreOrder: " + string.Join("-", contentPreOrder));
        var contentPostOrder = TreeHelper.getValuesPostOrder(root);
        Console.WriteLine("PostOrder: " + string.Join("-", contentPostOrder));
        var contentDepthFirst = TreeHelper.getValuesDepthSearch(root);
        Console.WriteLine("Depth-First: " + $"{root?.value}-" + string.Join("-", contentDepthFirst));
        TreeHelper.displayTree(root);
    }

    public void deleteValue(int value)
    {
        root = delete(value, root);
    }

    private BstNode? delete(int value, BstNode? node)
    {
        if (node == null)
            return node;
        else if (value < node.value)
            node.leftChild = delete(value, node.leftChild);
        else if (value > node.value)
            node.rightChild = delete(value, node.rightChild);
        else
        {
            if (node.leftChild == null && node.rightChild == null)
                return null;
            else if (node.rightChild == null)
                return node.leftChild;
            else if (node.leftChild == null)
                return  node.rightChild;
            var predecessor = node.leftChild;
            while (predecessor.rightChild != null)
            {
                predecessor = predecessor.rightChild;
            }
            node.value = predecessor.value;
            node.leftChild = delete(predecessor.value, node.leftChild);
        }
        return node;
    }



    public void addRangeofValues(List<int> rangeOfValues)
    {
        foreach (var i in rangeOfValues)
        {
            addValue(i);
        }
    }
}
