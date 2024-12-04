using System.Drawing;

namespace AdventOfCode2024;

public static class CoordinateHelper
{
    public static List<Point> GetNeighboringPoints(int x, int y)
    {
        return new()
        {
            new Point(x - 1, y - 1),
            new Point(x - 1, y),
            new Point(x - 1, y + 1),
            new Point(x, y - 1),
            new Point(x, y + 1),
            new Point(x + 1, y - 1),
            new Point(x + 1, y),
            new Point(x + 1, y + 1)
        };
    }

    public static bool IsWithinBounds(Point point, int minX, int minY, int maxX, int maxY) => point.X >= minX && point.X <= maxX && point.Y >= minY && point.Y <= maxY;
}