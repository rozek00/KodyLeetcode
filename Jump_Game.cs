//You are given an integer array nums. You are initially positioned at the array's first index, and each element in the array represents your maximum jump length at that position.
//Return true if you can reach the last index, or false otherwise.

public class Solution {
    public bool CanJump(int[] nums) 
    {
        int i;
        int maxindex=0;
        if(nums.Length==1)
        {
            return true;
        }
        for(i=0;i<nums.Length;i++)
        {
            if(nums[i]==0)
            {
                if(maxindex==nums.Length-1)
                {
                    return true;
                }
                if(maxindex<=i)
                {
                    return false;
                }
            }
            if(i+nums[i]>maxindex)
            {
                maxindex =i+nums[i];
            }
        }      
        return true;
    }
}
