using DiscountEvaluator;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            EvaluatorMain evaluatorMain = new EvaluatorMain(15M);

            evaluatorMain.RunEvaluator();

            Output.EndProgram();
        }
    }
}
