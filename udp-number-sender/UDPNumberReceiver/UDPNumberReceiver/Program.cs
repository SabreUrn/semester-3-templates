using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace UDPNumberReceiver {
    class Program {
        static void Main(string[] args) {
            string ip = "127.0.0.1";
            int port = 9999;

            UdpClient udpServer = new UdpClient(port);
            IPAddress iPAddress = IPAddress.Parse(ip);
            IPEndPoint iPEndPoint = new IPEndPoint(iPAddress, port);

            while(true) {
                Byte[] receive = udpServer.Receive(ref iPEndPoint);
                Console.WriteLine(Encoding.ASCII.GetString(receive));
            }
        }
    }
}
