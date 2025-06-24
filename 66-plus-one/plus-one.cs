public class Solution {
    public int[] PlusOne(int[] digits) {
        
  //Array Problem Statement... Time complexity is O(n) and Space Complexity in worst case is O(n) and best case O(1).
        int n = digits.Length;
         /* n-1 because array is running from right to left*/
        for(int i = n-1; i>=0; i--)
        {
       
       if(digits[i]==9)
       {
       
       digits[i]=0;

       }
       else{

        digits[i]++;
        return digits;
       }

        }
      /* if all are 9 in array then will convert into 0 and create new array and include 1.[9,9,9,9]->[0,0,0,0]->[1,0,0,0,0] */
        int[] result = new int[n+1];
        result[0]=1;
        return result; 
    }
}