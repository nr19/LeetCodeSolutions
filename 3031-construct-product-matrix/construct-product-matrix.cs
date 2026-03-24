public class Solution {
    private const int MOD = 12345;

    public int[][] ConstructProductMatrix(int[][] grid) {
        int rows = grid.Length;
        int cols = grid[0].Length;
        int n = rows * cols;

        int[] arr = new int[n];
        int idx = 0;

        // Flatten
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                arr[idx++] = grid[i][j] % MOD;
            }
        }

        long[] prefix = new long[n];
        long[] suffix = new long[n];

        prefix[0] = 1;
        for (int i = 1; i < n; i++) {
            prefix[i] = (prefix[i - 1] * arr[i - 1]) % MOD;
        }

        suffix[n - 1] = 1;
        for (int i = n - 2; i >= 0; i--) {
            suffix[i] = (suffix[i + 1] * arr[i + 1]) % MOD;
        }

        int[][] result = new int[rows][];
        idx = 0;

        for (int i = 0; i < rows; i++) {
            result[i] = new int[cols];
            for (int j = 0; j < cols; j++) {
                result[i][j] = (int)((prefix[idx] * suffix[idx]) % MOD);
                idx++;
            }
        }

        return result;
    }
}