using Leetcode.Problems.Models;

namespace Leetcode.Problems
{
    public static class Add_Two_Numbers
    {
        /**
         * https://leetcode.com/problems/add-two-numbers/
         * */

        public static ListNode SolutionOn(ListNode l1, ListNode l2)
        {
            var linkNode = new ListNode(0 , null);
            var currentLinkNodeAdd = linkNode;
            int add = 0;
            var toContinue = (l1 != null || l2 != null);
            while (toContinue)
            {
                var firstValue = l1?.val ?? 0;
                var secondValue = l2?.val ?? 0;
                var sum = firstValue + secondValue + add;
                var res = sum % 10;
                currentLinkNodeAdd.val = res;            
                add = sum / 10;
                l1 = l1 != null ? l1.next : null;
                l2 = l2 != null ? l2.next : null;
                toContinue = l1 != null || l2 != null;
                if (toContinue)
                {
                    currentLinkNodeAdd.next = new ListNode(0, null);
                    currentLinkNodeAdd = currentLinkNodeAdd.next;
                }
            }         

            if (add != 0)
            {
                currentLinkNodeAdd.next = new ListNode(add, null);

            }
    
            return linkNode;
        }
    }





}
