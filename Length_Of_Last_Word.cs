//Given a string s consisting of words and spaces, return the length of the last word in the string.
//A word is a maximal substring consisting of non-space characters only.

public class Solution {
    public int LengthOfLastWord(string s) 
    {
        int i = 0;
        int j = 0;
        int k=0;
        for(i=s.Length-1;i>=0;i--)
        {
            if(s[i]!=' ')
            {
                break;
            }
            j++;
        }    
        for(i=s.Length-1-j;i>=0;i--)
        {
            if(s[i]==' ')
            {
                break;
            }
            k++;
        } 
        return k;
    }
}
