namespace SAS;

public class TeamBattle
{
    public Team Team1 { get; set; }
    public Team Team2 { get; set; }
    private bool EndOfBattle = false;
    public TeamBattle(Team t1, Team t2)
    {
        this.Team1 = t1;
        this.Team2 = t2;
    }

    public Team Battle()
    {
        // ? Backup of team1 vc backup team2
        while(!EndOfBattle)
        {
            int m1_index = Team1.Backup.Count -1;
            int m2_index = Team2.Backup.Count -1;

            Machine m1 = Team1.Backup[m1_index];
            Machine m2 = Team2.Backup[m2_index];


            System.Console.WriteLine("-=-=-=-=-=-= BRAWL =-=-=-=-=-=-");
            Shift(m1, m2);
            System.Console.WriteLine("-=-=-=-=-=-==-=-=-=-=-=-");

            Team1.VerifyAlive();
            Team2.VerifyAlive();

            EndOfBattle = 
                Team1.Backup.Count == 0 ||
                Team2.Backup.Count == 0;
        }
        if (Team1.Backup.Count == 0)
            return Team2;
        return Team1;
    }

    public void Shift(Machine machine1, Machine machine2)
        => machine1.Hit(machine2);
    
}