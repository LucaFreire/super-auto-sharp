using System.Drawing;
namespace SAS;

public class Team
{
    public string Name { get; private set; }
    public Color ColorTeam { get; private set; }
    private int index = 0;
    public Machine[] Machines { get; private set; } = new Machine[5];
    private List<Machine> backup = new List<Machine>();
    public IEnumerable<Machine> Backup => backup;

    public Team(string name, Color color)
    {
        this.Name = name;
        this.ColorTeam = color;
    }

    public void VerifyAlive()
    {
        List<Machine> aux = new List<Machine>();
        foreach (var item in this.Backup)
            if (item.Def > 0)
                aux.Add(item);
        this.backup = aux;
    }

    public void SetMachines(Machine[] machines)
    {
        this.Machines = machines;
        this.backup = machines.ToList();
    }

    public void AddMachine(Machine machine)
    {
        this.Machines[index] = machine;
        index++; 
    }
}