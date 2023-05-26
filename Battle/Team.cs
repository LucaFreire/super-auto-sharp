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

    public void Reset()
        => this.backup = Machines.ToList();

    public Team AddMachine(Machine machine)
    {
        this.Machines[index] = machine;
        index++; 
        return this;
    }

    public Machine RemoveMachine(Machine machine)
    {
        int index=0;
        Machine removed = null;
        for (int i = 0; i < Machines.Length; i++)
        {
            if(Machines[i] == machine)
            {
                index = i;
                removed = Machines[i];
                Machines[i] = null;
            }
        }

        OrganizeTeam();

        return removed;
    }

    public void OrganizeTeam()
    {
        for (int i = index; i < Machines.Length; i++)
        {
            if (Machines[i] == null)
            {
                Machines[i] = Machines[i + 1];
                Machines[i + 1] = null;
                break;
            }
        }
    }

    public void BattleEnd()
        => this.backup = Machines.ToList();
    
    public override string ToString()
    {
        string str = $"{this.Name} | {this.ColorTeam}";
        foreach (var item in Machines)
            str+= "\n" + item;
        return str;
    }
}