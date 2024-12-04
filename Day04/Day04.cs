using System.Drawing;

namespace AdventOfCode2024.Day04;

public class Day04
{
    public static int SolvePart1(string input)
    {
        return CoordinateHelper.GetNeighboringPoints(0, 0)
            .SelectMany(direction => LinearWordCount(input.AsListOfStrings(), direction))
            .Count(word => word == "XMAS");
    }

    private static IEnumerable<string> LinearWordCount(List<string> lines, Point direction)
    {
        for (var y = 0; y < lines.Count; y++)
        {
            for (var x = 0; x < lines[y].Length; x++)
            {
                yield return string.Concat(Enumerable.Range(0, 4).Select(i => FindAtPosition(x + direction.X * i, y + direction.Y * i, lines)));
            }
        }
    }

    public static int SolvePart2(string input) => XShapedWordCount(input.AsListOfStrings()).Sum();

    private static IEnumerable<int> XShapedWordCount(List<string> lines)
    {
        for (var y = 0; y < lines.Count; y++)
        {
            for (var x = 0; x < lines[y].Length; x++)
            {
                if (lines[y][x] != 'A') continue;
                var firstDiagonal = FindAtPosition(x - 1, y - 1, lines) + FindAtPosition(x + 1, y + 1, lines);
                var secondDiagonal = FindAtPosition(x + 1, y - 1, lines) + FindAtPosition(x - 1, y + 1, lines);
                if (firstDiagonal.OrderBy(x => x).SequenceEqual("MS") && secondDiagonal.OrderBy(x => x).SequenceEqual("MS"))
                    yield return 1;
            }
        }
    }

    private static string? FindAtPosition(int x, int y, List<string> lines)
    {
        var point = new Point(x, y);
        return CoordinateHelper.IsWithinBounds(point, 0, 0, lines[0].Length - 1, lines.Count - 1) ? lines[point.Y][point.X].ToString() : null;
    }
}