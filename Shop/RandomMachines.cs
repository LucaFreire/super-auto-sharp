namespace SAS;
public static class RandomMachines
{
    private static Random rand = new Random();
    public static List<Machine> GetRandomMachines()
    {
        List<Machine> listRet = new List<Machine>();
        
        FactoryMachine factory = new FactoryMachine();
        string[] machineNames = factory.MachineNames.ToArray();

        for (int i = 0; i < 3; i++)
            listRet.Add(factory.Create(machineNames[rand.Next(0, machineNames.Length - 1)]));

        return listRet;
    }
}