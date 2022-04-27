using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

namespace ConsoleGettingPcInfo.PcInfo {
	class Network {
		public string NetworkInterfaceName { get; set; }
		public string IPv4 { get; set; }
		public string MAC { get; set; }
		public string DNS { get; set; }
		public string DefaultGateway { get; set; }
		public string DHCP { get; set; }
		public Network() {
			GetNetworkInfo();
		}
		public void GetNetworkInfo() {
		}
	}
}
