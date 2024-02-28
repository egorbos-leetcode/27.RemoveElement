namespace Solution.Tests;

public class UnitTest
{
    [Theory]
    [InlineData(new[] { 3, 2, 2, 3 }, 3, new[] { 2, 2 })]
    [InlineData(new[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, new[] { 0, 1, 3, 0, 4 })]
    public void Test(int[] nums, int val, int[] expected)
    {
        var count = Solution.RemoveElement(nums, val);

        Assert.Equal(expected.Length, count);
        for (var i = 0; i < expected.Length; i++)
        {
            Assert.Equal(expected[i], nums[i]);
        }
    }
}