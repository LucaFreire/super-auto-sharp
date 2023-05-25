namespace SAS;
public class Shop
{
    private List<Machine> stock = new List<Machine>();
    private void GetStock()
    {
        List<Machine> newStock = new List<Machine>();
        newStock = RandomMachines.GetRandomMachines();
        this.stock = newStock;
    }

}
