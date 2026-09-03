namespace GenericsAssignment.interfaces;

public interface IRepository<T>
{
    void Add(T item);
    List<T> GetAll();
    bool Remove(T item);
}