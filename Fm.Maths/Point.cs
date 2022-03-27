namespace Fm.Maths
{
	/// <summary>
	/// Math definition of point
	/// </summary>
	public class Point
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
		/// Point has 0.0 value in coordinate
		/// </summary>
		public static Point Zero => new Point() { X = 0, Y = 0, Z = 0 };
	}
}