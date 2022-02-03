using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CanHazFunny.Tests
{
    [TestClass]
    public class JesterTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Jester_OutputDependencyNull_ThrowsException()
        {
            new Jester(new JokeOutput(), null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Jester_ServiceDependencyNull_ThrowsException()
        {
            new Jester(null, new JokeService());
        }
        
    }
}
