using Microsoft.VisualStudio.TestTools.UnitTesting;
using DigitalSimulation;

namespace DigitalSimulationTest
{
    [TestClass]
    public class PacketTest
    {
        [TestMethod]
        public void TestPackageID()
        {
            var packet = new Packet(0,1.2);
            Assert.AreEqual(packet.Id_package_, 0);
            var packet2 = new Packet(1,1.2);
            Assert.AreEqual(packet2.Id_package_, 1);
        }
        [TestMethod]
        public void TestPackageTimeBufforBuffor()
        {
            var packet = new Packet(1, 1.2);
            packet.Time_of_exiting_the_buffor_ = 4.2;
            Assert.AreEqual(packet.GetTimeBufforBuffor(), 3.0, 0.001);
        }
        [TestMethod]
        public void TestPackageTimeBufforChannel()
        {
            var packet = new Packet(1, 1.2);
            packet.Time_of_exiting_the_channel_ = 10.5;
            Assert.AreEqual(packet.GetTimeBufforChannel(), 9.3, 0.001);
        }
        [TestMethod]
        public void TestPackageLR()
        {
            var packet = new Packet(1, 1.2);
            Assert.AreEqual(packet.GetLR(), 0);
            packet.IncrementLR();
            Assert.AreEqual(packet.GetLR(), 1);
        }
   

    }
    [TestClass]
    public class BaseStationTest
    {
        [TestMethod]
        public void TestBaseStationClassID()
        {
            var station = new BaseStation(1);
            Assert.AreEqual(station.Id_, 1);

        }
        [TestMethod]
        public void TestBaseStationBuffer()
        {
            var station = new BaseStation(1);
            Assert.AreEqual(station.GetSizeBuffer(), 0);
            var packet = new Packet(1,1.2);
            station.AddPacket(packet);
            Assert.AreEqual(station.GetSizeBuffer(), 1);
            var packet2 = station.GetPacket();
            Assert.AreEqual(station.GetSizeBuffer(), 0);
        }
    }
    [TestClass]
    public class NetworkTest
    {
        [TestMethod]
        public void TestGenerateIdForPackage()
        {
            var network = new WirelessNetwork();
            network.GenerateNewIdForPackage();
            Assert.AreEqual(network.ID, 0);
        }
    }
}
