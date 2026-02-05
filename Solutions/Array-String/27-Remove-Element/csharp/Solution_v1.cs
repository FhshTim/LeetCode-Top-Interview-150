/*
Problem: 27. Remove Element
Difficulty: Easy
Link: https://leetcode.com/problems/remove-element/
Approach: Naive - Two Pointers
Time Complexity: O(n)
Space Complexity: O(1)
*/

public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int k = nums.Length - 1;
        int i = 0;

        while (i <= k)
        {
            if (nums[i] == val)
            {
                nums[i] = nums[k--];
            }
            else
            {
                i++;
            }
        }

        return k + 1;
    }
}
