using Microsoft.VisualStudio.TestTools.UnitTesting;
using Packet;
using WirelessNetwork;
using BaseStation;
namespace DigitalSimulationTest
{
    [TestClass]
    public class PacketTest
    {
        [TestMethod]
        public void TestPackageID()
        {
            var packet = new Packet.Packet(0,1.2);
            Assert.AreEqual(packet.GetID(), 0);
            var packet2 = new Packet.Packet(1,1.2);
            Assert.AreEqual(packet2.GetID(), 1);
        }
        [TestMethod]
        public void TestPackageTimeBufforBuffor()
        {
            var packet = new Packet.Packet(1, 1.2);
            packet.SaveTimeExitingTheBuffor(5.3);
            packet.SaveTimeExitingTheChannel(10.5);
            Assert.AreEqual(packet.GetTimeBufforBuffor(), 4.1, 0.001);
        }
        [TestMethod]
        public void TestPackageTimeBufforChannel()
        {
            var packet = new Packet.Packet(1, 1.2);
            packet.SaveTimeExitingTheChannel(10.5);
            Assert.AreEqual(packet.GetTimeBufforChannel(), 9.3, 0.001);
            Assert.AreEqual(packet.GetLR(), 0);
            packet.IncrementLR();
            Assert.AreEqual(packet.GetLR(), 1);
        }
        [TestMethod]
        public void TestPackageLR()
        {
            var packet = new Packet.Packet(1, 1.2);
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
            var station = new BaseStation.BaseStation(1);
            Assert.AreEqual(station.GetIdBaseStation(), 1);

        }
        [TestMethod]
        public void TestBaseStationBuffer()
        {
            var station = new BaseStation.BaseStation(1);
            Assert.AreEqual(station.GetSizeBuffer(), 0);
            var packet = new Packet.Packet(1,1.2);
            station.AddPacketToBuffer(packet);
            Assert.AreEqual(station.GetSizeBuffer(), 1);
            var packet2 = station.GetPacketFromBuffer();
            Assert.AreEqual(station.GetSizeBuffer(), 0);
        }
    }
    [TestClass]
    public class NetworkTest
    {
        [TestMethod]
        public void TestGenerateIdForPackage()
        {
            var network = new WirelessNetwork.WirelessNetwork();
            network.GenerateNewIdForPackage();
            Assert.AreEqual(network.ID, 0);
        }
    }
}
