/*
Problem: 88. Merge Sorted Array
Difficulty: Easy
Link: https://leetcode.com/problems/merge-sorted-array/
Approach: Naive - Merge using extra array
Time Complexity: O(m+n)
Space Complexity: O(m+n)
*/


public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int nLength = m + n;
        int[] ans = new int[nLength];
        
        int nTempM = 0;
        int nTempN = 0;
        
        for (int i = 0; i < nLength; i++)
        {
            if (nTempN >= n || (nTempM < m && (nums1[nTempM] <= nums2[nTempN])))
            {
                ans[i] = nums1[nTempM];
                nTempM += 1;
                
            }
            else
            {
                ans[i] = nums2[nTempN];
                nTempN += 1;
                
            }
        }

        for (int i = 0; i < nLength; i++) {
            nums1[i] = ans[i];
        }
    }
}
