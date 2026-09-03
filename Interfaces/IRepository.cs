namespace GenericsAssignment.interfaces;

public interface IRepository<T> where T : class
{
    void Add(T item);
    List<T> GetAll();
    bool Remove(T item);
}