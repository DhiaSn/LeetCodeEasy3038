namespace LeetCodeEasy3038
{
    public static class Solution
    {
        public static int MaxOperations(int[] nums)
        {
            if(nums.Length < 2) return 0; 
            if(nums.Length == 2) return 1;

            int lastScore = nums[0] + nums[1];
            int tempScore = nums[0] + nums[1];
            int result = 0;
            int[] tempList = nums;
            while(tempScore == lastScore)
            {
                result++;
                int[] newList = new int[tempList.Length - 2];
                if (newList.Length >= 2)
                {
                    int j = 0;
                    for (int i = 2; i < tempList.Length; i++)
                    {
                        newList[j] = tempList[i];
                        j++;
                    }
                    tempScore = newList[0] + newList[1];
                    tempList = newList;
                }
                else
                    break; 
            }

            return result; 
        }
    }
}
