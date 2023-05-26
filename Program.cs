using SAS;

Player p1 = new Player();
FactoryMachine f = new FactoryMachine();

var allMachines = f.CreateMachines();

p1.Buy(allMachines[0]);

Console.WriteLine(p1.PlayerTeam);