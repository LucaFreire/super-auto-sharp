public class Player
{
    public int Life { get; set; } = 5;
    public int Trophy { get; set; } = 0;
    public Team PlayerTeam { get; set; }

    public Player()
    {
        PlayerTeam = new Team(
            "Player",
            System.Drawing.Color.SkyBlue,
            new IMachine[5]);
        
    }


}