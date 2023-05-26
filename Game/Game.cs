namespace SAS;
using static Console;

public class Game
{
    private Game() { }

    private static Game crr = new Game();
    private static Game Current => crr;
    public static void New()
        => crr = new Game();

    public void Run()
    {
        ConsoleWriter.Init();
        ConsoleWriter.showMenu();
        int playerchoice = Int16.Parse(ReadLine());

        if(playerchoice == 2)
            return;

        while(true)
        {
            
        }
    }
}