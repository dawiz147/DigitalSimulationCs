using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalSimulation.Interfaces;
namespace DigitalSimulation
{
    public class BaseStation : IPacketService, IPacketRetranssmisionService
    {
        public BaseStation(int id)
        {
            Id_ = id;
            packet_buffer_ = new Queue<DigitalSimulation.Packet>();
        }
        public int Id_
        {
            get;
            private set;
        }
        public int GetSizeBuffer()
        {
           return packet_buffer_.Count();
        }
        public void AddPacketToRetransmission(DigitalSimulation.Packet packet)
        {
            packet_to_retransmission_ = packet;
        }

        public void AddPacket(DigitalSimulation.Packet packet)
        {
            packet_buffer_.Enqueue(packet);
        }

        public Packet GetPacket()
        {
            return packet_buffer_.Dequeue();
        }

        public Packet GetPacketToRetransmission()
        {
            return packet_to_retransmission_;
        }

        private Queue<DigitalSimulation.Packet> packet_buffer_;//=new Queue<Packet.Packet>();
        private double number_of_packages_removed_ = 0;
        private double number_of_correctly_delivered_packages_ = 0;
        private DigitalSimulation.Packet packet_to_retransmission_ = null;
    }
}
