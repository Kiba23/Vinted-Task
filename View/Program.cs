using DiscountEvaluator;
using System.Globalization;
using System.Threading;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setting up dots instead of commas in numeric values
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");


            EvaluatorMain evaluatorMain = new EvaluatorMain();

            evaluatorMain.RunEvaluator();

            Output.EndProgram();
        }
    }
}
