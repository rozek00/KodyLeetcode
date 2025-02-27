public class Solution {
    public bool IsSubsequence(string s, string t) 
    {
        if(s.Length==0)
        {
            return true;
        }
        int i;
        int j = 0;
        for(i=0;i<t.Length;i++)
        {
            if(j<s.Length)
            {
                if(s[j]==t[i])
                {
                    j++;
                }
            }
        } 
        return j==s.Length;      
    }
}
