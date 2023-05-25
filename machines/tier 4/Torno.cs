namespace SAS;
public class Torno : SpecialMachine
{
    public Torno()
    {
        this.Name = "Torno";
        this.Tier = 4;

        this.Atk = 5;
        this.Def = 3;
    }

    public override void SpecialMethod() // no final do turno de compra, caso você possua uma peça nível 3, recebe 2 de ataque e 2 de vida.
    {
        throw new NotImplementedException();
    }
}