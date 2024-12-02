namespace AdventOfCode2024.Day02;

public class Day02
{
    public static int Solve(string input, bool withTolerance = false)
    {
        var lines = input.AsListOfStrings().Select(x => x.Split(" ").Select(int.Parse).ToList()).ToList();

        return lines.Count(IsSafe) + 
               (withTolerance ? lines.Count(x => !IsSafe(x) && IsSafeWithTolerance(x)) : 0);
    }

    private static bool IsSafe(List<int> levels)
    {
        for (var i = 1; i < levels.Count; i++)
        {
            if (IsOutOfRange(levels, i)) return false;
        }

        return IsOrdered(levels);
    }

    private static bool IsSafeWithTolerance(List<int> levels)
    {
        return levels
            .Where((_, i) => IsSafe(SkipIndex(levels, i).ToList()))
            .Any();
    }

    private static IEnumerable<int> SkipIndex(List<int> levels, int i) => levels.Where((_, j) => j != i);
    private static bool IsOutOfRange(List<int> levels, int i) => Math.Abs(levels[i - 1] - levels[i]) is < 1 or > 3;
    private static bool IsOrdered(List<int> levels) => levels.SequenceEqual(levels.OrderBy(x => x)) || levels.SequenceEqual(levels.OrderByDescending(x => x));
}