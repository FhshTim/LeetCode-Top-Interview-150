/*
Problem: 27. Remove Element
Difficulty: Easy
Link: https://leetcode.com/problems/remove-element/
Approach: Optimal - Two Pointers - Same Direction
Time Complexity: O(n)
Space Complexity: O(1)
*/

public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int slow = 0;

        for (int fast = 0; fast < nums.Length; fast++)
        {
            if (nums[fast] != val)
            {
                nums[slow] = nums[fast];
                slow++;
            }
        }
        
        return slow;
    }
}
