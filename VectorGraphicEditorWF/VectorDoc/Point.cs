using System;

namespace VectorGraphicEditorWF
{
	[Serializable]
	class Point
	{
		public double x { get; set; }
		public double y { get; set; }
		public static bool operator ==(Point point1, Point point2)
		{
			return (point1.x.CompareTo(point2.x) == 0 && point1.y.CompareTo(point2.y) == 0);
		}
		public static bool operator !=(Point point1, Point point2)
		{
			return !(point1 == point2);
		}
		public Point()
		{
			x = 0;
			y = 0;
		}
		public Point(double _x, double _y)
		{
			x = _x;
			y = _y;
		}
	}
}
