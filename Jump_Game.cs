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
