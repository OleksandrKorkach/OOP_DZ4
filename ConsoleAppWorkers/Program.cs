namespace ConsoleApp1;

class Program
{
    public static void Main()
    {
        Worker dev = new Developer("Jack");
        dev.FillWorkDay();
        Worker manager = new Manager("Daniel");
        manager.FillWorkDay();
        Team team = new("Project Team");
        team.AddNewMember(dev);
        team.AddNewMember(manager);
        team.ShowDetailedInfo();
    }
}