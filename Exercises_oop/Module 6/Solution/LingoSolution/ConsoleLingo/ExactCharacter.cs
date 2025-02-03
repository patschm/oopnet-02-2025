namespace ConsoleLingo
{
    // TODO 2: Create a class ExactCharacter which derives from LingoCharacter.
    // It should draw the character with a green background color and a black foreground color
    public class ExactCharacter : LingoCharacter
    {
        public override void Draw()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(Character);
            Console.ResetColor();
        }
       
    }
}
