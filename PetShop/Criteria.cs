public interface Criteria<T>
{
    bool IsSatisfied(T item);
}