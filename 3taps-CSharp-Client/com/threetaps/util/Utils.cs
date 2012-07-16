using System;
using System.Collections.Generic;
using System.Text;

namespace com.threetaps.util
{
	public class Utils
	{
		public static string Join(List<string> strings)
		{
			if (strings != null && strings.Count > 0)
			{
				StringBuilder joinBuffer = new StringBuilder();
				foreach (string iterString in strings)
				{
					joinBuffer.Append(iterString);
					joinBuffer.Append(",");
				}
				joinBuffer.Remove(joinBuffer.Length, 1);
				return joinBuffer.ToString();
			}
			return "";
		}
	}
}

