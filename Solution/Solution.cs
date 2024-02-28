namespace Solution;

public static class Solution
{
    public static int RemoveElement(int[] nums, int val)
    {
        var removedCount = 0;
        var indexes = new Queue<int>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == val)
            {
                removedCount++;
                indexes.Enqueue(i);
            }
            else if (indexes.Count > 0)
            {
                nums[indexes.Dequeue()] = nums[i];
                indexes.Enqueue(i);
            }
        }

        return nums.Length - removedCount;
    }
}
