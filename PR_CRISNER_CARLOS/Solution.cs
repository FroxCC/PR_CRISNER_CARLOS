namespace PR_CRISNER_CARLOS
{
    public class Solution
    {
        public int[] solution(int N, int[] A)
        {
            if (N < 1 || N > 100000)
            {
                throw new ArgumentException("N must be between 1 and 100,000");
            }

            if (A.Length < 1 || A.Length > 100000)
            {
                throw new ArgumentException("M must be between 1 and 100,000");
            }

            int[] counters = new int[N];
            int maxCounter = 0;
            int lastMaxCounter = 0;

            foreach (int operation in A)
            {
                if (operation >= 1 && operation <= N)
                {
                    int counter = operation - 1;
                    counters[counter] = Math.Max(counters[counter], lastMaxCounter) + 1;
                    maxCounter = Math.Max(maxCounter, counters[counter]);
                }
                else if (operation == N + 1)
                {
                    lastMaxCounter = maxCounter;
                }
            }

            for (int i = 0; i < N; i++)
            {
                counters[i] = Math.Max(counters[i], lastMaxCounter);
            }

            return counters;
        }
    }
}