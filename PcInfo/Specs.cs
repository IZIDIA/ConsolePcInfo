using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGettingPcInfo.PcInfo {
	public class Specs {
		public List<string> CPUName { get; set; }
		public List<string> CPUCores { get; set; }
		public List<string> CPULogicalCores { get; set; }
		public List<string> GPUName { get; set; }
		public List<string> GPUDriverVersion { get; set; }
		public List<string> MemoryName { get; set; }
		public List<string> MemorySize { get; set; }
		public List<string> MemorySpeed { get; set; }
		public List<string> MotherboardCompanyName { get; set; }
		public List<string> MotherboardModel { get; set; }
		public Specs() {
			GetProcessorInfo();
			GetVideoControllerInfo();
			GetPhysicalMemoryInfo();
			GetMotherboardInfo();
		}
		public void GetProcessorInfo() {
			CPUName = new List<string>();
			CPUCores = new List<string>();
			CPULogicalCores = new List<string>();
			ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");
			foreach (ManagementObject queryObj in searcher.Get()) {
				CPUName.Add(string.Format("{0}", queryObj["Name"]));
				CPUCores.Add(string.Format("{0}", queryObj["NumberOfCores"]));
				CPULogicalCores.Add(string.Format("{0}", queryObj["NumberOfLogicalProcessors"]));
			}
		}
		public void GetVideoControllerInfo() {
			GPUName = new List<string>();
			GPUDriverVersion = new List<string>();
			ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController");
			foreach (ManagementObject queryObj in searcher.Get()) {
				GPUName.Add(string.Format("{0}", queryObj["Caption"]));
				GPUDriverVersion.Add(string.Format("{0}", queryObj["DriverVersion"]));
			}
		}
		public void GetPhysicalMemoryInfo() {
			MemoryName = new List<string>();
			MemorySize = new List<string>();
			MemorySpeed = new List<string>();
			ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PhysicalMemory");
			foreach (ManagementObject queryObj in searcher.Get()) {
				MemoryName.Add(string.Format("{0}", queryObj["PartNumber"]));
				MemorySize.Add(string.Format("{0}", Math.Round(Convert.ToDouble(queryObj["Capacity"]) / 1073741824, 2)));
				MemorySpeed.Add(string.Format("{0}", queryObj["Speed"]));
			}
		}

		public void GetMotherboardInfo() {
			MotherboardCompanyName = new List<string>();
			MotherboardModel = new List<string>();
			ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BaseBoard");
			foreach (ManagementObject queryObj in searcher.Get()) {
				MotherboardCompanyName.Add(string.Format("{0}", queryObj["Manufacturer"]));
				MotherboardModel.Add(string.Format("{0}", queryObj["Product"]));
			}
		}

	}
}
