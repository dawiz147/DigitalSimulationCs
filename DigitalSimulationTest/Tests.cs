using Microsoft.VisualStudio.TestTools.UnitTesting;
using DigitalSimulation;

namespace DigitalSimulationTest
{
    [TestClass]
    public class PacketTest
    {
        [TestMethod]
        public void TestGenerateIdForPackage()
        {
            var network = new DigitalSimulation.WirelessNetwork();
            network.GenerateNewIdForPackage();
            Assert.AreEqual(network.ID, 0);
        }

        [TestMethod]
        public void TestPackage()
        {
           int id_package = 10;
            var packet = new DigitalSimulation.Packet(id_package,1.2);
            packet.SaveTimeExitingTheBuffor(5.3);
            packet.SaveTimeExitingTheChannel(10.5);
            Assert.AreEqual(packet.GetID(), id_package);
            Assert.AreEqual(packet.GetTimeBufforBuffor(), 4.1, 0.001);
            Assert.AreEqual(packet.GetTimeBufforChannel(), 9.3, 0.001);
        }
    }
}
