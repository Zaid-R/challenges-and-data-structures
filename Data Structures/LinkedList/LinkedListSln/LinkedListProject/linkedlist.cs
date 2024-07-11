using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProject
{
    public class LinkedList
    {
        public Node Head { get; private set; }
        public Node? Tail { get; private set; }
        public int Length { get; private set; } = 1;

        public LinkedList(Node head)
        {
            this.Head = head;
            head.next = Tail;
        }

        public bool Includes(int value)
        {
            Node? tracker = this.Head;
            while (tracker is not null && tracker.value != value)
            {
                tracker = tracker.next;
            }
            return tracker is not null;
        }

        // return true if the value does exist and deleted, otherwise return false
        public bool Remove(int value)
        {
            Node? tracker = this.Head;
            if (tracker.value == value)
            {
                Head = Head.next;
            }
            else
            {
                while (tracker.next is not null && tracker.next.value != value)
                {
                    tracker = tracker.next;
                }
                if (tracker.next is null)
                {
                    return false;
                }
                // make the next of tracker is the next of the delete node

                tracker.next = tracker.next.next;
                if (value == Tail.value)
                {
                    Tail = tracker;
                }
            }
            Length--;
            return true;
        }

        public void Add(int value)
        {
            Node newNode = new Node(value);
            if (Length == 1)
            {
                Head.next = newNode;
                Tail = newNode;
            }
            else if(Length>1)
            {
                Tail!.next = newNode;
                Tail = newNode;
            }
            else
            {
                Head = newNode;
            }
            Length++;
        }

        public string PrintList()
        {
            int[] values = new int[Length];
            Node tracker = this.Head;
            int i = 0;
            while (tracker != null)
            {
                values[i++] = tracker.value;
                tracker = tracker.next;
            }
            return $"Head{(Length == 0?"": "-> ")}" + String.Join(" -> ", values) + " -> Null";
        }
    }
}
