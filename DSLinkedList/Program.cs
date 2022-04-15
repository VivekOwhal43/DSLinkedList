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
            list.Append(56); // Calling method of CustomLinkedList generic class to append element
            list.Append(30); 
            list.Append(70);  
            list.DisplayElement(); // Calling method of ModifiedLinkedList generic class to display linkedlist element
            list.Search(30); // Calling method of ModifiedLinkedList generic class to search element in linkedlist
        }
    }
}