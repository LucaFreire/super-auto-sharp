public class Battle
{
    public Team Team1 { get; set; }
    public Team Team2 { get; set; }
    public Battle(Team t1, Team t2)
    {
        this.Team1 = t1;
        this.Team2 = t2;
    }

    public void Battle()
    {
        IMachine m1 = Team1.Strategy.GetAttakerMachine();
        IMachine m2 = Team2.Strategy.GetDeffenderMachine();
    }
}