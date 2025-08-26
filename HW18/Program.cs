using HW18.Models;

namespace HW18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
        {
            new Person { Name="Kamil", Surname="Huseynov", Age=25 },
            new Person { Name="Nigar", Surname="Aliyeva", Age=19 },
            new Person { Name="Elvin", Surname="Kerimov", Age=30 },
            new Person { Name="Aysel", Surname="Quliyeva", Age=21 },
            new Person { Name="Murad", Surname="Mahmudov", Age=18 }
        };

            // a) Adı Kamil olanlar
            var onlyKamil = people.FindAll(p => p.Name == "Kamil");
            Console.WriteLine("Adı Kamil olanlar:");
            foreach (var p in onlyKamil)
                Console.WriteLine(p);

            // b) Soyadı ov və ya ova ilə bitənlər
            var surnameOv = people.FindAll(p => p.Surname.EndsWith("ov") || p.Surname.EndsWith("ova"));
            Console.WriteLine("\nSoyadı 'ov' ve ya 'ova' ile bitenler:");
            foreach (var p in surnameOv)
                Console.WriteLine(p);

            // c) Yaşı 20+ olanlar
            var age20plus = people.FindAll(p => p.Age >= 20);
            Console.WriteLine("\nYaşı 20+ olanlar:");
            foreach (var p in age20plus)
                Console.WriteLine(p);
        }
    }
    
}
