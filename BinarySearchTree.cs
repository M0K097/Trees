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

    public void deleteValue(int value)
    {
        delete(value,root);
    }

    private BstNode? delete(int value, BstNode? node)
    {
        if(node == null)
            return node;
        else if(value < node.value)
            node.leftChild = delete(value, node.leftChild);
        else if(value > node.value)
            node.rightChild = delete(value, node.rightChild);
        else
        {
            if(node.leftChild == null && node.rightChild == null)
                node = null;
            else if(node?.leftChild != null && node.rightChild == null)
                node = node.leftChild;
            else if(node?.leftChild == null && node?.rightChild != null)
                node = node.rightChild;
            else if (node?.leftChild != null && node.rightChild != null)
            {
                var predecessor = node.leftChild;
                while(predecessor.leftChild != null)
                {
                    predecessor = predecessor.leftChild;
                }
                node.value = predecessor.value;
                node.leftChild = delete(predecessor.value, node.leftChild);
            }
        }
        return node;
    }
    


    public void addRangeofValues(List<int> rangeOfValues)
    {
        foreach(var i in rangeOfValues)
        {
            addValue(i);
        }
    }
}
