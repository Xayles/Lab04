using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class MusicArtist
    {
        public string StageName;
        public string FoundersName;
        public string Country;
        public string Genre;
        public int YearFormed;
        public int DebutYear;
        public bool IsActive;
        public bool SupportUkraine;

        public MusicArtist(string stageName, string foundersName, string country, string genre, int yearFormed, int debutYear, bool isActive, bool supportUkraine)
        {
            StageName = stageName;
            FoundersName = foundersName;
            Country = country;
            Genre = genre;
            YearFormed = yearFormed;
            DebutYear = debutYear;
            IsActive = isActive;
            SupportUkraine = supportUkraine;
        }
        
        public int GetCareerYears()
        {
            return DateTime.Now.Year - DebutYear;
        }

        public void DisplayInfo()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("\nІнформація про виконавця:");
            Console.WriteLine($"Сценічне ім'я: {StageName}");
            Console.WriteLine($"Ім'я засновника: {FoundersName}");
            Console.WriteLine($"Країна: {Country}");
            Console.WriteLine($"Музичний жанр: {Genre}");
            Console.WriteLine($"Рік заснування: {YearFormed}");
            Console.WriteLine($"Рік дебюту: {DebutYear}");
            Console.WriteLine($"Чи активний виконавець: {(IsActive ? "Так" : "Ні")}");
            Console.WriteLine($"Чи підтримує автор Україну: {(SupportUkraine ? "Так" : "Ні")}");

            int careerYears = GetCareerYears();
            Console.WriteLine($"Кар'єра виконавця {StageName} становить {careerYears} років.");
        }
    }
}
