using System;
using System.IO.Ports;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace initativeForms
{
    public class Connection
    {
        public SerialPort Port { get; set; }

        public Connection(SerialPort port) 
        {
            port.NewLine= "\n";
            port.ReadTimeout = 5000;
            Port = port;
        }
        
        public bool SendMessage(string message)
        {
            throw new NotImplementedException();
        }

        public static string[] GetPorts()
        {
            string[] ports = SerialPort.GetPortNames();
            if (ports.Length <= 0)
            {
                throw new InvalidOperationException("No available serial ports");
            }
            return ports;
        }
    }
}
