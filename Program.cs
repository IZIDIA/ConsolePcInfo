﻿using ConsoleGettingPcInfo.PcInfo;
using Microsoft.Win32;
using Newtonsoft.Json;
using OpenHardwareMonitor.Hardware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGettingPcInfo {
	class Program {
		static void Main(string[] args) {
			Console.WriteLine(JsonConvert.SerializeObject(new OperatingSystemInfo()));
			Console.WriteLine(JsonConvert.SerializeObject(new Specs()));
			Console.WriteLine(JsonConvert.SerializeObject(new Temps()));
			Console.WriteLine(JsonConvert.SerializeObject(new ActiveProcesses()));
			Console.WriteLine(JsonConvert.SerializeObject(new Network()));
			Console.WriteLine(JsonConvert.SerializeObject(new Peripherals()));
			Console.WriteLine(JsonConvert.SerializeObject(new Disks()));
			Console.WriteLine(JsonConvert.SerializeObject(new InstalledPrograms()));
			Console.WriteLine(JsonConvert.SerializeObject(new AutoloadPrograms()));
			Console.WriteLine(JsonConvert.SerializeObject(new Performance()));
			Console.ReadKey();
		}
	}
}
