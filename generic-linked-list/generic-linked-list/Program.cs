using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_linked_list
{
    internal class Program
    {

        static void print_Reverse(LinkedList<string> list)
        {
            Console.WriteLine("---In reverse order---");
            LinkedListNode<string> current = list.Last;
            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Previous;
            }

            Console.WriteLine("--------------");
        }

        static void Swap(LinkedList<string> list, LinkedListNode<string> node1, LinkedListNode<string> node2)
        {
            if (node1 == null || node2 == null || node1 == node2)
            {
                return;
            }

            string tempValue = node1.Value;
            node1.Value = node2.Value;
            node2.Value = tempValue;
        }
        
        
        static void Main(string[] args)
        {
            LinkedList<string> names = new LinkedList<string>();

            LinkedListNode<string> node = new LinkedListNode<string>("Arc");
            names.AddFirst(node);

            LinkedListNode<string> node1 = new LinkedListNode<string>("Gamma");
            names.AddAfter(node, node1);

            LinkedListNode<string> node2 = new LinkedListNode<string>("Geed");
            names.AddAfter(node1, node2);

            LinkedListNode<string> node3 = new LinkedListNode<string>("Decker");
            names.AddAfter(node2, node3);

            
            LinkedListNode<string> node4 = new LinkedListNode<string>(null);

            Console.WriteLine("List: ");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Numbers of element in list: " + names.Count);
            Console.WriteLine("First element: " + names.First.Value);
            Console.WriteLine("Last element: " + names.Last.Value);

            names.AddLast("Ginga");

            names.AddFirst("Orb");

            names.AddBefore(node3, "Jack");

            Console.WriteLine("\nList after added new elements:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            names.Remove(node2);
            Console.WriteLine("\nList after deleting node2 (Geed):");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\nList contains 'Arc': " + names.Contains("Arc"));

            print_Reverse(names);

            Console.WriteLine("------Swapping------");

            Swap(names, node1, node3);  //gamma and decker
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();

        }
    }
}
