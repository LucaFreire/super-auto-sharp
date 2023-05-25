namespace SAS;
public static class RandomMachines
{
    private static Random rand = new Random();
    public static List<Machine> GetRandomMachines()
    {
        List<Machine> listRet = new List<Machine>();
        
        FactoryMachine factory = new FactoryMachine();
        List<Machine> machines = factory.CreateMachines();

        for (int i = 0; i < 3; i++)
            listRet.Add(machines[rand.Next(0, machines.Count - 1)]);

        return listRet;
    }
}