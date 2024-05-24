/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */

// @lc code=start
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dic = new Dictionary<int, int>();
        var len = nums.Length;
        for (var i = 0; i < len; i++){
            var diff = target - nums[i];
            if (dic.ContainsKey(diff)) return [dic[diff], i];
            dic[nums[i]] = i;
        }
        return [];
    }
}
// @lc code=end

