using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode2024.Day05;

public class Day05Test
{
    [Test]
    public void Day05ExamplePart1()
    {
        Day05.SolvePart1("Day05Example".ReadAll()).Should().Be(143);
    }

    [Test]
    [TestCase(4, 3, -1)]
    [TestCase(12, 4, 1)]
    [TestCase(8, 12, -1)]
    [TestCase(3, 8, -1)]
    [TestCase(8, 3, 1)]
    public void Compare(int x, int y, int result)
    {
        var priorities = new List<string> { "4|3", "4|12", "8|12", "3|8" };
        var comparer = new Day05.CustomPageComparer(priorities);
        comparer.Compare(x, y).Should().Be(result);
    }

    [Test]
    public void Day05SolutionPart1()
    {
        Console.WriteLine(Day05.SolvePart1("Day05".ReadAll()));
    }
    
    [Test]
    public void Day05ExamplePart2()
    {
        Day05.SolvePart2("Day05Example".ReadAll()).Should().Be(123);
    }
    
    [Test]
    public void Day05SolutionPart2()
    {
        Console.WriteLine(Day05.SolvePart2("Day05".ReadAll()));
    }
}