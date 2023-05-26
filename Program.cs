using SAS;

Player p1 = new Player();
BasicEnemy bs = new BasicEnemy();

while (!p1.Comportament.Finished())
{
    var maquina = p1.Comportament.GetBuy();
    p1.Buy(maquina);
}
p1.Comportament.AttShop();

while (!bs.Comportament.Finished())
{
    var maquina = bs.Comportament.GetBuy();
    bs.Buy(maquina);
}
bs.Comportament.AttShop();

System.Console.WriteLine(p1.PlayerTeam);
System.Console.WriteLine(bs.PlayerTeam);

p1.PlayerTeam.Reset();
bs.PlayerTeam.Reset();

System.Console.WriteLine();
System.Console.WriteLine();

TeamBattle battle1 = new TeamBattle(p1.PlayerTeam, bs.PlayerTeam);
var ganhou = (battle1.Battle());