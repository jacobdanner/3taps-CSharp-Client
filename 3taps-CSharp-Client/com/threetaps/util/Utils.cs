using System;

namespace ThreeTaps
{
	public class Utils
	{
		public static String join(List<String> strings)
		{
			if (strings != null && strings.size() > 0)
			{
				StringBuffer joinBuffer = new StringBuffer();
				foreach (String iter_string in strings)
				{
					joinBuffer.append(iter_string);
					joinBuffer.append(",");
				}
				joinBuffer.deleteCharAt(joinBuffer.length() - 1);
				return joinBuffer.toString();
			}
			return "";
		}
	}
}

