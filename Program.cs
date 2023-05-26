using SAS;

Player p1 = new Player();
BasicEnemy bs = new BasicEnemy();

while (!p1.Comportament.Finished())
{
    var maquina = p1.Comportament.GetBuy();
    p1.Buy(maquina);
    
    System.Console.WriteLine();
    System.Console.WriteLine(p1.PlayerTeam);
}
p1.Comportament.AttShop();

while (!bs.Comportament.Finished())
    bs.Comportament.GetBuy();
bs.Comportament.AttShop();

TeamBattle battle1 = new TeamBattle(p1.PlayerTeam, bs.PlayerTeam);
var ganhou = (battle1.Battle());