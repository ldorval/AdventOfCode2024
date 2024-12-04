using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode2024.Day04;

public class Day04Test
{
    [Test]
    public void Day04ExamplePart1()
    {
        Day04.SolvePart1(InputReader.ReadAll("Day04Example")).Should().Be(18);
    }

    [Test]
    public void Day04SolutionPart1()
    {
        Console.WriteLine(Day04.SolvePart1(InputReader.ReadAll("Day04")));
    }

    [Test]
    public void Day04Part2Example()
    {
        Day04.SolvePart2(InputReader.ReadAll("Day04Example")).Should().Be(9);
    }

    [Test]
    public void Day04SolutionPart2()
    {
        Console.WriteLine(Day04.SolvePart2(InputReader.ReadAll("Day04")));
    }
}