/*
 * @lc app=leetcode id=300 lang=csharp
 *
 * [300] Longest Increasing Subsequence
 */

// @lc code=start

// too slow
public class Solution {
    public int LengthOfLIS(int[] nums) {
        var len = nums.Length;
        var dp = new int[len];
        void fillDpArray(int idx) {
            for (var i = idx; i < len; i++) {
                if (dp[i] != 0) return;
                for (var j = i+1; j < len; j++) {
                    if (nums[i] < nums[j]) {
                        if (dp[j] == 0) fillDpArray(j);
                        if (dp[i] < dp[j]+1) dp[i] = dp[j]+1;
                    }
                }
                if (dp[i] == 0) dp[i] = 1;
            }
        }

        fillDpArray(0);
        return dp.Max();
    }
}
// @lc code=end

