namespace SAS;
using static Console;
public abstract class Machine
{
    public string Name { get; protected set; }
    public int Tier { get; protected set; }
    public int Atk { get; protected set; }
    public int Def { get; protected set; }
    public int Exp { get; protected set; }
    public int Level { get; protected set; }

    public Machine()
    {
        this.Exp = 1;
        this.Level = 1;
    }

    public void Hit(Machine machine)
    {
        System.Console.WriteLine(this);
        System.Console.WriteLine(machine);

        this.Def -= machine.Atk;
        machine.Def -= this.Atk;

        System.Console.WriteLine();
        System.Console.WriteLine(this);
        System.Console.WriteLine(machine);
    }

    public override string ToString()
        => this.Name + " |" + this.Atk + "⚔" + this.Def + "❤";

    public virtual int GetValue()
        => this.Level;

    public void Join(Machine mach2)
    {
        if (this.Level == 3 || mach2.Level == 3)
        {
            WriteLine("Você não pode combinar máquinas de nível 3!");
            return;
        }

        this.Exp += mach2.Exp;
        this.Atk = (Math.Max(this.Atk, mach2.Atk) + 1);
        this.Def = (Math.Max(this.Def, mach2.Def) + 1);

        this.VerifyLevelUp();
    }

    private void VerifyLevelUp()
    {
        if (this.Level == 3)
            return;

        switch (this.Level)
        {
            case 1:
                if (this.Exp >= 3)
                    this.Level++;
                break;
            case 2:
                if (this.Exp >= 6)
                    this.Level++;
                break;
        }
    }
}

public abstract class SpecialMachine : Machine
{
    public abstract void SpecialMethod();
}
