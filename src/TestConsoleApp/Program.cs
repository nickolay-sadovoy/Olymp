using Task.FactorialSum;
using Tasks.Abstract;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ITaskService testSetvice = new FactorialSumService();
            testSetvice.Run();
        }
    }
}
