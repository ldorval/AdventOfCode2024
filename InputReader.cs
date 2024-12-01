namespace AdventOfCode2024;

public static class InputReader
{
    public static string ReadAll(this string file)
    {
        return File.ReadAllText(PathFrom(file));
    }

    public static StreamReader ReadStream(this string file)
    {
        return new StreamReader(PathFrom(file));
    }

    private static string PathFrom(this string file)
    {
        return $"../../../Inputs/{file}";
    }
}