using NUnit.Framework;

namespace Fm.Maths.NUnitTest
{
	public class PointTests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void TestNewIstance()
		{
			var p = new Point3D();
			Assert.AreEqual(double.NaN, p.X);
			Assert.AreEqual(double.NaN, p.Y);
			Assert.AreEqual(double.NaN, p.Z);
			Assert.Pass();
		}

		[Test]
		public void TestZeroPoint()
		{
			var p = Point3D.Zero;
			Assert.AreEqual(0.0, p.X, MathUtilsExtensionMethods.FineTolerance);
			Assert.AreEqual(0.0, p.Y, MathUtilsExtensionMethods.FineTolerance);
			Assert.AreEqual(0.0, p.Z, MathUtilsExtensionMethods.FineTolerance);
			Assert.Pass();
		}

		[Test]
		public void TestNullPoint()
		{
			var p = Point3D.NullPoint;
			Assert.IsTrue(double.IsNaN(p.X));
			Assert.IsTrue(double.IsNaN(p.Y));
			Assert.IsTrue(double.IsNaN(p.Z));
			Assert.IsTrue(p.IsNullPoint());
			Assert.Pass();
		}

		[Test]
		public void TestCostructorPoint()
		{
			var p = new Point3D(1.5, 2.6, 3.7);
			Assert.AreEqual(1.5, p.X, MathUtilsExtensionMethods.FineTolerance);
			Assert.AreEqual(2.6, p.Y, MathUtilsExtensionMethods.FineTolerance);
			Assert.AreEqual(3.7, p.Z, MathUtilsExtensionMethods.FineTolerance);
			Assert.Pass();
		}

		[Test]
		public void TestOperatorThisPoint()
		{
			var p = new Point3D(1.5, 2.6, 3.7);
			Assert.AreEqual(1.5, p[0], MathUtilsExtensionMethods.FineTolerance);
			Assert.AreEqual(2.6, p[1], MathUtilsExtensionMethods.FineTolerance);
			Assert.AreEqual(3.7, p[2], MathUtilsExtensionMethods.FineTolerance);
			p[0] = 2.1;
			Assert.AreEqual(2.1, p[0], MathUtilsExtensionMethods.FineTolerance);
			p[1] = 3.2;
			Assert.AreEqual(3.2, p[1], MathUtilsExtensionMethods.FineTolerance);
			p[2] = 4.3;
			Assert.AreEqual(4.3, p[2], MathUtilsExtensionMethods.FineTolerance);
			Assert.Pass();
		}

		[Test]
		public void TestToString()
		{
			var p = new Point3D(1.5, 2.6, 3.7);
			string value = p.ToString();
			Assert.IsNotNull(value);
			Assert.Pass();
		}

		[Test]
		public void TestDistance()
		{
			var p1 = new Point3D(1, 1, 1);
			var p2 = new Point3D(1000, 1, 1);
			double value = p1.Distance(p2);
			Assert.AreEqual(999, value, MathUtilsExtensionMethods.FineTolerance);
			double valueSqr = p1.DistanceSqr(p2);
			Assert.AreEqual(value * value, valueSqr, MathUtilsExtensionMethods.FineTolerance);
			Assert.Pass();
		}

		[Test]
		public void TestHashCode()
		{
			var p1 = new Point3D(1, 1, 1);
			double hashCode = p1.GetHashCode();
			Assert.IsTrue(!double.IsNaN(hashCode));

			Assert.Pass();
		}

		[Test]
		public void TestEquals()
		{
			var p1 = new Point3D(1, 1, 1);
			var p2 = new Point3D(1, 1, 1);
			var v2 = new Vector3D(1, 1, 1);
			Assert.IsTrue(p1.Equals(p2));
			Assert.IsFalse(p1.Equals(v2));
			Assert.IsFalse(p1.Equals(null));
			Assert.Pass();
		}

		[Test]
		public void TestDiv()
		{
			double coordinateX = 10.0;
			double coordinateY = 20.0;
			double coordinateZ = 35.0;
			double div = 10.0;
			var p1 = new Point3D(coordinateX, coordinateY, coordinateZ);
			var p1Div = p1.Div(div);
			var pTest = new Point3D(coordinateX / div, coordinateY / div, coordinateZ / div);
			Assert.True(p1Div.Equals(pTest));

			Assert.Pass();
		}

		[Test]
		public void TestMul()
		{
			double coordinateX = 10.0;
			double coordinateY = 20.0;
			double coordinateZ = 35.0;
			double mul = 10.0;
			var p1 = new Point3D(coordinateX, coordinateY, coordinateZ);
			var p1Mul = p1.Multiply(mul);
			var pTest = new Point3D(coordinateX * mul, coordinateY * mul, coordinateZ * mul);
			Assert.True(p1Mul.Equals(pTest));

			Assert.Pass();
		}

		[Test]
		public void TestNegate()
		{
			double coordinateX = 10.0;
			double coordinateY = 20.0;
			double coordinateZ = 35.0;
			var p1 = new Point3D(coordinateX, coordinateY, coordinateZ);
			var p1Mul = p1.Negate();
			var pTest = new Point3D(-coordinateX, -coordinateY, -coordinateZ);
			Assert.True(p1Mul.Equals(pTest));

			Assert.Pass();
		}

