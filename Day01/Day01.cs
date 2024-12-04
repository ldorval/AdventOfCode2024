namespace AdventOfCode2024.Day01;

public class Day01
{
    public static Day01Result Solve(string input)
    {
        var splits = input.AsListOfStrings().Select(x => x.Split("   ")).ToList();
        var firstList = splits.Select(x => int.Parse(x[0])).OrderBy(x => x).ToList();
        var secondList = splits.Select(x => int.Parse(x[1])).OrderBy(x => x).ToList();

        return new Day01Result(
            firstList.Select((_, i) => Math.Abs(firstList[i] - secondList[i])).Sum(),
            firstList.Select(x => x * secondList.Count(y => y == x)).Sum());
    }
    
    public record Day01Result(long TotalDistance, long SimilarityScore);
}