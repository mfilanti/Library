using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fm.Maths
{
	internal class Sort3DPoint
	{
		private static Point3D sortPoint;
		private static Vector3D sortDirection;

		///// <summary>
		///// Determina i punti esterni di un insieme di punti rispetto ad una direzione data
		///// </summary>
		///// <param name="points"></param>
		///// <param name="direction"></param>
		///// <param name="minPoint"></param>
		///// <param name="maxPoint"></param>
		//public static void ExternalPoints(IEnumerable<Point3D> points, Vector3D direction, out Point3D minPoint, out Point3D maxPoint)
		//{
		//	minPoint = Point3D.NullPoint;
		//	maxPoint = Point3D.NullPoint;
		//	double min = double.MaxValue;
		//	double max = double.MinValue;
		//	int cnt = 0;
		//	Point3D refPoint = Point3D.NullPoint;
		//	foreach (Point3D point in points)
		//	{
		//		if (cnt == 0)
		//		{
		//			cnt++;
		//			refPoint = point;
		//		}

		//		double dist = (point - refPoint).Dot(direction);
		//		if (dist < min)
		//		{
		//			min = dist;
		//			minPoint = point;
		//		}
		//		if (dist > max)
		//		{
		//			max = dist;
		//			maxPoint = point;
		//		}
		//	}
		//}

		
		///// <summary>
		///// Ordinamento dei punti da un punto lungo una direzione
		///// </summary>
		///// <param name="intersections"></param>
		///// <param name="point"></param>
		///// <param name="direction"></param>
		//public static void Sort(ref List<Point3D> intersections, Point3D point, Vector3D direction)
		//{
		//	sortPoint = point;
		//	sortDirection = direction;
		//	intersections.Sort(PointDirComparer);
		//}

		//private static int PointDirComparer(Point3D p1, Point3D p2)
		//{
		//	double t1 = (p1 - sortPoint).Dot(sortDirection);
		//	double t2 = (p2 - sortPoint).Dot(sortDirection);
		//	return t1.CompareTo(t2);
		//}
	}
}
