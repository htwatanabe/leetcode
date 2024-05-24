/*
 * @lc app=leetcode id=141 lang=csharp
 *
 * [141] Linked List Cycle
 */

// @lc code=start
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
public class Solution {
    public bool HasCycle(ListNode head) {
        HashSet<ListNode> nodeList = new HashSet<ListNode>();
        ListNode current = head;

        while (current != null)
        {
            if (nodeList.Contains(current)) return true;
            nodeList.Add(current);
            current = current.next;
        }

        return false;
    }
}
// @lc code=end

