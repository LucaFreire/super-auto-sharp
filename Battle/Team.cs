using System.Drawing;

public class Team
{
    public string? Name { get; private set; }
    public Color ColorTeam { get; private set; }
    public IMachine[] Machines { get; private set; }
    public List<IMachine> Backup { get; private set; }

    public Team(string name, Color color, IMachine[] machines)
    {
        this.Name = name;
        this.ColorTeam = color;
        this.Machines = machines;
        this.Backup = machines.ToList();
    }
}