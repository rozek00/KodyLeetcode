/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution 
{
    public bool HasCycle(ListNode head) 
    {
        if (head == null) return false;
        
        ListNode next = head;
        HashSet<ListNode> Nodes = new HashSet<ListNode>();

        while (next != null) 
        {
            if (Nodes.Contains(next)) 
            {
                return true;
            }
            Nodes.Add(next);
            next = next.next;
        }
        return false;
    }
}
