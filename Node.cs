namespace DSLinkedList
{
    internal class Node<T>
    {
        public T data; // Adata variable
        public Node<T> next; // declaring a next node
        public Node(T data) // Cratinf constructor havind node data as parameter
        {
            this.data = data;
        }
    }
}