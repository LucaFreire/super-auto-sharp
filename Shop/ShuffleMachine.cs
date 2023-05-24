public static class ShuffleMachine
{
    private static Random rand = new Random();
    public static List<IMachine> Shuffle(List<IMachine> listAllMachines)
    {
        List<IMachine> listRet = new List<IMachine>();

        for (int i = 0; i < 3; i++)
            listRet.Add(listAllMachines[rand.Next(0,listAllMachines.Count)]);

        return listRet;
    }
}