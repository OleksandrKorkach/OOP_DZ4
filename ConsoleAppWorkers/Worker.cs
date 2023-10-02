namespace ConsoleApp1;

public abstract class Worker
{
    public string Name { get; }
    public string? Position { get; protected set; }
    
    public string? WorkDay { get; private set; } 
    
    protected Worker(string name)
    {
        WorkDay = "";
        Name = name;
    }

    protected void Call()
    {
        WorkDay += "Call... \n";
    }

    protected void WriteCode()
    {
        WorkDay += "Write code... \n";
    }

    protected void Relax()
    { 
        WorkDay += "Relaxing... \n";
    }

    public abstract void FillWorkDay();
}

