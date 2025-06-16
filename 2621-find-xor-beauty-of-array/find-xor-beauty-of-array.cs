public class Solution {
    public int XorBeauty(int[] nums) {
       //Optimized(XOR) approach(2527. Find Xor-Beauty of Array)
       int n = nums.Length;
       int result = 0;
       for(int i = 0; i<n; i++)
       {
       result = result^nums[i];
       }
       return result; 
    }
}
