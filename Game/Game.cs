namespace SAS;
using static Console;

public class Game
{
    private Game() { }

    private static Game crr = new Game();
    public static Game Current => crr;
    public static void New()
        => crr = new Game();

    public void Run()
    {
        ConsoleWriter.Init();
        ConsoleWriter.showMenu();
        int playerchoice = Int16.Parse(ReadLine());

        if(playerchoice == 2)
            return;

        Player player = new Player();
        BasicEnemy enemy = new BasicEnemy();

        while(true)
        {
            while (!player.Comportament.Finished())
            {
                var machine = player.Comportament.GetBuy();
                player.Buy(machine);
            }
            player.Comportament.AttShop();

            while (!enemy.Comportament.Finished())
            {
                var machine = enemy.Comportament.GetBuy();
                enemy.Buy(machine);
            }
            enemy.Comportament.AttShop();

            System.Console.WriteLine(player.PlayerTeam);
            System.Console.WriteLine(enemy.PlayerTeam);

            player.PlayerTeam.Reset();
            enemy.PlayerTeam.Reset();

            TeamBattle battle = new TeamBattle(player.PlayerTeam, enemy.PlayerTeam);
            var winner = battle.Battle();
            
            Console.WriteLine($"Vencedor: {winner.Name}");
        }
    }
}