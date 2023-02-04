using _3_Modul._1_Dars_Delegate_Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.AnonymVariable
{
    internal class AnonymExamples
    {
        public static void Run()
        {

            try
            {
                var myvariable = new[] { new { Age = 5, Name = "dfgdfg" }, new { Age = 220, Name = "dsgfg" } };

               // Console.WriteLine(myvariable[7]);
                new MyException(DateTime.Now, "Dilshod");
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message+" \nBu Exception blogi");
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("StackTrace: "+e.StackTrace);
                Console.WriteLine("Data: "+e.Data);
                Console.WriteLine("HelpLink " + e.HelpLink);
                Console.WriteLine("InnerException " + e.InnerException);
                Console.WriteLine("HResult "+e.HResult);
                Console.WriteLine("Source; "+e.Source);
                Console.WriteLine("TargetSite " + e.TargetSite);
            }
            catch(MyException e)
            {
                Console.WriteLine(e.Owner);
                Console.WriteLine(e.CurrentDate);
            }
            finally
            {
                Console.WriteLine("Bu final!");
            }
        }
    }

    class MyException : Exception
    {
        public DateTime CurrentDate { get; set; }
        public string Owner { get; set; }

        public MyException(DateTime currentDate, string owner)
        {
            CurrentDate = currentDate;
            Owner = owner;
        }
        public MyException()
        {

        }
    }
}
