using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankTests
{
    [TestClass]
    public class BankBranchTests
    {
        [TestMethod]
        public void TotalDepositsTest()
        {
            var branch = new BankBranch("amk","bob");
            var deposits = branch.TotalDeposits();
            Assert.AreEqual(0, deposits);
        }
    }
}