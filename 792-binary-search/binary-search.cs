public class Solution {

    //Binary Search
    public int Search(int[] nums, int target) {
        
int Left=0;
int Right = nums.Length-1;
while(Left<=Right)
{

    int mid = Left+(Right-Left)/2;
    if(nums[mid]==target)
    {

        return mid;
    }
    else if(nums[mid]<target)
    {
        Left = mid+1;
    }
    else
    {

        Right = mid-1;
    }
}
return -1;
    }
}