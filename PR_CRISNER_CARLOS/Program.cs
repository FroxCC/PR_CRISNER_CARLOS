using PR_CRISNER_CARLOS;

Solution solution = new Solution();

int N = 5;
int[] A = { 1, 1, 4, 6, 1, 5, 5 };
int[] counters = solution.solution(N, A);

foreach (int counter in counters)
{
    Console.Write("{0} ", counter);
}