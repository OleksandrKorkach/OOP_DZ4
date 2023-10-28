using System.Text;

namespace ConsoleAppTest;
using System.Text.Json;


class Program
{
    public static void Main()
    {
        string fileText = File.ReadAllText("C:\\Users\\38066\\RiderProjects\\ConsoleApp1\\ConsoleAppTest\\jsonfile.json", Encoding.UTF8);

        List<Book> books = JsonSerializer.Deserialize<List<Book>>(fileText);

        foreach (var book in books)
        {
            Console.WriteLine($"PublishingHouseId: {book.PublishingHouseId}");
            Console.WriteLine($"Title: {book.Title}");
            Console.WriteLine($"PublishingHouse: \nId: {book.PublishingHouseId}");
            Console.WriteLine($"Name: {book.PublishingHouse.Name}");
            Console.WriteLine($"Address: {book.PublishingHouse.Adress}\n");
        }
    }
}




