using NUnit.Framework;

namespace BinaryTreeTests
{
    public class BinaryTreeTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BinaryTreeInsertElement_Element_InsertsAtRightPlace()
        {
            BinaryTree.BinaryTree tree = new BinaryTree.BinaryTree();
            tree.InsertElement(5);
            tree.InsertElement(7);
            tree.InsertElement(6);
            tree.InsertElement(4);
            tree.InsertElement(2);
            Assert.AreEqual(tree.root.data, 5);
            Assert.AreEqual(tree.root.right.data, 7);
            Assert.AreEqual(tree.root.right.left.data, 6);
            Assert.AreEqual(tree.root.left.data, 4);
            Assert.AreEqual(tree.root.left.left.data, 2);
        }
    }
}