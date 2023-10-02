namespace ConsoleApp1;

class Program
{
    public static void Main()
    {
        Worker dev = new Developer("Jack");
        Worker manager = new Manager("Daniel");
        Team team = new("Project Team");
        team.AddNewMember(dev);
        team.AddNewMember(manager);
        team.ShowDetailedInfo();
    }
}