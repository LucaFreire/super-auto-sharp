namespace SAS;

public class TeamBattle
{
    public Team Team1 { get; set; }
    public Team Team2 { get; set; }
    private bool endOfBattle = false;
    public TeamBattle(Team t1, Team t2)
    {
        this.Team1 = t1;
        this.Team2 = t2;
    }

    public Team Battle()
    {
        // ? Backup of team1 vc backup team2
        while(!endOfBattle)
        {
            Machine m1 = Team1.Backup.First();
            Machine m2 = Team2.Backup.First();

            System.Console.WriteLine("Time 1:");
            System.Console.WriteLine(Team1);
            System.Console.WriteLine("Time 2:");
            System.Console.WriteLine(Team2);


            System.Console.WriteLine("-=-=-=-=-=-= BRAWL =-=-=-=-=-=-");
            Shift(m1, m2);
            System.Console.WriteLine("-=-=-=-=-=-==-=-=-=-=-=-");

            Team1.VerifyAlive();
            Team2.VerifyAlive();
            endOfBattle = 
                Team1.Backup.Count() == 0 ||
                Team2.Backup.Count() == 0;
        }

        if (Team1.Backup.Count() == 0)
        {
            Team1.Reset(); // * Reseting the backup to another battle
            Team2.Reset();
            return Team2;
        }

        Team1.Reset();
        Team2.Reset();
        return Team1;
    }

    public void Shift(Machine machine1, Machine machine2)
        => machine1.Hit(machine2);
    
}