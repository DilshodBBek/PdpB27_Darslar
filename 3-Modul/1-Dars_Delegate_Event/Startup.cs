using _3_Modul._1_Dars_Delegate_Event.Events;
using _3_Modul._1_Dars_Delegate_Event.Mafia;

namespace _3_Modul._1_Dars_Delegate_Event
{
    internal class Startup
    {
        public static void Start()
        {
            //DelegateExamples.Start();
            //DelegateExample2.Run();
            //DelegateExample3.Run();
            //AnonymousFunctionExample.Run();
            //LambdaExpressionExample.Run();
            //FunctionExample.Run();
            //ActionExample.Run();
            //PredicateExample.Run();
            StartMafia.Run();
            MyChatRun myChatRun = new();
            myChatRun.StartChat();
            Subscriber KosmikStansiyaAppollon = new();//oy
            Subscriber KosmikStansiya1 = new();//oy
            Subscriber KosmikStansiya2 = new();//oy
            EventPublisher Yer = new() { Country = "O`zbekiston" };//yer


            Yer.OnClickSendSms += KosmikStansiyaAppollon.OnClickGetSms;
            Yer.OnClickSendSms += KosmikStansiya1.OnClickGetSms;
            Yer.OnClickSendSms += KosmikStansiya2.OnClickGetSms;


            Yer.SendSmsMessage();

            KosmikStansiyaAppollon.ShowAllMessages();

            Yer.OnClickSendSms -= KosmikStansiyaAppollon.OnClickGetSms;
            Yer.OnClickSendSms -= KosmikStansiya1.OnClickGetSms;
            Yer.OnClickSendSms -= KosmikStansiya2.OnClickGetSms;

            //do
            //{
            //    Console.Write("Sayyoralar ari chatga xush kelibsiz:\n1.Oy\n2.Yer\nTanlang:");
            //    string select = Console.ReadLine() ?? "Tanlanmadi!";
            //    switch (select)
            //    {
            //        case "1":
            //            Console.WriteLine("Oy sayyorasi tanlandi.\n1.Yerga xabar yuborish\n" +
            //            "2.Avval kelgan barcha xabarlarni ko`rish");
            //            switch (Console.ReadLine())
            //            {
            //                case "1": KosmikStansiyaAppollon.ShowAllMessages(); break;
            //                case "2": KosmikStansiyaAppollon.SendMessage(); break;
            //                default:
            //                    Console.WriteLine("Xato tanlandi!"); break;
            //            }
            //            break;
            //        case "2":
            //            Console.WriteLine("Oy sayyorasi tanlandi.\n1.Yerga xabar yuborish\n" +
            //           "2.Avval kelgan barcha xabarlarni ko`rish");
            //            switch (Console.ReadLine())
            //            {
            //                case "1": Yer.ShowAllMessages(); break;
            //                case "2": Yer.SendSmsMessage(); break;
            //                default:
            //                    Console.WriteLine("Xato tanlandi!"); break;
            //            }
            //            break;
            //        default:
            //            break;
            //    }
            //} while (true);
        }
    }
}


