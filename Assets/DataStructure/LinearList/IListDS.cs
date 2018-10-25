


namespace LinearList
{
    public interface IListDS<T>
    {
        int Count { get; }
        void Insert(T item, int index);
        void Add(T item);
        bool IsEmpty();
        T GetElement(int index);
        T Delete(int index);
        T this[int index] { get; }
        void Clear();
        int LocateElement(T item);
    }
}
