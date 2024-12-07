namespace AdventOfCode2024.Day06;

public class Day06
{
    private static List<MapDirection> directions = new() { new(0, -1, '^'), new(1, 0, '>'), new(0, 1, 'v'), new(-1, 0, '<') };

    public static int SolvePart1(string input)
    {
        var map = input.AsListOfStrings().Select((line, y) => line.Select((c, x) => new MapPosition(x, y, c)).ToList()).ToList();
        return GetVisitedPositions(map).VisitedPositions.DistinctBy(x => x.Position).Count() + 1;
    }

    public static int SolvePart2(string input)
    {
        var map = input.AsListOfStrings().Select((line, y) => line.Select((c, x) => new MapPosition(x, y, c)).ToList()).ToList();
        var initialResult = GetVisitedPositions(map);

        var results = new List<Day06Result>();
        foreach (var visitedPosition in initialResult.VisitedPositions)
        {
            if (visitedPosition.Position.Content != '#' && visitedPosition.Position.Content != '.') continue;
            var position = visitedPosition.Position;
            var alternateMap = input.AsListOfStrings().Select((line, y) => line.Select((c, x) => new MapPosition(x, y, c)).ToList()).ToList();
            alternateMap[position.Y][position.X] = map[position.Y][position.X] with { Content = '#' };
            results.Add(GetVisitedPositions(alternateMap));
        }

        return results.Count(x => x.IsLooping);
    }

    private static Day06Result GetVisitedPositions(List<List<MapPosition>> map)
    {
        var currentPosition = map.Select(position => position.SingleOrDefault(x => x.Content != '#' && x.Content != '.')).Single(x => x != null);
        var currentDirection = directions.Single(direction => direction.Arrow == currentPosition.Content);
        var visitedPositions = new HashSet<VisitedPosition>();

        while (true)
        {
            var destinationX = currentPosition.X + currentDirection.X;
            var destinationY = currentPosition.Y + currentDirection.Y;
            var destination = destinationY < map.Count && destinationY >= 0 && destinationX < map[0].Count && destinationX >= 0 ? map[destinationY][destinationX] : null;

            if (destination == null) break;

            if (destination.Content == '#')
                currentDirection = TurnRight(currentDirection);
            else
            {
                var currentCount = visitedPositions.Count;
                visitedPositions.Add(new VisitedPosition(currentPosition, currentDirection));
                
                if (currentCount == visitedPositions.Count)
                    return new Day06Result(visitedPositions.ToList(), true);
                
                currentPosition = destination;
            }
        }

        return new Day06Result(visitedPositions.ToList(), false);
    }

    private static MapDirection TurnRight(MapDirection currentDirection)
    {
        return currentDirection.Arrow switch
        {
            '^' => directions.Single(direction => direction.Arrow == '>'),
            '>' => directions.Single(direction => direction.Arrow == 'v'),
            'v' => directions.Single(direction => direction.Arrow == '<'),
            '<' => directions.Single(direction => direction.Arrow == '^')
        };
    }

    private record MapPosition(int X, int Y, char Content);

    private record MapDirection(int X, int Y, char Arrow);

    private record Day06Result(List<VisitedPosition> VisitedPositions, bool IsLooping);

    private record VisitedPosition(MapPosition Position, MapDirection Direction);
}