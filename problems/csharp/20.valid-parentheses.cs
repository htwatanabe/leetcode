/*
 * @lc app=leetcode id=20 lang=csharp
 *
 * [20] Valid Parentheses
 */

// @lc code=start
public class Solution {
    public bool IsValid(string s) {
        Dictionary<char, char> brackets = new Dictionary<char, char>();
        brackets.Add('(', ')');
        brackets.Add('[', ']');
        brackets.Add('{', '}');

        Stack<char> chars = new Stack<char>();

        char current;
        foreach (char c in s){
            if(brackets.TryGetValue(c, out var e))
            {
                chars.Push(e);
                continue;
            }
            if (chars.Count == 0) return false;
            if (c != chars.Pop()) return false;
        }
        return chars.Count == 0;
    }
}
// @lc code=end

