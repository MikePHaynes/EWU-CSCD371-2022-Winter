using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenericsHomework.Tests
{
    [TestClass]
    public class NodeTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Node<int> node1 = new(6);
            Node<string> node2 = new("Hello");
            Assert.AreEqual(6, node1.Value);
            Assert.AreEqual("Hello", node2.Value);
        }
    }
}