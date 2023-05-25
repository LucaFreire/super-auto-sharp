namespace SAS;
public class FornoIndustrialAGas : SpecialMachine
{
    public FornoIndustrialAGas()
    {
        this.Name = "Forno Industrial à Gás";
        this.Tier = 2;

        this.Atk = 1;
        this.Def = 3;
    }

    public override void SpecialMethod() // no inicio do turno de compra ganhe 1 de ouro
    {
        throw new NotImplementedException();
    }
}