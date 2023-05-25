namespace SAS;
public class FuradeiraDeCoordenada : SpecialMachine
{
    public FuradeiraDeCoordenada()
    {
        this.Name = "Furadeira de Coordenada";
        this.Tier = 3;

        this.Atk = 3;
        this.Def = 5;
    }

    public override void SpecialMethod() // ao se machucar (e ficar vivo) da dano em um inimigo aleatório
    {
        throw new NotImplementedException();
    }
}