
using Leetcode.Problems;
using Leetcode.Problems.Models;
using Xunit;

namespace HelloSharp.Test.Leetcode.Models
{
    public class ListNode_Tests
    {
        [Fact]
        public void Same_Testing()
        {
            ListNode node = new(8, new(9, new(9, new(9, new(0, new(0, new(1, null)))))));
            ListNode node2 = new(8, new(9, new(9, new(9, new(0, new(0, new(1, null)))))));

            Assert.True(node == node2);
        }
        [Fact]
        public void Different_Length()
        {
            ListNode node = new(3, new(1, new(1, new(1, new(1, null)))));
            ListNode node2 = new(3, new(1, new(1, null)));

            Assert.False(node == node2);
        }
        [Fact]
        public void DifferentLength2()
        {
            ListNode node = new(3, new(1, new(1, null)));
            ListNode node2 = new(3, new(1, new(1, new(1, new(1, null)))));

            Assert.False(node == node2);
        }

        [Fact]
        public void NullTesting()
        {
            ListNode node = new(3, new(1, new(1, null)));
            ListNode node2 = null;

            Assert.False(node == node2);
        }
    }
}
