public class Solution {
    public double MyPow(double x, int n) 
    {
       if(x==0)
       {
        return 1;
       }
       if(n==1)
       {
        return x;
       } 
       if(n<0)
       {
        x=1/x;
        n*=-1;
       }
       return x*MyPow(x,n-1);
    }
}
