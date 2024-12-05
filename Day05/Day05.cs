namespace AdventOfCode2024.Day05;

public class Day05
{
    public static int SolvePart1(string input) => GetOrderedUpdates(input, true).Sum(x => x[x.Count / 2]);
    public static int SolvePart2(string input) => GetOrderedUpdates(input, false).Sum(x => x[x.Count / 2]);
    
    private static List<List<int>> GetOrderedUpdates(string input, bool correctlyOrdered)
    {
        var split = input.Split("\r\n\r\n");
        var priorities = split[0].Trim().AsListOfStrings().ToList();
        var updates = split[1].Trim().AsListOfStrings().Select(x => x.Split(",").Select(int.Parse).ToList()).ToList();
        var orderedUpdates = updates.Select(x => x.OrderBy(y => y, new CustomPageComparer(priorities))).Select(x => x.ToList()).ToList();

        return orderedUpdates.Where((x, i) => x.SequenceEqual(updates[i]) == correctlyOrdered).ToList();
    }

    public class CustomPageComparer(List<string> priorities) : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            var priority = priorities.First(p => p.Contains(x.ToString()) && p.Contains(y.ToString()));
            var first = priority.Split("|")[0];

            if (first == x.ToString()) return -1;
            return first == y.ToString() ? 1 : 0;
        }
    }
}