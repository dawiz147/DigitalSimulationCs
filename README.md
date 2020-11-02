# DigitalSimulation C#
## Event scheduling method
 ## Project description:
In the wireless network, broadcasting stations compete for access to the link. At random **CGPk** intervals, the transmitting station generates packets ready to be sent. After gaining access to the link according to the algorithm, the terminal attempts to transmit the oldest packet from its buffer.  The transmission time of messages from the k-th transmitting station to the k-th receiving station is **CTPk**. If the packet transmission was successful, the receiving station sends an ACK (Acknowledgment) for correct message reception. The ACK transmission time is **CTIZ**. If the packet transmission was not successful, the receiving station does not send ACK. The receipt of the packet is considered incorrect if there is a collision or error in the transmission channel. By collision we mean overlapping of any part of one packet with another packet (coming from another transmitter). In addition, each transmission of a packet may end in a TER error. The absence of an ACK message after time (CTPk+ CTIZ) from sending a packet is a signal for the transmitting station to retransmit the packet. Each packet can be retransmitted maximum LR times. Access to the link in case of retransmission is based on the same rules as the original transmission. If, despite the LR repeated attempt to retransmit the packet, the transmitting station rejects the packet and - if its buffer is not empty - tries to transmit the next packet.  
**CGPk** - a random variable with an exponential distribution of intensity L.  
**CTPk** - a random variable with a uniform distribution between {1, 2, ..., 10} ms  
**CTIZ** = 1 ms  
Use the simulation to determine:  
- [ ] The value of parameter L, which will provide an average packet error rate (averaged over K receivers) of no more than 0.1, then:  
- [ ] packet error rate in each receiver measured by dividing the number of packets lost by the number of transmitted packets,
by the average number of retransmitted packets,  
- [ ] system throughput measured by the number of correctly received packets per unit of time,
by the average delay of the packet, i.e. the time between the packet appearing in the buffer and its correct reception,  
- [ ] average waiting time, i.e. the time between the packet appearing in the buffer and leaving it  
- [ ] Make a graph of the dependence of the average number of packet retransmissions on parameter P  
- [ ] Make a graph of the relationship between the system throughput and the average and maximum packet error rate depending on the value of L.


