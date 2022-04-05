using System.Diagnostics.Metrics;
using System.Threading.Tasks;

namespace DSLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=1;
            
            LinkedList<int> list = new LinkedList<int>();       // Created new Linked List 
            list.AddFirst(56);      // Adding first element in list
            list.AddLast(30);       // Adding element at last position
            list.AddLast(70);       // Again adding one element after 30

            foreach (var item in list)
            {
                Console.WriteLine($"Element at {i} position {item}"); 
                i++;               
            }
        }
    }
}