using Xunit;
using Leetcode.Problems;
using Leetcode.Problems.Models;

namespace HelloSharp.Test.Leetcode
{
    public class Add_Two_Numbers_Tests
    {
        [Fact]
        public void Example1()
        {
            ListNode node = new(2, new(4, new(3, null)));
            ListNode node2 = new(5, new(6, new(4, null)));           

            var actual = Add_Two_Numbers.SolutionOn(node, node2);
            
            ListNode nodeToCompare = new(7, new(0, new(8, null)));                    
            Assert.True(nodeToCompare == actual);
        }
        [Fact]
        public void Example2()
        {
            ListNode node = new(0, null);
            ListNode node2 = new(0, null);

            var actual = Add_Two_Numbers.SolutionOn(node, node2);

            ListNode nodeToCompare = new(0, null);
            Assert.True(nodeToCompare == actual);
        }
        [Fact]
        public void Example3()
        {
            ListNode node = new(9, new(9, new(9, new(9, new(9 , new (9 , new(9 , null )))))));
            ListNode node2 = new(9, new(9, new(9, new(9 , null))));

            var actual = Add_Two_Numbers.SolutionOn(node, node2);

            ListNode nodeToCompare = new(8, new(9, new(9, new(9, new(0, new(0, new(0 , new(1 , null))))))));
            Assert.True(nodeToCompare == actual);
        }
    }

}