using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GenericsHomework.Tests
{
    [TestClass]
    public class NodeTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Append_ValueAlreadyExists_ThrowsException()
        {
            Node<string> node = new("Value");
            node.Append("Value");
        }

        [TestMethod]
        public void Append_ValuesDoNotAlreadyExist_Success()
        {
            Node<string> node = new("Apple");
            node.Append("Banana");
            node.Append("Cherry");
            string actualResult = $"{node} {node.Next} {node.Next.Next} {node.Next.Next.Next}";
            string expectedResult = "Apple Cherry Banana Apple";
            Assert.AreEqual<string>(expectedResult, actualResult);
        }

    }
}