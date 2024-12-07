using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode2024.Day06;

public class Day06Test
{
    [Test]
    public void ExamplePart1()
    {
        Day06.SolvePart1("Day06Example".ReadAll()).Should().Be(41);
    }

    [Test]
    public void SolutionPart1()
    {
        Console.WriteLine(Day06.SolvePart1("Day06".ReadAll()));
    }

    [Test]
    public void ExamplePart2()
    {
        Day06.SolvePart2("Day06Example".ReadAll()).Should().Be(6);
    }
}