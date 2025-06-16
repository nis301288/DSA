public class Solution {
    public double MyPow(double x, int n) {
        //Recursion
if(n==0) {
           return 1;
       }
       long p=n;
       if(p<0) {
           p=-p;
           x=1/x;
       }
       if(p%2==0) {
           return MyPow(x*x,(int)(p/2));
       } else {
           return x * MyPow(x*x,(int)(p/2));
       }
   }
}
/*
x^n
if n is even
myPow(x,n) = myPow(x^2,n/2)
if n is odd
myPow(x,n)=x * myPow(x^2,n/2)
*/
