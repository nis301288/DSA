public class Solution {
    public int SingleNumber(int[] nums) {
        
        //Bitwise(XOR) used
        int result=0;
        foreach(int num in nums)
        {
            result ^=num;
        }

        return result;
    }
}