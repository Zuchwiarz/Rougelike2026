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
        int NPCdirectionX = rnd.Next(-1,2);
        int NPCdirectionY = rnd.Next(-1,2);
        int targetX = Random.Shared.Next(-1, 2);
        int targetY = Random.Shared.Next(-1, 2);
        Move(targetX,targetY);
        Display();
        return true;
    }
}