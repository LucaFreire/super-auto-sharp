public class Battle
{
    public Team Team1 { get; set; }
    public Team Team2 { get; set; }
    private bool EndOfBattle = false;
    public Battle(Team t1, Team t2)
    {
        this.Team1 = t1;
        this.Team2 = t2;
    }

    public void Battle()
    {
        // ? Backup of team1 vc backup team2
        while(!EndOfBattle)
        {
            int m1_index = Team1.Count;
            int m2_index = Team2.Count;

            


            EndOfBattle = 
                Team1.Backup.Count == 0 ||
                Team2.Backup.Count == 0;
        }
    }
}