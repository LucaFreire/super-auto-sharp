namespace SAS;

public class Player
{
    public int Life { get; private set; } = 5;
    public int Money { get;  set; } = 10;
    public int Trophy { get; private set; } = 0;
    public Team PlayerTeam { get; set; }

    public Player()
    {
        PlayerTeam = new Team(
            "Player",
            System.Drawing.Color.SkyBlue);
    }


    public void Sell(Machine machine)
    {
        Machine removed = PlayerTeam.RemoveMachine(machine);
        if (removed != null)
            this.Money += removed.GetValue();

    }

}