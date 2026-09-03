namespace GenericsAssignment;

using GenericsAssignment.Models;
using GenericsAssignment.Repositories;

class Program
{
    static void Main(string[] args)
    {
        Repository<string> stringRepository = new();
        Repository<Contact> contactRepository = new();

        contactRepository.Add(new Contact
        {
            Name = "Martin",
            Email = "martin@gmail.com"
        });

        foreach (Contact contact in contactRepository.GetAll())
        {
            Console.WriteLine($"{contact.Name} - {contact.Email}");
        }

        stringRepository.Add("HEI");
        stringRepository.Add("Verden!");

        stringRepository.Remove("Verden!");
        foreach (string item in stringRepository.GetAll())
        {
            Console.WriteLine(item);
        }
    }
}
