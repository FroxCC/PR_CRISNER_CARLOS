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

            public void TestExceptionWhenNIsOutOfRange()
            {
                int N = 100001;
                int[] A = new int[] { 1, 2, 3 };
                var expectedMessage = "N must be between 1 and 100,000";
                Solution solution = new Solution();

                var ex = Assert.Throws<ArgumentException>(() => solution.solution(N, A));
                Assert.That(ex.Message, Is.EqualTo(expectedMessage));
            }

            [Test]
            public void TestExceptionWhenMIsOutOfRange()
            {
                int N = 10;
                int[] A = new int[100001]; // A is too large
                var expectedMessage = "M must be between 1 and 100,000";
                Solution solution = new Solution();

                var ex = Assert.Throws<ArgumentException>(() => solution.solution(N, A));
                Assert.That(ex.Message, Is.EqualTo(expectedMessage));
            }



        }
    }
}