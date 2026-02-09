// Problem: 26. Remove Duplicates from Sorted Array
// Difficulty: Easy
// Link: https://leetcode.com/problems/remove-duplicates-from-sorted-array/
// Approach: Naive - Two Pointers
// Time Complexity: O(n)
// Space Complexity: O(1)

func removeDuplicates(nums []int) int {
    k := 0
    for i:=1 ; i<len(nums) ; i++ {
        if nums[k] != nums[i] {
            k++
            nums[k] = nums[i]
        }
    }

    return k + 1
}
