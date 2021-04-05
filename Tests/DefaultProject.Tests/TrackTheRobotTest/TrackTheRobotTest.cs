using DefaultProject.TrackTheRobot;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DefaultProject.Tests.TrackTheRobotTest
{
    public class TrackTheRobotTest
    {
        [Theory]
        [InlineData("..<.<.", new int[] { 1, 1 })]
        [InlineData("....................................................................................................", new int[] { 100, 0 })]
        [InlineData("<>>>><><<<><>>>><><<<><>>><>", new int[] { 0, 0 })]
        [InlineData(".<..<...<....<.....<......", new int[] { 3, 4 })]
        [InlineData(">>..", new int[] { -2, 0 })]
        [InlineData("..<<..>>..<<..>>..", new int[] { 2, 0 })]
        public void TrackRobot(string steps, int[] result)
        {
            int[] actualResult = TrackTheRobot.TrackTheRobot.TrackRobot(steps);
            Assert.Equal(result, actualResult);
        }

        [Theory]
        [InlineData(EDirection.E, '>', EDirection.S)]
        [InlineData(EDirection.S, '<', EDirection.E)]
        [InlineData(EDirection.E, '<', EDirection.N)]
        [InlineData(EDirection.N, '>', EDirection.E)]
        public void ChangeDirection_ShouldClockwiseIfBiggerSign_ShouldAnticlockwiseIfSmallerSign(EDirection direction, char sign, EDirection result)
        {
            EDirection actualDirection = TrackTheRobot.TrackTheRobot.ChangeDirection(direction, sign);
            Assert.Equal(result, actualDirection);
        }

        [Theory]
        [InlineData(new int[] { 0, 0 }, EDirection.E, new int[] { 1, 0 })]
        [InlineData(new int[] { 0, 0 }, EDirection.W, new int[] { -1, 0 })]
        [InlineData(new int[] { 0, 0 }, EDirection.N, new int[] { 0, 1 })]
        [InlineData(new int[] { 0, 0 }, EDirection.S, new int[] { 0, -1 })]
        [InlineData(new int[] { 1, 1 }, EDirection.E, new int[] { 2, 1 })]
        [InlineData(new int[] { 1, 1 }, EDirection.W, new int[] { 0, 1 })]
        [InlineData(new int[] { 1, 1 }, EDirection.N, new int[] { 1, 2 })]
        [InlineData(new int[] { 1, 1 }, EDirection.S, new int[] { 1, 0 })]
        public void Move(int[] currentPosition, EDirection direction, int[] result)
        {
            int[] actualPosition = TrackTheRobot.TrackTheRobot.Move(currentPosition, direction);
            Assert.Equal(result, actualPosition);
        }
    }
}
