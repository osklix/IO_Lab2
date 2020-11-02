using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TCP_Server_Asynch;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            TCP_Server_A moj = new TCP_Server_A(IPAddress.Parse("127.0.0.1"), 2048);
            moj.Start();
        }
    }
}
