namespace IntroClasses;

public class Npc : Character
{
    public Npc(Vector2 startingPosition) : base(startingPosition)
    {
        
    }

    public override bool TakeTurn()
    {
        Console.SetCursorPosition(left:_position.X,top:_position.Y);
        Console.Write(" ");
        Random rnd = new Random();

        List<Vector2> availableDirections = [
        new Vector2(-1,0),
        new Vector2(1,0),
        new Vector2(0,-1),
        new Vector2(0,1),
        ];
        int index = Random.Shared.Next(0, availableDirections.Count);
        Move(availableDirections[index]);
        Display();
        return true;
    }
}