namespace LinkedLists.Interfaces
{
    public interface ILinkedList<T>
    {
        void Add(T obj);

        void RemoveAt(int index);
    }
}