namespace Fm.Maths
{
	/// <summary>
	/// Math definition of point
	/// </summary>
	public class Point3D
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
		/// Initialize class <see cref="Point3D"/>
		/// </summary>
		public Point3D()
		{

		}

		/// <summary>
		/// Initialize class <see cref="Point3D"/>
		/// </summary>
		public Point3D(double x, double y, double z)
		{
			X = x;
			Y = y;
			Z = z;
		}

		#region Public Methods

		/// <summary>
		/// Set\Get value by index
		/// </summary>
		/// <param name="index">component index</param>
		/// <returns>Value</returns>
		public double this[int index]
		{
			get
			{
				double result;
				switch (index)
				{
					case 0:
						return X;

					case 1:
						return Y;

					case 2:
						return Z;
				}
				return double.NaN;
			}
			set
			{
				switch (index)
				{
					case 0:
						X = value;
						break;

					case 1:
						Y = value;
						break;

					case 2:
						Z = value;
						break;
				}
			}
		}

		/// <summary>
		/// Testo
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return string.Format("({0}, {1}, {2})", X, Y, Z);
		}

		/// <summary>
		/// Distance
		/// </summary>
		/// <param name="point">Other point</param>
		/// <returns>Distance</returns>
		public double Distance(Point3D point)
		{
			return Math.Sqrt(Math.Pow(X - point.X, 2) + Math.Pow(Y - point.Y, 2) + Math.Pow(Z - point.Z, 2));
		}

		/// <summary>
		/// Distance ^ 2
		/// </summary>
		/// <param name="point">Other point</param>
		/// <returns>Distance ^ 2</returns>
		public double DistanceSqr(Point3D point)
		{
			return Math.Pow(X - point.X, 2) + Math.Pow(Y - point.Y, 2) + Math.Pow(Z - point.Z, 2);
		}

		/// <summary>
		/// It Check  Nan Component
		/// </summary>
		/// <returns><c>true</c> one or more component is NaN.</returns>
		public bool IsNullPoint() => double.IsNaN(X) || double.IsNaN(Y) || double.IsNaN(Z);

		/// <summary>
		/// Hash
		/// </summary>
		/// <returns></returns>
		public override int GetHashCode() => X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode();

		/// <summary>
		/// Equals
		/// </summary>
		/// <param name="other">other</param>
		/// <returns><c>true</c>is equals, false otherwise.</returns>
		public override bool Equals(object? other)
		{
			return other is Point3D point && X == point.X && Y == point.Y && Z == point.Z;
		}

		/// <summary>
		/// It division scalar
		/// </summary>
		/// <param name="scalar">Number</param>
		/// <returns>Division Point</returns>
		public Point3D Div(double scalar)
		{
			Point3D result = new Point3D();
			if (scalar == 0)
			{
				throw new ArgumentException("Scalar is 0");
			}
			double inverse = 1.0 / scalar;
			result.X = X * inverse;
			result.Y = Y * inverse;
			result.Z = Z * inverse;
			return result;
		}

		/// <summary>
		/// Multiply scalar
		/// </summary>
		/// <param name="scalar">scalar</param>
		/// <returns>Multiply scalar</returns>
		public Point3D Multiply(double scalar)
		{
			return new Point3D(X * scalar, Y * scalar, Z * scalar);
		}

		/// <summary>
		/// Change sign
		/// </summary>
		/// <returns>Negate Point</returns>
		public Point3D Negate()
		{
			return new Point3D(-X, -Y, -Z);
		}

		/// <summary>
		/// Strictly greater comparison
		/// </summary>
		/// <param name="other">Point</param>
		/// <returns>this>right</returns>
		public bool Major(Point3D other)
		{
			return (X > other.X && Y > other.Y && Z > other.Z);
		}

		/// <summary>
		/// Strictly minor comparison
		/// </summary>
		/// <param name="other"></param>
		/// <returns>this<other</returns>
		public bool Minor(Point3D other)
		{
			return (X < other.X && Y < other.Y && Z < other.Z);
		}
		#endregion

		#region Operator and Static Methods
		/// <summary>
		/// fine equals
		/// </summary>
		/// <param name="left">left point</param>
		/// <param name="right">right point</param>
		/// <returns><c>true</c> are equals</returns>
		public static bool operator ==(Point3D left, Point3D right)
		{
			return (left.X == right.X && left.Y == right.Y && left.Z == right.Z);
		}

		/// <summary>
		/// difference
		/// </summary>
		/// <param name="left">left point</param>
		/// <param name="right">right point</param>
		/// <returns><c>true</c> are difference</returns>
		public static bool operator !=(Point3D left, Point3D right)
		{
			return (left.X != right.X || left.Y != right.Y || left.Z != right.Z);
		}

		/// <summary>
		/// Scalar Division 
		/// </summary>
		/// <param name="left">Point</param>
		/// <param name="scalar">Scalar</param>
		/// <returns>Point</returns>
		public static Point3D operator /(Point3D left, double scalar)
		{
			return left.Div(scalar);
		}

		/// <summary>
		/// Point + Vector = Point
		/// </summary>
		/// <param name="left">Left point</param>
		/// <param name="right">Right vector</param>
		/// <returns>Point</returns>
		public static Point3D operator +(Point3D left, Vector3D right)
		{
			return new Point3D(left.X + right.X, left.Y + right.Y, left.Z + right.Z);
		}

		/// <summary>
		/// Point - Vector = Point
		/// </summary>
		/// <param name="left">Point</param>
		/// <param name="right">Vector</param>
		/// <returns>Point</returns>
		public static Point3D operator -(Point3D left, Vector3D right)
		{
			return new Point3D(left.X - right.X, left.Y - right.Y, left.Z - right.Z);
		}

		/// <summary>
		/// Multiply scalar
		/// </summary>
		/// <param name="left">Point</param>
		/// <param name="scalar">Scalar</param>
		/// <returns>Point</returns>
		public static Point3D operator *(Point3D left, double scalar)
		{
			return left.Multiply(scalar);
		}

		/// <summary>
		/// Multiply scalar
		/// </summary>
		/// <param name="scalar">Scalar</param>
		/// <param name="right">Point</param>
		/// <returns>Point</returns>
		public static Point3D operator *(double scalar, Point3D right)
		{
			return right.Multiply(scalar);
		}

		/// <summary>
		/// Left - Right = Vector
		/// </summary>
		/// <param name="left">Point</param>
		/// <param name="right">Point</param>
		/// <returns>Vector</returns>
		public static Vector3D operator -(Point3D left, Point3D right)
		{
			return new Vector3D(left.X - right.X, left.Y - right.Y, left.Z - right.Z);
		}

		/// <summary>
		/// Negate
		/// </summary>
		/// <param name="left">Point</param>
		/// <returns>Point</returns>
		public static Point3D operator -(Point3D left)
		{
			return left.Negate();
		}

		/// <summary>
		/// Left > Right
		/// </summary>
		/// <param name="left">Point</param>
		/// <param name="right">Point</param>
		/// <returns>left > right</returns>
		public static bool operator >(Point3D left, Point3D right)
		{
			return (left.X > right.X && left.Y > right.Y && left.Z > right.Z);
		}

		/// <summary>
		/// left < right
		/// </summary>
		/// <param name="left">Point</param>
		/// <param name="right">Point</param>
		/// <returns>left < right</returns>
		public static bool operator <(Point3D left, Point3D right)
		{
			return (left.X < right.X && left.Y < right.Y && left.Z < right.Z);
		}

		/// <summary>
		/// Cast espicito
		/// </summary>
		/// <param name="point">Point</param>
		/// <returns>Vector</returns>
		public static explicit operator Vector3D(Point3D point)
		{
			return new Vector3D(point.X, point.Y, point.Z);
		}

		/// <summary>
		/// Explicit Cast 
		/// </summary>
		/// <param name="point">2D point</param>
		/// <returns>3D Point</returns>
		public static explicit operator Point3D(Point2D point)
		{
			return new Point3D(point.X, point.Y, 0);
		}

		/// <summary>
		/// Explicit Cast 
		/// </summary>
		/// <param name="point">3D Point</param>
		/// <returns>2D Point</returns>
		public static explicit operator Point2D(Point3D point)
		{
			return new Point2D(point.X, point.Y);
		}

		/// <summary>
		/// Point has 0.0 value in coordinate
		/// </summary>
		public static Point3D Zero => new Point3D() { X = 0.0, Y = 0.0, Z = 0.0 };

		/// <summary>
		/// Null Point = (NaN, NaN, NaN)
		/// </summary>
		public static Point3D NullPoint=> new Point3D(double.NaN, double.NaN, double.NaN);
		#endregion


	}
}