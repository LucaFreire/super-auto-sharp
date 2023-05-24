namespace SAS;

public abstract class Machine
{
    public string Name { get; protected set; }
    public int Tier { get; protected set; }
    public int Atk { get; protected set; }
    public int Def { get; protected set; }
    public int Exp { get; protected set; }
    public int Level { get; protected set; }
}

public abstract class SpecialMachine : Machine
{
    public abstract void SpecialMethod();
}