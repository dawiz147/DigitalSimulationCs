using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packet
{
    public class Packet
    {
        public Packet(int id, double create_time)
        {
            id_package_ = id;
            time_to_enter_the_buffer_ = create_time;
        }
        public double GetID()
        {
            return id_package_;
        }
        public void SaveTimeExitingTheBuffor(double time)
        {
            time_of_exiting_the_buffor_ = time;
        }
        public void SaveTimeExitingTheChannel(double time)
        {
            time_of_exiting_the_channel_ = time;
        }
        public double GetTimeBufforBuffor()
        {
            return time_of_exiting_the_buffor_ - time_to_enter_the_buffer_;
        }
        public double GetTimeBufforChannel()
        {
            return time_of_exiting_the_channel_ - time_to_enter_the_buffer_;
        }
        public void IncrementLR()
        {
            LR_++;
        }
        public int GetLR()
        {
            return LR_;
        }
        private int id_package_;
        private double time_to_enter_the_buffer_;
        private double time_of_exiting_the_buffor_;
        private double time_of_exiting_the_channel_;
        private int LR_=0;

    }
}
