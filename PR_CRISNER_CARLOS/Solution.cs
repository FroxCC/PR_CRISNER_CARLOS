namespace PR_CRISNER_CARLOS
{
    public class Solution
    {
        public int[] solution(int N, int[] A)
        {
            int[] counters = new int[N];
            int maxCounter = 0;
            int lastMaxCounter = 0;

            for (int i = 0; i < A.Length; i++)
            {
                int operation = A[i];
                if (operation >= 1 && operation <= N)
                {
                    int counter = operation - 1;
                    if (counters[counter] < lastMaxCounter)
                    {
                        counters[counter] = lastMaxCounter;
                    }
                    counters[counter]++;
                    if (counters[counter] > maxCounter)
                    {
                        maxCounter = counters[counter];
                    }
                }
                else if (operation == N + 1)
                {
                    lastMaxCounter = maxCounter;
                }
            }

            for (int i = 0; i < N; i++)
            {
                if (counters[i] < lastMaxCounter)
                {
                    counters[i] = lastMaxCounter;
                }
            }

            return counters;
        }
    }
}