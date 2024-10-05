using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LinkedListProject
{
    public class LinkedList
    {
        public Node? Head { get; private set; }
        public Node? Tail { get; private set; }
        public int Length { get; private set; }

        public static LinkedList MergeSortedLists(LinkedList list1, LinkedList list2)
        {
            Node pointer1 = list1.Head!;
            Node pointer2 = list2.Head!;

            LinkedList mergedList = new LinkedList();

            void addNode(ref Node pointer)
            {
                mergedList.Add(pointer.value);
                pointer = pointer.next;
            }
            
            void AddRemainingNodes(Node pointer)
            {
                while (pointer is not null)
                {
                    addNode(ref pointer);
                }
            }

            while (pointer1 is not null && pointer2 is not null)
            {
                if (pointer1.value <= pointer2.value)
                {
                    addNode(ref pointer1);
                }
                else
                {
                    addNode(ref pointer2);
                }
            }

            AddRemainingNodes(pointer1);
            AddRemainingNodes(pointer2);

            return mergedList;
        }

        public void addArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                this.Add(arr[i]);
            }
        }

        public void RemoveDuplicate()
        {
            Node? current = Head;
            while (current != null)
            {
                Node? tracker = current.next;
                while (tracker != null)
                {
                    if (tracker.value == current.value)
                    {
                        Remove(tracker.value);
                        break;
                    }
                    tracker = tracker.next;
                }
                current = current.next;
            }
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
            Node? tracker = Head;
            if (Head is not null && Head.value == value)
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
                if (tracker == Tail && value == Tail.value)
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
            else if (Length > 1)
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
            return $"Head {(Length == 0 ? "" : "-> ")}" + String.Join(" -> ", values) + " -> Null";
        }

        public override bool Equals(object obj)
        {
            if (obj is not LinkedList other)
                return false;

            Node current1 = Head;
            Node current2 = other.Head;

            while (current1 != null && current2 != null)
            {
                if (current1.value != current2.value)
                    return false;

                current1 = current1.next;
                current2 = current2.next;
            }

            return current1 == null && current2 == null;
        }

        public void RotateLeft(int k)
        {
            if (Head == null || k <= 0 || k >= Length)
            {
                return;
            }

            // Find the k-th node and the last node
            Node current = Head;
            Node kthNode = null;
            Node lastNode = null;
            int count = 1;

            while (current.next != null)
            {
                if (count == k)
                {
                    kthNode = current;
                }
                current = current.next;
                count++;
            }
            lastNode = current;

            if (kthNode != null && lastNode != null)
            {
                // The new head will be the node after the k-th node
                Node newHead = kthNode.next;

                // Link the old tail to the old head
                lastNode.next = Head;

                // Update the head and tail references
                Head = newHead;

                Tail = kthNode;
                
                Tail.next = null;
            }
        }
    }
}
