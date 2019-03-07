using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cognex.DataMan.SDK;
using Cognex.DataMan.SDK.Discovery;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{

			//Cognex.DataMan.SDK.ConnectionState connectionState = new ConnectionState();
			//Cognex.DataMan.SDK.ReadStringArrivedEventArgs readStringArrivedEventArgs = new ReadStringArrivedEventArgs();

			SerSystemDiscoverer.SystemInfo systemInfo;
			SerSystemDiscoverer discoverer = new SerSystemDiscoverer();

			discoverer.SystemDiscovered += new SerSystemDiscoverer.SystemDiscoveredHandler((si) => {
				Console.WriteLine("Found device: {0} \n {1} \n {2} \n {3} \n {4}", si.Name, si.SerialNumber, si.Baudrate, si.Type, si.PortName);
				systemInfo = si;

			});
			discoverer.Discover();

			//if(systemInfo != null)
			//{

			//	Cognex.DataMan.SDK.SerSystemConnector myConn = new SerSystemConnector("COM5", );
			//}

			//var res = readStringArrivedEventArgs.ReadString;
			Console.ReadLine();
		}
	}
}
