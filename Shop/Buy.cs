namespace SAS;
public static class BuyClass
{
    private static int value = 3;
    public static void RemoveFromStock(this Machine machine, ref List<Machine> stockList)
        => stockList.Remove(machine);
}