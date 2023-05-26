namespace SAS;
using SAS.Entities;

public abstract class Entity
{
    
    public int Money { get; protected set; } = 10;
    public Team PlayerTeam { get; set; }
    public IComportament Comportament { get; protected set; }
    
    public void Sell(Machine machine)
    {
        Machine removed = PlayerTeam.RemoveMachine(machine);
        if (removed != null)
            this.Money += removed.GetValue();
    }
    
    public void Buy(Machine machine)
    {
        if (machine == null)
            return;
        if(this.Money >= Machine.BuyValue)
        {
            this.Money -= Machine.BuyValue;
            this.PlayerTeam.AddMachine(machine);
        }
    }
}