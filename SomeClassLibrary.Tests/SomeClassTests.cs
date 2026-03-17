namespace SomeClassLibrary.Tests
{
    [TestClass]
    public sealed class SomeClassTests
    {
        [TestMethod]
        public void IdTest()
        {
            SomeClass someClass = new(20);
            Assert.AreEqual(20, someClass.Id);
        }
    }
}
