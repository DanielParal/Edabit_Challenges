using System;
using System.Collections.Generic;
using System.Text;

namespace DefaultProject.UlamSequence
{
    public class UlamSequence
    {
        public static int Ulam(int n)
        {
            List<int> currentSequence = new List<int>();

            currentSequence.Add(1);
            currentSequence.Add(2);

            if (n == 1 || n == 2)
                return n;

            int nextNumber = 3;
            int count = 0;
            while (currentSequence.Count < n)
            {
                for (int i = 0; i <= currentSequence.Count; i++)
                {
                    for (int j = i + 1; j < currentSequence.Count; j++)
                    {
                        if (i == j)
                            continue;

                        if (currentSequence[i] + currentSequence[j] == nextNumber)
                            count++;

                        if (count > 1)
                            break;
                    }

                    if (count > 1)
                        break;
                }

                if (count == 1)
                    currentSequence.Add(nextNumber);

                nextNumber++;
                count = 0;
            }

            return currentSequence[n-1];
        }
    }
}
