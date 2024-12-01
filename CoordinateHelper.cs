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

    public static bool IsWithinBounds(int x, int y, int minX, int minY, int maxX, int maxY) => x >= minX && x <= maxX && y >= minY && y <= maxY;
}