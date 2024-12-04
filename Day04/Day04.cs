using System.Drawing;

namespace AdventOfCode2024.Day04;

public class Day04
{
    public static int SolvePart1(string input)
    {
        var lines = input.AsListOfStrings();

        return CoordinateHelper.GetNeighboringPoints(0, 0)
            .Sum(direction => WordCount(lines, direction, "XMAS"));
    }

    public static int SolvePart2(string input)
    {
        return 0;
    }

    private static int WordCount(List<string> lines, Point direction, string neededWord)
    {
        var count = 0;
        for (var y = 0; y < lines.Count; y++)
        {
            for (var x = 0; x < lines[y].Length; x++)
            {
                var word = "";
                for (var i = 0; i < neededWord.Length; i++)
                {
                    var point = new Point(x + direction.X * i, y + direction.Y * i);
                    if (!CoordinateHelper.IsWithinBounds(point, 0, 0, lines[y].Length - 1, lines.Count - 1)) break;
                    word += lines[point.Y][point.X];
                }

                count += word == neededWord ? 1 : 0;
            }
        }

        return count;
    }
}