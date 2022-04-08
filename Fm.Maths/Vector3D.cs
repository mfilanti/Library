using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fm.Maths
{
	/// <summary>
	/// 3D Vector
	/// </summary>
	public class Vector3D
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
		/// Z coordinate
		/// </summary>
		public double Z { get; set; } = double.NaN;

		/// <summary>
		/// Initialize class <see cref="Vector3D"/>
		/// </summary>
		public Vector3D()
		{

		}

		/// <summary>
		/// Initialize class <see cref="Vector3D"/>
		/// </summary>
		public Vector3D(double x, double y, double z)
		{
			X= x;
			Y= y;
			Z= z;
		}

		/// <summary>
		/// Point has 0.0 value in coordinate
		/// </summary>
		public static Vector3D Zero => new Vector3D(0.0, 0.0, 0.0 );

		/// <summary>
		/// Null Point = (NaN, NaN, NaN)
		/// </summary>
		public static Vector3D NullVector => new Vector3D(double.NaN, double.NaN, double.NaN);
	}
}
