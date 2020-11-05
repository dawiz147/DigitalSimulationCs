using Microsoft.VisualStudio.TestTools.UnitTesting;
using Packet;
using WirelessNetwork;
namespace DigitalSimulationTest
{
    [TestClass]
    public class PacketTest
    {
        [TestMethod]
        public void TestGenerateIdForPackage()
        {
            var network = new WirelessNetwork.WirelessNetwork();
            network.GenerateNewIdForPackage();
            Assert.AreEqual(network.ID, 0);
        }

        [TestMethod]
        public void TestPackage()
        {
           int id_package = 10;
            var packet = new Packet.Packet(id_package,1.2);
            packet.SaveTimeExitingTheBuffor(5.3);
            packet.SaveTimeExitingTheChannel(10.5);
            Assert.AreEqual(packet.GetID(), id_package);
            Assert.AreEqual(packet.GetTimeBufforBuffor(), 4.1, 0.001);
            Assert.AreEqual(packet.GetTimeBufforChannel(), 9.3, 0.001);
            Assert.AreEqual(packet.GetLR(), 0);
            packet.IncrementLR();
            Assert.AreEqual(packet.GetLR(), 1);
        }
    }
}
