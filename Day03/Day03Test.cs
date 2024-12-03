using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode2024.Day03;

public class Day03Test
{
    [Test]
    public void Day03ExamplePart1()
    {
        Day03.Solve("xmul(2,4)%&mul[3,7]!@^do_not_mul(5,5)+mul(32,64]then(mul(11,8)mul(8,5))", false).Should().Be(161);
    }

    [Test]
    public void Day03Solution()
    {
        Console.WriteLine(Day03.Solve(InputReader.ReadAll("Day03"), false));
    }

    [Test]
    public void Day03ExamplePart2()
    {
        Day03.Solve("xmul(2,4)&mul[3,7]!^don't()_mul(5,5)+mul(32,64](mul(11,8)undo()?mul(8,5))", true).Should().Be(48);
    }

    [Test]
    public void Day03Part2Solution()
    {
        Console.WriteLine(Day03.Solve(InputReader.ReadAll("Day03"), true));
    }
}