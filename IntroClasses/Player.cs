namespace IntroClasses;

public class Player : Character
{
    private readonly Dictionary<ConsoleKeyInfo, bool> _inputMap;    

    public Player(Vector2 startingPosition, Dictionary<ConsoleKey,Vector2> inputMap) : base(startingPosition)
    {
        _inputMap = inputMap;
    }
    

    public override bool TakeTurn()
    {
        var isPlaying = IsPlaying(out var input);
        
        // tutaj dorobić
        Vector2 direction = _inputMap
            
        
        switch (input.Key)
        {
            case ConsoleKey.S:
                Move(0, 1);
                break;
            case ConsoleKey.W:
                Move(0, -1);
                break;
            case ConsoleKey.A:
                Move(-1, 0);
                break;
            case ConsoleKey.D:
                Move(1, 0);
                break;
            case ConsoleKey.Q:
                isPlaying = false;
                break;
        }

        Display();
        
        return isPlaying;
    }

    private bool IsPlaying(out ConsoleKeyInfo input)
    {
        bool isPlaying = true;
        input = Console.ReadKey(true);
        Console.SetCursorPosition(_position.X, _position.Y);
        Console.Write(" ");
        return isPlaying;
    }
}
