//Given a non-negative integer x, return the square root of x rounded down to the nearest integer. The returned integer should be non-negative as well.
//You must not use any built-in exponent function or operator.
public class Solution {
    public int MySqrt(int x) 
    {
        long i=0;
        long val = 0;
        if(x==0)
        {
            return 0;
        }
        while(true)
        {
            val = i*i;
            if(val>x)
            {
                break;
            }
            i++;
        }
        int result = (int)val - 1;
        return result;
    }
}
