public class Shop
{
    private List<IMachine> allMachines = new List<IMachine>();
    private List<IMachine> stock = new List<IMachine>();

    private void GetStock()
    {
        List<IMachine> newStock = new List<IMachine>();
        newStock = ShuffleMachine.Shuffle(allMachines);
        this.stock = newStock;
    }

}
