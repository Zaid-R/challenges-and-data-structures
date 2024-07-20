using LinkedListProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked.List.Tests
{
    public class MergeSortedLinkedLists
    {

        [Fact]
        public void MergeSortedLists_OneListEmpty()
        {
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();
            int[] arr = { 1, 2, 3 };
            list2.addArray(arr);

            LinkedList result = LinkedList.MergeSortedLists(list1, list2);

            LinkedList expected = new LinkedList();
            expected.addArray(arr);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void MergeSortedLists_BothListsEmpty()
        {
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();

            LinkedList result = LinkedList.MergeSortedLists(list1, list2);

            LinkedList expected = new LinkedList();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void MergeSortedLists_ExampleCase()
        {
            LinkedList list1 = new LinkedList();
            list1.addArray(new int[] { 2, 5, 10 });

            LinkedList list2 = new LinkedList();
            list2.addArray(new int[] { 3, 15, 20 });

            LinkedList result = LinkedList.MergeSortedLists(list1, list2);

            LinkedList expected = new LinkedList();
            expected.addArray(new int[] { 2, 3, 5, 10, 15, 20 });

            Assert.Equal(expected, result);
        }
    }
}
