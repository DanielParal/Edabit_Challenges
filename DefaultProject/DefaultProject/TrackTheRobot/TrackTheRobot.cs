using System;
using System.Collections.Generic;
using System.Text;

namespace DefaultProject.TrackTheRobot
{
    public enum EDirection
    {
        // east
        E = 0,
        // south
        S = 1,
        // west
        W = 2,
        // north
        N = 3
    }

    public class TrackTheRobot
    {
        public static int[] TrackRobot(string steps)
        {
            int[] currentDirection = new int[] { 0, 0 };
            EDirection direction = EDirection.E;

            foreach (char step in steps)
            {
                // if step not ><. -> skip
                // if step . -> move
                // if step >< -> change direction
                if (step == '.')
                    currentDirection = Move(currentDirection, direction);

                if (step == '>' || step == '<')
                    direction = ChangeDirection(direction, step);
            }

            return currentDirection;
        }

        public static EDirection ChangeDirection(EDirection currentDirection, char sign)
        {
            int direction = (int)currentDirection;
            if (sign == '>')
                direction += 1;

            if (sign == '<')
                direction += -1;

            if (direction < 0)
                return EDirection.N;

            if (direction > 3)
                return EDirection.E;

            return (EDirection)direction;
        }

        public static int[] Move(int[] currentPosition, EDirection direction)
        {
            switch (direction)
            {
                case EDirection.E:
                    return new int[2] { currentPosition[0] + 1, currentPosition[1] };
                case EDirection.S:
                    return new int[2] { currentPosition[0], currentPosition[1] - 1 };
                case EDirection.W:
                    return new int[2] { currentPosition[0] - 1, currentPosition[1] };
                default:
                    // north
                    return new int[2] { currentPosition[0], currentPosition[1] + 1 };
            }
        }
    }
}
