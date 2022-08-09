using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SimpleMathDataLayer;
using SimpleMathLibrary;
namespace SimpleMathLibraryTestProject

{
    [TestClass] // test suite
    public class SimpleMathUnitTest
    {

        SimpleMath target = null;

        [TestInitialize]
        public void Init()
        {
            Mock<IDbRepository> mock = new Mock<IDbRepository>();
            mock.Setup(m => m.SaveData(1, 1, 1));
            target = new SimpleMath(mock.Object);
        }

        [TestCleanup]
        public void Clean()
        {
            target = null;
        }


        [TestMethod] // test case
        // Feature_Circustance_ExpResult
        public void Sum_WithValidInput_SholdGiveValidResult()
        {
            int actual = target.Sum(10, 10);
            Assert.AreEqual(20, actual);
        }


        [TestMethod]
        [ExpectedException(typeof(InvalidEvenNumberException))]
        public void Sum_WithOddNumbers_ThrowsExp()
        {
            target.Sum(1, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidPositiveNonZeroNumberException))]
        public void Sum_WithZeroOrNegative_ThrowsExp()
        {
            target.Sum(0, 0);
        }
    }


}