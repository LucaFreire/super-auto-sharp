namespace SAS;

public interface FactoryMachineMethod
{
    Machine Create(string name);
}

public class FactoryMachine : FactoryMachineMethod
{
    public Machine Create(string name)
    {
        switch(name)
        {
            case "Martelo":
                return new Martelo();
            case "Chave de Fenda":
                return new ChaveDeFenda();
            case "Esteira":
                return new Esteira();
            default:
                throw new Exception("Máquina inválida.");
        }
    }
}