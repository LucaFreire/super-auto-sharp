namespace SAS;
public class Shop
{
    public static List<Machine> stock = new List<Machine>();
    private void GetStock()
    {
        List<Machine> newStock = new List<Machine>();
        newStock = RandomMachines.GetRandomMachines();
        stock = newStock;
    }

}
