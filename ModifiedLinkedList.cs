namespace DSLinkedList
{
    internal class ModifiedLinkedList<T>
    {
        public Node<T> head;        // head for linked list
        public void AddFirst(T data)        // creating generic method to Add element at first 
        {
            Node<T> nextNode = new Node<T>(data);       // Creating a new node 
            if (head == null)
            {
                head = nextNode;      // If head is null then hode will be new node
                Console.WriteLine($"{newNode.data} is inserted at first of linked list");
                return;
            }
            nextNode.next = this.head;      // newnode pointing to where head is currently pointing
            head = nextNode;        // head is pointing to new node
            Console.WriteLine($"{nextNode.data} is inserted at first of linked list");
        }
        public void DisplayElement()        // creating generic method to display element at first of linked list
        {
            {
                Node<T> temp = this.head;       // taking head as temp node
                if (temp == null)       // If head is null that means linked list is empty
                {
                    Console.WriteLine("\nThe LinledList is Empty");
                    return;
                }
                Console.WriteLine("\nElements of linked list in sequence are : ");
                while (temp != null)        // If head is not null then print one by one element of linked list
                {
                    Console.WriteLine(temp.data + " ");
                    temp = temp.next;       // Go to next node
                }
            }
        }
    }
}
