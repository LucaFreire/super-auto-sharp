namespace SAS;

public abstract class FactoryMachineMethod
{
    public abstract List<Machine> CreateMachines();
}

public class FactoryMachine : FactoryMachineMethod
{
    private List<Machine> machines = new List<Machine>();

    public FactoryMachine()
    {
        this.machines = CreateMachines();
    }
    
    public override List<Machine> CreateMachines()
    {
        List<Machine> retMachines = new List<Machine>()
            {
                new ChaveDeFenda(),
                new Esteira(),
                new Martelo(),
                new FornoIndustrialAGas(),
                new FuradeiraDeColuna(),
                new RetificaPlana(),
                new Fresa(),
                new Torno(),
                new FresaCNC(),
                new TornoCNC(),
                new CorteAPlasmaCNC()
            };
        
        return retMachines;
    }
}