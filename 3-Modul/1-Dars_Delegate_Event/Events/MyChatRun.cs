namespace _3_Modul._1_Dars_Delegate_Event.Events
{
    internal class MyChatRun
    {
        Person Jamshid = new() { OwnerName = "Jamshid" };
        Person Ortiq = new() { OwnerName = "Ortiq" };
        Person Elyor = new() { OwnerName = "Elyor" };

        public void StartChat()
        {
            Jamshid.OnSendSms += Ortiq.OnClickGetSms;
            Jamshid.OnSendSms += Elyor.OnClickGetSms;

            Elyor.OnSendSms += Jamshid.OnClickGetSms;
            Elyor.OnSendSms += Ortiq.OnClickGetSms;

            Ortiq.OnSendSms += Jamshid.OnClickGetSms;
            Ortiq.OnSendSms += Elyor.OnClickGetSms;

            while (true)
            {
                Console.WriteLine("Menu Tanlang:\n1.Jamshid\n2.Elyor\n3.Ortiq");
                int selectMenu;
                while (!(int.TryParse(Console.ReadLine(), out selectMenu) &&
                    selectMenu > 0 &&
                    selectMenu < 4))
                {
                    Console.WriteLine("Birodar to`g`ri ma`lumot kiriting:!");
                }

                Console.WriteLine("Menu Tanlang:\n1.Sms yuborish\n" +
                    "2.Yuborilgan SMS lar tarixi\n" +
                    "3.Qabul qilingan SMS lar tarixi");
                int selectMetod;
                while (!(int.TryParse(Console.ReadLine(), out selectMetod) &&
                    selectMenu > 0 &&
                    selectMenu < 4))
                {
                    Console.WriteLine("Birodar to`g`ri ma`lumot kiriting:!");
                }

                switch (selectMenu)
                {
                    case 1:
                        switch (selectMetod)
                        {
                            case 1:
                                Jamshid.SendMessage();
                                break;
                            case 2:
                                Jamshid.ShowAllSentMessages();
                                break;
                            case 3:
                                Jamshid.ShowAllReceivedMessages();
                                break;
                            default:
                                break;
                        }
                        break;
                    case 2:
                        switch (selectMetod)
                        {
                            case 1:
                                Elyor.SendMessage();
                                break;
                            case 2:
                                Elyor.ShowAllSentMessages();
                                break;
                            case 3:
                                Elyor.ShowAllReceivedMessages();
                                break;
                            default:
                                break;
                        }
                        break;
                    case 3:
                        switch (selectMetod)
                        {
                            case 1:
                                Ortiq.SendMessage();
                                break;
                            case 2:
                                Ortiq.ShowAllSentMessages();
                                break;
                            case 3:
                                Ortiq.ShowAllReceivedMessages();
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }

            Jamshid.OnSendSms -= Ortiq.OnClickGetSms;
            Jamshid.OnSendSms -= Elyor.OnClickGetSms;

            Elyor.OnSendSms -= Jamshid.OnClickGetSms;
            Elyor.OnSendSms -= Ortiq.OnClickGetSms;

            Ortiq.OnSendSms -= Jamshid.OnClickGetSms;
            Ortiq.OnSendSms -= Elyor.OnClickGetSms;
        }

    }
}
