//Given head, the head of a linked list, determine if the linked list has a cycle in it.
//There is a cycle in a linked list if there is some node in the list that can be reached again by continuously following the next pointer. 
//Internally, pos is used to denote the index of the node that tail's next pointer is connected to. Note that pos is not passed as a parameter.    
//Return true if there is a cycle in the linked list. Otherwise, return false.
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
