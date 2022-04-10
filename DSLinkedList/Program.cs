using System.Diagnostics.Metrics;
using System.Threading.Tasks;

namespace DSLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            ModifiedLinkedList<int> list = new ModifiedLinkedList<int>();
            //LinkedList<int> list = new LinkedList<int>();       // Created new Linked List 
            list.Append(56); // Calling method of CustomLinkedList generic class to append 56
            list.Append(30); // Calling method of CustomLinkedList generic class to append 70
            list.Append(70); // Calling method of CustomLinkedList generic class to append 30 
            list.DisplayElement(); // Calling method of CustomLinkedList generic class to display linkedlist element
            list.DeleteLastElement(); // Calling method of CustomLinkedList generic class to delete last element of linkedlist element
            list.DisplayElement(); // Calling method of CustomLinkedList generic class to display linkedlist element
        }
    }
}