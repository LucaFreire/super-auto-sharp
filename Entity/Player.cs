namespace SAS;
using System.Drawing;
using SAS.Entities;

public class Player : Entity
{
    
    public int Trophy { get; private set; } = 0;
    public int Life { get; private set; } = 5;

    public Player()
    {
        this.PlayerTeam = new Team(
            "Player", Color.AliceBlue
        );
        this.Comportament = new PlayerComportament();
    }
}