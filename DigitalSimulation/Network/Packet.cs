using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalSimulation
{
    public class Packet
    {
        public Packet(int id,double create_time)
        {
            Id_package_ = id;
            Time_to_enter_the_buffer_ = create_time;
        }

        public int Id_package_ 
        { 
            get; 
        }
        public double Time_of_exiting_the_buffor_
        {
            private get;
            set;
        }
        public double Time_to_enter_the_buffer_
        {
            get;
        }
        public double Time_of_exiting_the_channel_
        {
            private get;
            set;
        }
        public double GetTimeBufforBuffor()
        {
            return Time_of_exiting_the_buffor_ - Time_to_enter_the_buffer_;
        }
        public double GetTimeBufforChannel()
        {
            return Time_of_exiting_the_channel_ - Time_to_enter_the_buffer_;
        }
        public void IncrementLR()
        {
            LR_++;
        }
        public int GetLR()
        {
            return LR_;
        }

        private int LR_=0;

    }
}
