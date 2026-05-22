public class Solution {
    public bool hasDuplicate(int[] nums) {
        
        // Sort the array
        Array.Sort(nums);

        // Check adjacent elements
        for (int i = 0; i < nums.Length - 1; i++) {
            if (nums[i] == nums[i + 1]) {
                return true;
            }
        }

        return false;
    }
}