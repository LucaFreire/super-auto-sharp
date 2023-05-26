namespace SAS;
public class Shop
{
    public static List<Machine> stock = new List<Machine>();
    private void getStock(bool clear = false)
    {
        if(clear)
            stock.Clear();
        List<Machine> newStock = new List<Machine>();
        newStock = RandomMachines.GetRandomMachines();
        stock = newStock;
    }
    public void ShowStock()
    {
        getStock();
        foreach (var item in stock)
            Console.WriteLine($"{item.Name}: {item.Atk} / {item.Def}");
    }
}
