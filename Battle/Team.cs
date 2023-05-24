using System.Drawing;

public class Team
{
    public string? Name { get; private set; }
    public Color ColorTeam { get; private set; }
    public IStrategy Strategy { get; private set; }
    public IMachine[] Machines { get; private set; }
    public IMachine[] Backup { get; private set; }

    public Team(string name, Color color, Machine[] machines)
    {
        this.Name = name;
        this.ColorTeam = color;
        this.Machines = machines;
        this.Backup = machines;
    }
}