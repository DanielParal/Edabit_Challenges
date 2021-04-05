using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DefaultProject.Tests.OverTimeTest
{
    public class OverTimeTest
    {
        [Theory]
        [InlineData(new[] { 9, 17, 30, 1.5 }, "$240.00")]
        [InlineData(new double[] { 9, 18, 40, 2 }, "$400.00")]
        [InlineData(new[] { 13, 20, 32.5, 2 }, "$325.00")]
        [InlineData(new[] { 9, 13, 25, 1.5 }, "$100.00")]
        [InlineData(new[] { 11.5, 19, 40, 1.8 }, "$364.00")]
        [InlineData(new[] { 10, 17, 30, 1.5 }, "$210.00")]
        [InlineData(new[] { 10.5, 17, 32.25, 1.5 }, "$209.63")]
        [InlineData(new[] { 16, 18, 30, 1.8 }, "$84.00")]
        [InlineData(new[] { 13.25, 15, 30, 1.5 }, "$52.50")]
        [InlineData(new[] { 13, 21, 38.6, 1.8 }, "$432.32")]
        [InlineData(new[] { 18, 20, 32.5, 2 }, "$130.00")]
        public void CalculateOverTimeTest_ResultValues(double[] values, string result)
        {
            string overTimeResult = DefaultProject.OverTime.OvertTime.CalculateOverTime(values);

            Assert.Equal(result, overTimeResult);
        }
    }
}
