using PR_CRISNER_CARLOS;

namespace SolutionTest

{
    public class Tests
    {
        [TestFixture]
        public class CounterTests
        {
            [Test]
            public void SolutionReturnsExpected()
            {
                int[] A = { 1, 1, 4, 6, 1, 5, 5 };
                int N = 5;
                int[] expected = { 3, 2, 2, 2, 4 };
                Solution solution = new Solution();

                int[] result = solution.solution(N, A);

                Assert.That(result, Is.EqualTo(expected));
            }

            [Test]
            public void TestWithEmptyArray()
            {
                int[] A = new int[0];
                int N = 5;
                int[] expected = new int[] { 0, 0, 0, 0, 0 };
                Solution solution = new Solution();
                int[] result = solution.solution(N, A);
                Assert.AreEqual(expected, result);
            }

        }
    }
}