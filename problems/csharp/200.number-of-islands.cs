/*
 * @lc app=leetcode id=200 lang=csharp
 *
 * [200] Number of Islands
 */

// @lc code=start
public class Solution {
    public int NumIslands(char[][] grid) {

        int ret = 0;
        bool [,] isChecked = new bool[grid.Length, grid[0].Length];
        Queue<(int i, int j)> queue = new();

        void bfs(int i, int j) {
            queue.Enqueue((i, j));

            while(queue.Count > 0) {
                var t = queue.Dequeue();
                if (t.i < 0 || grid.Length <= t.i || t.j < 0 || grid[t.i].Length <= t.j) continue;
                if (isChecked[t.i,t.j]) continue;
                isChecked[t.i,t.j] = true;

                if (grid[t.i][t.j] == '0') continue;
                queue.Enqueue((t.i-1, t.j));
                queue.Enqueue((t.i, t.j-1));
                queue.Enqueue((t.i+1, t.j));
                queue.Enqueue((t.i, t.j+1));
            }
        }

        for (var i = 0; i < grid.Length; i++) {
            for (var j = 0; j < grid[i].Length; j++) {
                if(!isChecked[i,j] && grid[i][j] == '1') {
                    ret++;
                    bfs(i, j);
                }
            }
        }
        return ret;
    }
}
// @lc code=end

