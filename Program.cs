using SAS;

class Program
{
    static void Main()
    {
        // FactoryMachine factory = new FactoryMachine();
        // var list = factory.CreateMachines();
        // foreach(Machine mac in list)
        // {
        //     Console.WriteLine(mac);
        // }

        // var listt = RandomMachines.GetRandomMachines();
        // foreach(Machine mac in listt)
        // {
        //     Console.WriteLine(mac);
        // }
    
        Shop sh = new Shop();

        sh.ShowStock();
    
    }
}
