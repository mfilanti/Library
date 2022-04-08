using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fm.Maths
{
	/// <summary>
	/// Math utility
	/// </summary>
	public static class MathUtilsExtensionMethods
	{
		/// <summary>
		/// Const Rad -> Degree
		/// </summary>
		public const double RadToDeg = 180 / Math.PI;

		/// <summary>
		/// Const Degree -> Rad
		/// </summary>
		public const double DegToRad = Math.PI / 180;

		/// <summary>
		/// Tolerance
		/// </summary>
		public static double Tolerance = 0.001;

		/// <summary>
		/// Fine Tolerance
		/// </summary>
		public static double FineTolerance = 0.00001;

		/// <summary>
		/// Rounding
		/// </summary>
		public static int Digits = 3;

		
		/// <summary>
		/// Point + Vector = Point
		/// </summary>
		/// <param name="thisPoint">Point</param>
		/// <param name="right">Vector</param>
		/// <returns>Point</returns>
		public static Point3D Add(Point3D thisPoint, Vector3D right)
		{
			return new Point3D(thisPoint.X + right.X, thisPoint.Y + right.Y, thisPoint.Z + right.Z);
		}

		/// <summary>
		/// Point - Vector = Point
		/// </summary>
		/// <param name="thisPoint">Point</param>
		/// <param name="vector">Vector</param>
		/// <returns>Point</returns>
		public static Point3D Subtraction(Point3D thisPoint, Vector3D vector)
		{
			return new Point3D(thisPoint.X - vector.X, thisPoint.Y - vector.Y, thisPoint.Z - vector.Z);
		}


		/// <summary>
		/// Compare the two points considering the tolerance equal to MathUtils.Tolerance
		/// </summary>
		/// <param name="thisPoint">Point one.</param>
		/// <param name="point">Point Two</param>
		/// <returns><c>true</c> are equals, false otherwise</returns>
		public static bool ApproxEquals(this Point3D thisPoint, Point3D point)
        {
            return (ApproxEquals(thisPoint.X, point.X) && ApproxEquals(thisPoint.Y, point.Y) && ApproxEquals(thisPoint.Z, point.Z));
        }

		/// <summary>
		/// Confronto tra 2 double con tolleranza uguale a MathUtils.Tolerance.
		/// </summary>
		/// <param name="n1"></param>
		/// <param name="n2"></param>
		/// <returns></returns>
		public static bool ApproxEquals(this double n1, double n2)
		{
			return ApproxEquals(n1, n2, Tolerance);
		}

		/// <summary>
		/// Confronto tra 2 double con tolleranza passata come parametro.
		/// </summary>
		/// <param name="n1"></param>
		/// <param name="n2"></param>
		/// <param name="tolerance"></param>
		/// <returns></returns>
		public static bool ApproxEquals(this double n1, double n2, double tolerance)
		{
			return Math.Abs(n1 - n2) < tolerance;
		}
	}
}
