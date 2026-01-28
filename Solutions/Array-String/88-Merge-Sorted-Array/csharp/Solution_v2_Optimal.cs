/*
Problem: 88. Merge Sorted Array
Difficulty: Easy
Link: https://leetcode.com/problems/merge-sorted-array/
Approach: Optimal - Reverse Three Pointers
Time Complexity: O(m+n)
Space Complexity: O(1)
*/



public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int p1 = m - 1;
        int p2 = n - 1;
        int p = m + n - 1;

        while (p2 >= 0)
        {
            if (p1 >= 0 && nums1[p1] > nums2[p2])
            {
                nums1[p--] = nums1[p1--];
            }
            else
            {
                nums1[p--] = nums2[p2--];
            }
        }
    }
}
