namespace SAS;
public class Esteira : SpecialMachine
{
    public Esteira()
    {
        this.Name = "Esteira";
        this.Tier = 1;

        this.Atk = 3;
        this.Def = 1;

        this.Exp = 1;
        this.Level = 1;
    }

    public override void SpecialMethod()
    {
        throw new NotImplementedException();
    }
}