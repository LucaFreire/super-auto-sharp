using System.Drawing;
namespace SAS;

public class Team
{
    public string Name { get; private set; }
    public Color ColorTeam { get; private set; }
    public Machine[] Machines { get; private set; }
    private List<Machine> backup;
    public IEnumerable<Machine> Backup => backup;

    public Team(string name, Color color, Machine[] machines)
    {
        this.Name = name;
        this.ColorTeam = color;
        this.Machines = machines;
        this.backup = machines.ToList();
    }

    public void VerifyAlive()
    {
        List<Machine> aux = new List<Machine>();
        foreach (var item in this.Backup)
            if (item.Def > 0)
                aux.Add(item);
        this.backup = aux;
    }

    public void setMachines(Machine[] machines)
    {
        this.Machines = machines;
        this.backup = machines.ToList();
    }
}