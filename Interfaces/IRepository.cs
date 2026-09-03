namespace GenericsAssignment.interfaces;

public interface IRepository<T>
{
    void Add(T item);
}