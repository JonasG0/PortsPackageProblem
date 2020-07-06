using System;
using System.IO.Ports;

namespace Library
{
    public class Ports
    {
        public static void PrintPortNamesToConsole()
        {
            foreach(var port in SerialPort.GetPortNames())
            {
                Console.WriteLine(port);
            }
        }
    }
}
