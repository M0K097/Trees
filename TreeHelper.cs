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

    public static void displayTree(BstNode? node)
    {
        var structure = displayTreeStructure(node,0);

        var lastIter = 0;
        foreach(var content in structure)
        {
            if(content[0] > lastIter)
            {
                Console.WriteLine();
                lastIter = content[0];
            }

            Console.Write(content[1]+ $",");
        }
    }
    public static List<int> getValuesDepthSearch(BstNode? node)
    {
       List<int> res = new(); 
       if(node == null)
           return res;
       if(node.leftChild != null)
           res.Add(node.leftChild.value);
       if(node.rightChild != null)
           res.Add(node.rightChild.value);
       res.AddRange(getValuesDepthSearch(node.leftChild));
       res.AddRange(getValuesDepthSearch(node.rightChild));
       return res;
    }

    public static List<List<int>> displayTreeStructure(BstNode? node, int iter)
    {
       List<List<int>> res = new(); 
       if(node == null)
           return res;
       if( iter == 0 )
           res.Add(new List<int>(){iter,node.value}); 
       iter++;
       if(node.leftChild != null)
           res.Add(new List<int>(){iter,node.leftChild.value});
       if(node.rightChild != null)
           res.Add(new List<int>(){iter, node.rightChild.value});

       res.AddRange(displayTreeStructure(node.leftChild, iter));
       res.AddRange(displayTreeStructure(node.rightChild, iter));

       return res;

    }
}
