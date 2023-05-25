using SAS;

ChaveDeFenda chaveDeFenda = new ChaveDeFenda();
Esteira esteira = new Esteira();
Martelo martelo = new Martelo();
FornoIndustrialAGas fornoIndustrialAGas = new FornoIndustrialAGas();
FuradeiraDeColuna furadeiraDeColuna = new FuradeiraDeColuna();

Player player = new Player();
player.PlayerTeam.setMachines(new Machine[]{
    chaveDeFenda, esteira, martelo
});

Team enemy = new Team("Inimigo1",
    System.Drawing.Color.Red,
    new Machine[]{
        fornoIndustrialAGas, furadeiraDeColuna
    });

TeamBattle battle = new TeamBattle(player.PlayerTeam, enemy);
Team ganhador = battle.Battle();

System.Console.WriteLine(ganhador.Name);
