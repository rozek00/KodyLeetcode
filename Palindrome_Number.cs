//Given an integer x, return true if x is a palindrome, and false otherwise.
public class Solution {
    public bool IsPalindrome(int x) 
    {
        int i=0;
        string name = x.ToString();
        int j = name.Length-1;
        while(i<j)
        {
            if(name[i]!=name[j])
            {
                return false;
            }
            i++;
            j--;
        }
        return true;
    }
}
