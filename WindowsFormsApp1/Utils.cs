using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotePadMinusMinus
{
	public static class Utils
	{
		public static int Range(int start, int x, int end)
		{
			return Math.Max(start, Math.Min(x, end));
		}
		public static double Range(double start, double x, double end)
		{
			return Math.Max(start, Math.Min(x, end));
		}
	}
}
