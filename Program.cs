//AVL-Tree from scratch

BinarySearchTree tree = new BinarySearchTree();
List<int> values1 = new(){1,2,3,4,5,10,9,8,7,6};
tree.addRangeofValues(values1);
List<int> values2 = new List<int>(){8,22,55};
tree.addRangeofValues(values2);
tree.deleteValue(4);
tree.deleteValue(7);
tree.deleteValue(5);
tree.deleteValue(6);
tree.deleteValue(2);
List<int> values3 = new List<int>(){800,900,26,2,7,6};
tree.addRangeofValues(values3);
tree.deleteValue(9);
tree.showTree();
