using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UDPNumberSender {
    class Program {
        static void Main(string[] args) {
            int number = 0;

            string ip = "127.0.0.1";
            int port = 9999;
            IPAddress ipAddress = IPAddress.Parse(ip);
            UdpClient udpClient = new UdpClient(ip, port);

            IPEndPoint iPEndPoint = new IPEndPoint(ipAddress, port);

            while(true) {
                Console.WriteLine(number);

                Byte[] send = Encoding.ASCII.GetBytes(number.ToString());
                udpClient.Send(send, send.Length);

                number++;

                Thread.Sleep(100);
            }
        }
    }
}
