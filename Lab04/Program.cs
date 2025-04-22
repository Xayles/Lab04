using Lab04;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;

class Program
{
    static void Main(string[]args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Сценічне ім'я виконавця: ");
        string StageName = Console.ReadLine();

        Console.Write("Ім'я засновника: ");
        string FoundersName = Console.ReadLine();

        Console.Write("Країна: ");
        string Country = Console.ReadLine();

        Console.Write("Музичний жанр: ");
        string Genre = Console.ReadLine();

        Console.Write("Рік заснування: ");
        int YearFormed = int.Parse(Console.ReadLine());

        Console.Write("Рік дебюту: ");
        int DebutYear = int.Parse(Console.ReadLine());

        Console.Write("Чи активний виконавець? (y - так / n - ні): ");
        bool IsActive = Console.ReadLine()?.Trim().ToLower() == "y";

        Console.Write("Чи підтримує автор Україну? (y - так / n - ні): ");
        bool SupportUkraine = Console.ReadLine()?.Trim().ToLower() == "y";

        MusicArtist musicArtist = new MusicArtist(StageName, FoundersName, Country, Genre, YearFormed, DebutYear, IsActive, SupportUkraine);

        musicArtist.DisplayInfo();

        Console.ReadKey();
    }
}