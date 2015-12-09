namespace AOC.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Properties;

    [TestClass]
    public class Day3Test : BaseTest
    {
        [TestMethod]
        public override void Execute()
        {
            var day3 = new Day3(Resources.day2input);

            var result = day3.Execute();

            Assert.AreEqual(1606483, result);
        }
    }
}
