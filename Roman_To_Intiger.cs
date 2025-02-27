public class Solution 
{
    public int changevalue(char c)
    {
        if(c == 'M')
        {
            return 1000;
        }
        if(c == 'D')
        {
            return 500; 
        }
        if(c == 'C')
        {
            return 100;
        }
        if(c == 'L')
        {
            return 50;
        }
        if(c == 'X')
        {
            return 10;
        }
        if(c == 'V')
        {
            return 5;
        }
        if(c == 'I')
        {
            return 1;
        }
        return 0;
    }
    
    public int RomanToInt(string s) 
    {
        int i;
        int sum = 0;
        int prev = 0;
        
        for(i = 0; i < s.Length; i++)
        {
            if(changevalue(s[i]) > prev)
            {
                sum -= prev;
                sum += changevalue(s[i]) - prev;
            }
            else
            {
                sum += changevalue(s[i]);
            }
            prev = changevalue(s[i]);
        }
        return sum;
    }
}
