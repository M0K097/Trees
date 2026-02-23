public static class TreeHelper
{
    public static List<int> getValuesInOrder(BstNode? node)
    {
        List<int> res = new();
        if (node == null)
            return res;
        res.AddRange(getValuesInOrder(node.leftChild));
        res.Add(node.value);
        res.AddRange(getValuesInOrder(node.rightChild));

        return res;
    }

    public static List<int> getValuesPreOrder(BstNode? node)
    {
        List<int> res = new();
        if (node == null)
            return res;
        res.Add(node.value);
        res.AddRange(getValuesPreOrder(node.leftChild));
        res.AddRange(getValuesPreOrder(node.rightChild));

        return res;
    }

    public static List<int> getValuesPostOrder(BstNode? node)
    {
        List<int> res = new();
        if (node == null)
            return res;
        res.AddRange(getValuesPostOrder(node.leftChild));
        res.AddRange(getValuesPostOrder(node.rightChild));
        res.Add(node.value);

        return res;
    }

    public static void updateSingleNodeHeight(BstNode node)
    {
        int leftHeight = 0;
        int rightHeight = 0;
        if (node.leftChild != null)
            leftHeight = node.leftChild.height;
        if(node.rightChild != null)
            rightHeight = node.rightChild.height;

        node.height =  1 + Math.Max(leftHeight,rightHeight);
        node.balanceFactor =  rightHeight - leftHeight;
    }


    public static void updateTreeBalance(BinarySearchTree tree)
    {
        calculateNodeHeight(tree.root);

    }
    public static int calculateNodeHeight(BstNode? node)
    {
        if(node == null)
            return 0;
        
        int leftHeight = calculateNodeHeight(node.leftChild);
        int rightHeight = calculateNodeHeight(node.rightChild);

        node.height = 1 + Math.Max(leftHeight,rightHeight); 
        node.balanceFactor = rightHeight - leftHeight;
        return node.height;
    }

}
