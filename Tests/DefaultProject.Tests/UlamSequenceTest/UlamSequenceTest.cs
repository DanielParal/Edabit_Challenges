using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DefaultProject.Tests.UlamSequenceTest
{
    public class UlamSequenceTest
    {
		[Theory]
		[InlineData(4, 4)]
		[InlineData(9, 16)]
		[InlineData(38, 180)]
        [InlineData(99, 688)]
        [InlineData(206, 1856)]
        [InlineData(495, 5597)]
        [InlineData(577, 6782)]
        public void Ulam_TestUlamSequence(int input, int result)
        {
			int actualResult = UlamSequence.UlamSequence.Ulam(input);
			Assert.Equal(result, actualResult);
        }
	}
}
