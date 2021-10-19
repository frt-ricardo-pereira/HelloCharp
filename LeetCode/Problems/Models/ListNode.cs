

namespace Leetcode.Problems.Models
{
    public class ListNode
    {
        public int val;
        public ListNode? next;
        public ListNode(int val = 0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }
        public override bool Equals(object? obj)
        {
            if(obj == null )
                return false;
            if (Object.ReferenceEquals(this, obj))
            {
                return true;
            }
            if (this.GetType() != obj.GetType())
            {
                return false;
            }
            var currentOther = obj as ListNode;

            var current = this;
            var next = current.next;
            while (current != null && currentOther != null)
            {
                if(current.val != currentOther.val)
                {
                    return false;
                }
                
                current = next;
                next = current?.next;
                currentOther = currentOther.next;
         

            }
            if (currentOther == null && current != null)
                return false;

            if (currentOther != null && current == null)
                return false;

            return true;
        }

        public static bool operator ==(ListNode lhs, ListNode rhs)
        {
            if (lhs is null)
            {
                if (rhs is null)
                {
                    return true;
                }
                return false;
            }
            return lhs.Equals(rhs);
        }

        public static bool operator !=(ListNode lhs, ListNode rhs) => !(lhs == rhs);


        public override int GetHashCode()
        {
            int hashCode = 1;
            var current = this;

            while (current != null)
            {
                hashCode = 31 * hashCode + (current == null ? 0 : current.GetHashCode());
                current = current?.next;
            }
            return hashCode;
        }
    }



    

}
