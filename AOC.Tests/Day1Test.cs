namespace AOC.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Properties;

    [TestClass]
    public class Day1Test : BaseTest
    {
        [TestMethod]
        public override void Execute()
        {
            var day1 = new Day1(Resources.day1input);

            var result = day1.Execute();

            Assert.AreEqual(232, result);
        }
    }
}
