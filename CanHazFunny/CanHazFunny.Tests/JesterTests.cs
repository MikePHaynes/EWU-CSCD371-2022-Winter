using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace CanHazFunny.Tests
{
    [TestClass]
    public class JesterTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_OutputDependencyNull_ThrowsException()
        {
            new Jester(new JokeOutput(), null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_ServiceDependencyNull_ThrowsException()
        {
            new Jester(null, new JokeService());
        }

        [TestMethod]
        public void TellJoke_RetrievesFromJokeService_TellsJokeNotNullOrEmpty()
        {
            StringWriter stringWriter = new();
            Console.SetOut(stringWriter);
            new Jester(new JokeOutput(), new JokeService()).TellJoke();

            Assert.IsNotNull(stringWriter.ToString());
            Assert.AreNotEqual<string>("", stringWriter.ToString());
        }

        [TestMethod]
        public void TellJoke_RetrievesFromJokeService_TellsJokeNotChuckNorris()
        {
            StringWriter stringWriter = new();
            Console.SetOut(stringWriter);
            new Jester(new JokeOutput(), new JokeService()).TellJoke();

            Assert.IsFalse(stringWriter.ToString().Contains("Chuck") || stringWriter.ToString().Contains("Norris"));
        }
    }
}
