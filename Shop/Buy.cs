namespace SAS;
public static class BuyClass
{
    private static int value = 3;
    public static void Buy(this Player player, Machine machine)
    {
        if(player.Money >= value)
        {
            player.PlayerTeam.AddMachine(machine);
            player.Money -= value;
            machine.RemoveFromStock(ref Shop.stock);
        }
    }
    public static void RemoveFromStock(this Machine machine, ref List<Machine> stockList)
        => stockList.Remove(machine);
}