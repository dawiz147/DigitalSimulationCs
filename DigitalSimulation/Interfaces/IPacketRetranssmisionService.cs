using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalSimulation.Interfaces
{
    interface IPacketRetranssmisionService
    {
        void AddPacketToRetransmission(Packet packet);
        Packet GetPacketToRetransmission();
    }
}
