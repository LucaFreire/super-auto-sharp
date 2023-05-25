namespace SAS;

public interface FactoryMachineMethod
{
    Machine Create(string name);
}

public class FactoryMachine : FactoryMachineMethod
{
    public List<string> MachineNames = new List<string>()
    {"martelo", "chave de fenda", "esteira", "forno industrial a gas", "furadeira de coluna", 
    "retifica plana", "forno industrial eletrico", "furadeira de coordenada", "retifica cilindrica", 
    "fresa", "torno", "fresa cnc", "torno cnc", "corte a plasma cnc"};
    
    public Machine Create(string name)
    {
        switch(name.ToLower())
        {
            case "martelo": // tier 1
                return new Martelo();
            case "chave de fenda":
                return new ChaveDeFenda();
            case "esteira":
                return new Esteira();
            case "forno industrial a gas": // tier 2
                return new FornoIndustrialAGas();
            case "furadeira de coluna":
                return new FuradeiraDeColuna();
            case "retifica plana":
                return new RetificaPlana();
            case "forno industrial eletrico": // tier 3
                return new FornoIndustrialEletrico();
            case "furadeira de coordenada":
                return new FuradeiraDeCoordenada();
            case "retifica cilindrica":
                return new RetificaCilindrica();
            case "fresa":  // tier 4
                return new Fresa();
            case "torno":
                return new Torno();
            case "fresa cnc": // tier 5
                return new FresaCNC();
            case "torno cnc":
                return new TornoCNC();
            case "corte a plasma cnc":
                return new CorteAPlasmaCNC(); // tier 6
            default:
                throw new Exception("Máquina inválida.");
        }
    }
}