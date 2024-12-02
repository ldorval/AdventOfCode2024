﻿using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode2024.Day02;

public class Day02Test
{
    [Test]
    public void Day02ExamplePart1()
    {
        var input = InputReader.ReadAll("Day02Example");
        Day02.Solve(input).Should().Be(2);
    }

    [Test]
    public void Day02SolutionPart1()
    {
        var input = InputReader.ReadAll("Day02");
        Console.WriteLine(Day02.Solve(input));
    }

    [Test]
    public void Day02ExamplePart2()
    {
        var input = InputReader.ReadAll("Day02Example");
        Day02.Solve(input, true).Should().Be(4);
    }
    
    [Test]
    public void Day02SolutionPart2()
    {
        var input = InputReader.ReadAll("Day02");
        Console.WriteLine(Day02.Solve(input, true));
    }
}