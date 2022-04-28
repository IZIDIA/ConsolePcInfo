using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Management;
using System.Net;
using System.Net.Sockets;
using NetInfo;

namespace ConsoleGettingPcInfo.PcInfo {
	class Network {
		//public string NetworkInterfaceName { get; set; }
		//public string IPv4 { get; set; }
		//public string MAC { get; set; }
		public AdapterInfo adapterInfo { get; set; }
		//public string DefaultGateway { get; set; }
		//public string DHCP { get; set; }
		public Network() {
		//	GetIPv4();
		//	GetMac();
			GetDnsAdress();
		}
	/*	public void GetIPv4() {
			IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
			foreach (IPAddress ip in host.AddressList) {
				if (ip.AddressFamily == AddressFamily.InterNetwork) {
					IPv4 = ip.ToString();
				}
			}
		}
		public void GetMac() {
			string macAddresses = string.Empty;
			foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces()) {
				if (nic.OperationalStatus == OperationalStatus.Up) {
					macAddresses = nic.GetPhysicalAddress().ToString();
					break;
				}
			}
			if (macAddresses.Length != 12) {
				MAC = "Error";
			}
			macAddresses = macAddresses.Insert(2, ":");
			macAddresses = macAddresses.Insert(5, ":");
			macAddresses = macAddresses.Insert(8, ":");
			macAddresses = macAddresses.Insert(11, ":");
			macAddresses = macAddresses.Insert(14, ":");
			MAC = macAddresses;
		}*/
		private void GetDnsAdress() {
			adapterInfo = AdapterInfo.CreateInstance();
		}

	}
}
