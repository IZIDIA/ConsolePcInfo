using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGettingPcInfo.PcInfo.Devices {
	public class PrinterObject {
		public string Name { get; set; }
		public string Status { get; set; }
		public string Default { get; set; }
		public string Network { get; set; }
		public PrinterObject(string Name, string Status, string Default, string Network) {
			this.Name = Name;
			this.Status = Status;
			this.Default = Default;
			this.Network = Network;
		}
	}
}
