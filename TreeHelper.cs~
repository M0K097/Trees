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
}
