public class Solution {
    public int[] TwoSum(int[] numbers, int target) 
    {
        int i, j;
        for(i = 0; i < numbers.Length - 1; i++)
        {
            for(j = i + 1; j < numbers.Length; j++)
            {
                if(numbers[i] + numbers[j] == target)
                {
                    return new int[] { i + 1, j + 1 }; 
                }
            }
        }
        return new int[0]; 
    }
}
