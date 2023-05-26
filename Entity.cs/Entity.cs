namespace SAS;
using SAS.Entities;

public abstract class Entity
{
    
    public int Money { get; private set; } = 10;
    public Team PlayerTeam { get; set; }
    public IComportament comp { get; private set; }
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
    
    public void Buy(Machine machine)
    {
        if(this.Money >= Machine.BuyValue)
        {
            this.Money -= Machine.BuyValue;
            this.PlayerTeam.AddMachine(machine);
            machine.RemoveFromStock(ref Shop.stock);
        }
    }
}