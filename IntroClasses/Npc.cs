namespace IntroClasses;

public class Npc : Character
{
    List<Vector2> availableDirections = [
        new Vector2(-1,0), //lewo
        new Vector2(1,0), //prawo
        new Vector2(0,-1), //góra
        new Vector2(0,1), //dół
    ];
    
    public Npc(Vector2 startingPosition) : base(startingPosition)
    {
        
    }

    public override bool TakeTurn()
    {
        Console.SetCursorPosition(left:_position.X,top:_position.Y);
        Console.Write(" ");
        Random rnd = new Random();

       
        int index = Random.Shared.Next(0, availableDirections.Count);
        Move(availableDirections[index]);
        Display();
        return true;
    }
}