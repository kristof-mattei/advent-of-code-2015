namespace AOC.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Properties;

    [TestClass]
    public class Day2Test : BaseTest
    {
        [TestMethod]
        public override void Execute()
        {
            var day2 = new Day2(Resources.day2input);

            var result = day2.Execute();

            Assert.AreEqual(1606483, result);
        }
    }
}
