/*
 * @lc app=leetcode id=703 lang=csharp
 *
 * [703] Kth Largest Element in a Stream
 */

// @lc code=start
public class KthLargest {

    private int _k;
    private PriorityQueue<int, int> _pq = new PriorityQueue<int, int>();

    public KthLargest(int k, int[] nums) {
        _k = k;
        foreach (var n in nums) {
            Add(n);
        }
    }

    public int Add(int val) {
        _pq.Enqueue(val, val);
        while (_pq.Count > _k) {
            _pq.Dequeue();
        }
        return _pq.Peek();
    }
}


/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */
// @lc code=end

// too slow
// public class KthLargest {

//     private int _k;
//     private int[] _nums;
//     public KthLargest(int k, int[] nums) {
//         _k = k;
//         _nums = nums;
//     }

//     public int Add(int val) {
//         Array.Resize(ref _nums, _nums.Length+1);
//         _nums[_nums.Length-1] = val;
//         Array.Sort(_nums);
//         return _nums[_nums.Length-_k];
//     }
// }
