namespace AdventOfCode2024;

public static class StringExtensions
{
    public static List<List<int>> AsIntMap(this string value)
    {
        return value.AsListOfStrings()
            .Select(x => x.ToCharArray()
                .Select(x => Convert.ToInt32(Char.GetNumericValue(x))).ToList())
            .ToList();
    }

    public static List<int> AsListOfInts(this string value)
    {
        return value
            .Split("\r\n")
            .Select(x => Convert.ToInt32(x))
            .ToList();
    }
        
    public static List<string> AsListOfStrings(this string value) => value.Split("\r\n").ToList();
}