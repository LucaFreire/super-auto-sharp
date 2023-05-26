namespace SAS;

public abstract class Entity
{
    
    public int Money { get;  set; } = 10;
    public Team PlayerTeam { get; set; }

    public Entity()
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