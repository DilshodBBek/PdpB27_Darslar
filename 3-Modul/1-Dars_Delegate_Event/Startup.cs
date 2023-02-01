using _3_Modul._1_Dars_Delegate_Event.Delegates;

namespace _3_Modul._1_Dars_Delegate_Event
{
    internal class Startup
    {
        public static void Start()
        {
            DelegateExamples.Start();
            DelegateExample2.Run();
            DelegateExample3.Run();
            AnonymousFunctionExample.Run();
            LambdaExpressionExample.Run();
            FunctionExample.Run();
            ActionExample.Run();
            PredicateExample.Run();
        }
    }
}


