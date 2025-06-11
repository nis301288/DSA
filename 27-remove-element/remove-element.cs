public class Solution {
    public int RemoveElement(int[] nums, int val) {
//Nishant Sharma.
     int j=0;

     for(int i=0; i<nums.Length; i++)
     {
      
      if(nums[i]==val)
      {
      
      nums[i]++;

      }
      else
      {

         nums[j++]=nums[i];
      }
     } 
     return j;  
    }
}