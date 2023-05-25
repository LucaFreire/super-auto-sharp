namespace SAS;
public static class BuyClass
{
    private static int value = 3;
    public static Machine? Buy(this Player player, Machine machine)
    {
        if(player.Money >= value)
        {
            player.PlayerTeam.AddMachine(machine);
            player.Money -= value;

            return machine;
        }
        return null;
    }
}