using System.Text.RegularExpressions;

namespace AdventOfCode2024.Day03;

public class Day03
{
    public static int Solve(string input, bool enableDoStatements)
    {
        var matches = new Regex(@"mul\((-?\d+),(-?\d+)\)|do\(\)|don't\(\)").Matches(input);
        var sum = 0;
        var enabled = true;
        
        foreach (Match match in matches)
        {
            if (match.Groups[0].Value.StartsWith("mul("))
                sum += enabled ? int.Parse(match.Groups[1].Value) * int.Parse(match.Groups[2].Value) : 0;
            else if (match.Groups[0].Value == "do()" && enableDoStatements)
                enabled = true;
            else if (match.Groups[0].Value == "don't()" && enableDoStatements)
                enabled = false;
        }
        
        return sum;
    }
}