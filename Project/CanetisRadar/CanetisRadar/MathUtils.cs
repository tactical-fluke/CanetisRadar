using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanetisRadar
{
	class MathUtils
	{
		public static T Clamp<T>(T x, T min, T max) where T : IComparable
		{
			if (x.CompareTo(min) < 0) return min;
			else if (x.CompareTo(max) > 0) return max;
			else return x;
		}
	}
}
