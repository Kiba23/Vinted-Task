using DiscountEvaluator;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            EvaluatorMain evaluatorMain = new EvaluatorMain();

            evaluatorMain.RunEvaluator();

            Output.EndProgram();
        }
    }
}