		[Test]
		public void TestMajorMinor()
		{
			double coordinateX = 10.0;
			double coordinateY = 20.0;
			double coordinateZ = 30.0;
			var p1 = new Point3D(coordinateX, coordinateY, coordinateZ);
			var p2 = new Point3D(coordinateX + 10, coordinateY + 10, coordinateZ + 10);
			Assert.True(p1.Minor(p2));
			Assert.True(p2.Major(p1));
			Assert.True(p1 < p2);
			Assert.True(p2 > p1);

			var p3 = new Point3D(coordinateX - 10, coordinateY + 10, coordinateZ + 10);
			Assert.False(p1.Major(p3));
			Assert.False(p1.Minor(p3));

			Assert.Pass();
		}

		[Test]
		public void TestOperatorEqualsAndDifferent()
		{
			double coordinateX = 10.0;
			double coordinateY = 20.0;
			double coordinateZ = 30.0;
			var p1 = new Point3D(coordinateX, coordinateY, coordinateZ);
			var p2 = new Point3D(coordinateX, coordinateY, coordinateZ);
			var p3 = new Point3D(coordinateX + 1, coordinateY, coordinateZ);
			Assert.True(p1 == p2);
			Assert.True(p1 != p3);

			Assert.Pass();
		}

		[Test]
		public void TestOperatorAddSubDivMul()
		{
			double coordinateX = 10.0;
			double coordinateY = 20.0;
			double coordinateZ = 30.0;
			double scalar = 10.0;
			Point3D p1 = new(coordinateX, coordinateY, coordinateZ);
			Vector3D v2 = new(coordinateX, coordinateY, coordinateZ);
			Point3D pTestSum = new Point3D(p1.X + v2.X, p1.Y + v2.Y, p1.Z + v2.Z);
			Point3D pTestSub = new Point3D(p1.X - v2.X, p1.Y - v2.Y, p1.Z - v2.Z);
			Point3D pTestDiv = new Point3D(p1.X / scalar, p1.Y / scalar, p1.Z / scalar);
			Point3D pTestMul = new Point3D(p1.X * scalar, p1.Y * scalar, p1.Z * scalar);
			Point3D pResultSum = p1 + v2;
			Point3D pResultSub = p1 - v2;
			Point3D pResultDiv = p1 / 10.0;
			Point3D pResultMul = p1 * 10.0;
			Point3D pResultMul2 = 10.0 * p1;
			Assert.True(pResultSum.Equals(pTestSum));
			Assert.True(pResultSub.Equals(pTestSub));
			Assert.True(pResultDiv.Equals(pTestDiv));
			Assert.True(pResultMul.Equals(pTestMul));
			Assert.AreEqual(pResultMul, pResultMul2);
			Assert.Pass();
		}

		[Test]
		public void TestOperatorSub()
		{
			double coordinateX = 10.0;
			double coordinateY = 20.0;
			double coordinateZ = 30.0;
			Point3D p1 = new(coordinateX, coordinateY, coordinateZ);
			Point3D p2 = new(coordinateX, coordinateY, coordinateZ);
			Vector3D vSub = p1 - p2;
			Assert.AreEqual(Vector3D.Zero.X, vSub.X, MathUtilsExtensionMethods.FineTolerance);
			Assert.AreEqual(Vector3D.Zero.Y, vSub.Y, MathUtilsExtensionMethods.FineTolerance);
			Assert.AreEqual(Vector3D.Zero.Z, vSub.Z, MathUtilsExtensionMethods.FineTolerance);
			Assert.Pass();
		}

		[Test]
		public void TestOperatorInvert()
		{
			double coordinateX = 10.0;
			double coordinateY = 20.0;
			double coordinateZ = 30.0;
			Point3D p1 = new(coordinateX, coordinateY, coordinateZ);
			Point3D p2 = new(-coordinateX, -coordinateY, -coordinateZ);
			Assert.AreEqual(p2, -p1);
			Assert.Pass();
		}

		[Test]
		public void TestExplicitCast()
		{
			double coordinateX = 10.0;
			double coordinateY = 20.0;
			double coordinateZ = 30.0;
			Point3D p1 = new(coordinateX, coordinateY, coordinateZ);
			Vector3D vResult = (Vector3D)p1;
			Assert.AreEqual(coordinateX, vResult.X, MathUtilsExtensionMethods.FineTolerance);
			Assert.AreEqual(coordinateY, vResult.Y, MathUtilsExtensionMethods.FineTolerance);
			Assert.AreEqual(coordinateZ, vResult.Z, MathUtilsExtensionMethods.FineTolerance);

			Point2D p2DResult = (Point2D)p1;
			Point3D p3DResult = (Point3D)p2DResult;
			Assert.AreEqual(coordinateX, p3DResult.X, MathUtilsExtensionMethods.FineTolerance);
			Assert.AreEqual(coordinateY, p3DResult.Y, MathUtilsExtensionMethods.FineTolerance);
			Assert.AreEqual(0.0, p3DResult.Z, MathUtilsExtensionMethods.FineTolerance);
			Assert.Pass();
		}
	}
}