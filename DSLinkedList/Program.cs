using System.Diagnostics.Metrics;
using System.Threading.Tasks;

namespace DSLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=1;
            ModifiedLinkedList<int> list1 = new ModifiedLinkedList<int>();
            //LinkedList<int> list = new LinkedList<int>();       // Created new Linked List 
            list1.Append(56);      // Adding first element in list
            list1.Append(30);       // Adding element at last position
            list1.Append(70);       // Again adding one element after 30
            list1.DisplayElement();
        }
    }
}