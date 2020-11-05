using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System;
//using System.Collections;
using Packet;
namespace BaseStation
{
    class BaseStation
    {
        private int id_;
        private Queue<Packet.Packet> packet_buffer_;//=new Queue<Packet.Packet>();
        private double number_of_packages_removed_=0;
        private double number_of_correctly_delivered_packages_=0;
        private Packet.Packet packet_to_retransmission_=null;
        public BaseStation(int id)
        {
            id_ = id;
            packet_buffer_ = new Queue<Packet.Packet>();
        }
        public void AddPacketToBuffer(Packet.Packet packet)
        {
            packet_buffer_.Enqueue(packet);
        }
        public int GetSizeBuffer()
        {
           return packet_buffer_.Count();
        }
        public Packet.Packet GetPacketFromBuffer()
        {
          return packet_buffer_.Dequeue();
        }
    }
}
