using LeetCode.Core.Problems.Linked_List;

namespace LeetCode.Tests.Problems.Linked_List
{
    [Trait("Category", "Unit")]
    public class P0002_AddTwoNumbersTests
    {
        [Theory(DisplayName = "Should add the two numbers in ListNode format and return the sum in ListNode format")]
        [InlineData((int[])[2, 4, 3], (int[])[5, 6, 4], (int[])[7, 0, 8])]
        [InlineData((int[])[0], (int[])[0], (int[])[0])]
        [InlineData((int[])[9, 9, 9, 9, 9, 9, 9], (int[])[9, 9, 9, 9], (int[])[8, 9, 9, 9, 0, 0, 0, 1])]
        public void AddTwoNumbersTests(int[] list1, int[] list2, int[] expectedSum) 
        {
            // Arrange
            var l1 = ToLinkedList(list1);
            var l2 = ToLinkedList(list2);

            var solver = new P0002_AddTwoNumbers();

            // Act
            var solution = solver.AddTwoNumbers(l1, l2);

            // Assert
            Assert.Equal(ToArray(solution), expectedSum);
        }

        private static ListNode ToLinkedList(int[] values)
        {
            var dummy = new ListNode();
            var current = dummy;

            foreach (int value in values)
            {
                current.next = new ListNode(value);
                current = current.next;
            }

            return dummy.next;
        }

        private static int[] ToArray(ListNode head)
        {
            var values = new List<int>();
            var current = head;

            while (current != null)
            {
                values.Add(current.val);
                current = current.next;
            }

            return [.. values];
        }
    }
}
