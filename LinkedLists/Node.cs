namespace LinkedLists
{
    public class Node<T>
    {
        public T Element { get; set; }
        public T Pointer { get; set; }

        public Node(T first, T second){
            Element = first;
            Pointer = second;
        }
    }
}