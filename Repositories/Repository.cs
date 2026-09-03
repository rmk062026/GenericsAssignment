using GenericsAssignment.interfaces;

namespace GenericsAssignment.Repositorys;

public class Repository<T> : IRepository<T>
{
    private List<T> items = new();
    public void Add(T item)
    {
        items.Add(item);
    }

    public List<T> GetAll()
    {
        return items;
    }

    public bool Remove(T item)
    {
        return items.Remove(item);
    }
}