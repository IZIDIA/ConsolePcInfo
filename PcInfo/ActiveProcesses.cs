﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGettingPcInfo.PcInfo {
	public class ActiveProcesses {
		public List<string> ActiveProcessesList { get; set; }
		public ActiveProcesses() {
			GetActiveProcessesList();
		}
		public void GetActiveProcessesList() {
			ActiveProcessesList = new List<string>();
			var processCollection = Process.GetProcesses();
			foreach (Process p in processCollection) {
				ActiveProcessesList.Add(p.ProcessName);
			}
		}
	}
}
