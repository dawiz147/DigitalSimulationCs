using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WirelessNetwork
{
    public class WirelessNetwork
    {
        private static int id_package_ = -1;

        public void GenerateNewIdForPackage()
        {
            id_package_++;
        }
        public int ID
        {
            get => id_package_;
        }
        public WirelessNetwork()
        {

        }
    }
}
