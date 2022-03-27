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
			var p = new Point();
			Assert.AreEqual(double.NaN, p.X);
			Assert.AreEqual(double.NaN, p.Y);
			Assert.AreEqual(double.NaN, p.Z);
			Assert.Pass();
		}

		[Test]
		public void TestZeroPoint()
		{
			var p = Point.Zero;
			Assert.AreEqual(0.0, p.X);
			Assert.AreEqual(0.0, p.Y);
			Assert.AreEqual(0.0, p.Z);
			Assert.Pass();
		}
	}
}