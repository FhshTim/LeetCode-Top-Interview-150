/*
Problem: 26. Remove Duplicates from Sorted Array
Difficulty: Easy
Link: https://leetcode.com/problems/remove-duplicates-from-sorted-array/
Approach: Naive - Two Pointers
Time Complexity: O(n)
Space Complexity: O(1)
*/

public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int k = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[k] != nums[i])
            {
                nums[++k] = nums[i];
            }
        }
        
        return k+1;
    }
}
