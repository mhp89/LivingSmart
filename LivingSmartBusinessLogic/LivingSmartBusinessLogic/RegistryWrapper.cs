using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace LivingSmartForms.Classes
{
	public static class RegistryWrapper
	{
		//Opretter adgang til Windows Registry. Readonly sikre at den ikke kan blive ændret under runtime.
		public static readonly RegistryKey RegKey = Registry.CurrentUser.CreateSubKey(@"Software\DMU14A\LivingSmart");
		public static void RemoveKey(String key)
		{
			if (RegKey.GetValue(key) != null)
				RegKey.DeleteValue(key);
		}
	}
}
