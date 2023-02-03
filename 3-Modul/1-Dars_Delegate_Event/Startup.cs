using _3_Modul._1_Dars_Delegate_Event.Events;

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

            Subscriber subscriber = new();//oy
            EventPublisher eventPublisher = new(); //yer
            eventPublisher.OnClickSendSms += subscriber.OnClickSendSms;
            eventPublisher.SendSmsMessage();
            subscriber.ShowAllMessages();
            
            
            do
            {
                Console.Write("Sayyoralar ari chatga xush kelibsiz:\n1.Oy\n2.Yer\nTanlang:");
                string select = Console.ReadLine() ?? "Tanlanmadi!";
                switch (select)
                {
                    case "1":
                        Console.WriteLine("Oy sayyorasi tanlandi.\n1.Yerga xabar yuborish\n" +
                        "2.Avval kelgan barcha xabarlarni ko`rish");
                        switch (Console.ReadLine())
                        {
                            case "1": subscriber.ShowAllMessages(); break;
                            case "2": subscriber.SendMessage(); break;
                            default:
                                Console.WriteLine("Xato tanlandi!"); break;
                        }
                        break;
                    case "2":
                        Console.WriteLine("Oy sayyorasi tanlandi.\n1.Yerga xabar yuborish\n" +
                       "2.Avval kelgan barcha xabarlarni ko`rish");
                        switch (Console.ReadLine())
                        {
                            case "1": eventPublisher.ShowAllMessages(); break;
                            case "2": eventPublisher.SendSmsMessage(); break;
                            default:
                                Console.WriteLine("Xato tanlandi!"); break;
                        }
                        break;
                    default:
                        break;
                }
            } while (true);
        }
    }
}


