namespace SAS;
using SAS.Entities;
using System.Drawing;

public class BasicEnemy : Entity
{
    public BasicEnemy()
    {
        this.PlayerTeam = new Team(
            "Inimigo 1", Color.Red
        );
        this.Comportament = new EnemyComportament();
    }
}