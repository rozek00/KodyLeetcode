//Given two strings s and t, return true if s is a subsequence of t, or false otherwise.
//A subsequence of a string is a new string that is formed from the original string by deleting some (can be none) of the characters without disturbing the relative positions of the remaining characters. 
//(i.e., "ace" is a subsequence of "abcde" while "aec" is not).
    
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
