// Problem: 27. Remove Element
// Difficulty: Easy
// Link: https://leetcode.com/problems/remove-element/
// Approach: Two Pointers
// Time Complexity: O(n)
// Space Complexity: O(1)

func removeElement(nums []int, val int) int {
    k, p := len(nums) - 1, 0

    for p <= k {
        if nums[p] == val {
            nums[p] = nums[k]
            k--
        } else {
            p++
        }
    }

    return k + 1
}
