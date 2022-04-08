using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fm.Maths
{
	/// <summary>
	/// 2D Point
	/// </summary>
	public class Point2D
	{
		/// <summary>
		/// X coordinate
		/// </summary>
		public double X { get; set; } = double.NaN;

		/// <summary>
		/// Y coordinate
		/// </summary>
		public double Y { get; set; } = double.NaN;

		/// <summary>
		/// Initialize class <see cref="Point2D"/>
		/// </summary>
		public Point2D()
		{
		}

		/// <summary>
		/// Initialize class <see cref="Point2D"/>
		/// </summary>
		public Point2D(double x, double y)
		{
			X= x;
			Y= y;
		}
	}
}
