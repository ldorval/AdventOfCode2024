using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode2024.Day04;

public class Day04Test
{
    [Test]
    public void Day04ExamplePart1()
    {
        Day04.SolvePart1("Day04Example".ReadAll()).Should().Be(18);
    }

    [Test]
    public void Day04SolutionPart1()
    {
        Console.WriteLine(Day04.SolvePart1("Day04".ReadAll()));
    }

    [Test]
    public void Day04Part2Example()
    {
        Day04.SolvePart2("Day04Example".ReadAll()).Should().Be(9);
    }

    [Test]
    public void Day04SolutionPart2()
    {
        Console.WriteLine(Day04.SolvePart2("Day04".ReadAll()));
    }
}