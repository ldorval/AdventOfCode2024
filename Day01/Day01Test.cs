using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode2024.Day01;

public class Day01Test
{
    [Test]
    public void Day01Example()
    {
        var input = InputReader.ReadAll("Day01Example");
        Day01.Solve(input).TotalDistance.Should().Be(11);
    }

    [Test]
    public void Day01Solution()
    {
        var input = InputReader.ReadAll("Day01");
        Console.WriteLine(Day01.Solve(input).TotalDistance);
    }

    [Test]
    public void Day01Part2Example()
    {
        var input = InputReader.ReadAll("Day01Example");
        Day01.Solve(input).SimilarityScore.Should().Be(31);
    }
    
    [Test]
    public void Day01Part2Solution()
    {
        var input = InputReader.ReadAll("Day01");
        Console.WriteLine(Day01.Solve(input).SimilarityScore);
    }
}