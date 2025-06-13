public class Solution {
    public int MinCostToMoveChips(int[] position) {
 int odd=0; int even = 0;

//Bit Manipulation
 foreach(var pos in position)
 {

    if(pos%2==0)
    {
even++;

    }
else{
    odd++;
}
 }       
  return Math.Min(even,odd);
    }
}