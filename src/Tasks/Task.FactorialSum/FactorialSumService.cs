using Tasks.Abstract;

namespace Task.FactorialSum
{
    public class FactorialSumService : TaskService
    {
        int n = 4;

        //S = 1/1! + 1/2! + ... + 1/k!

        public override void Run()
        {
            SumCalc(n);
        }

        private double SumCalc(int a)
        {
            var numerator = 1;
            var numeratorMember = 1;
            var denominator = 1;

            for(var i = a; i > 1; i--)
            {
                numeratorMember *= i;
                numerator += numeratorMember;
                denominator *= i;
            }

            return numerator / denominator;
        }
    }
}
