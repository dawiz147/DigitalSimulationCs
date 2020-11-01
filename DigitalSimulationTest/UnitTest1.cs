using Microsoft.VisualStudio.TestTools.UnitTesting;
using DigitalSimulation;
namespace DigitalSimulationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGenerateIdForPackage()
        {
            WirelessNetwork network = new DigitalSimulation.WirelessNetwork();
            network.GenerateNewIdForPackage();
            Assert.AreEqual(network.ID, 0);
        }
    }
}
