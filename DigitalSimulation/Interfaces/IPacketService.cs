using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalSimulation.Interfaces
{
    interface IPacketService 
    {
        void AddPacket(Packet packet);
        Packet GetPacket();
    }
}
