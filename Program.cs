namespace GenericsAssignment;

using GenericsAssignment.Repositorys;

class Program
{
    static void Main(string[] args)
    {
        Repository<string> stringRepository = new();

        stringRepository.Add("HEI");
        stringRepository.Add("Verden!");

        stringRepository.Remove("Verden!");
        foreach (string item in stringRepository.GetAll())
        {
            Console.WriteLine(item);
        }
    }
}
