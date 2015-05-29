using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsmProblem
{
    public class GSMCallHistoryTest
    {
        public void CallHistoryTest()
        {


            GSM samsung = new GSM("S6", "Samsung", "Some Owner", 1200, new Battery(), new Display());

            samsung.AddCall(DateTime.Now, 0899123456, 123);
            samsung.AddCall(DateTime.Now.AddHours(2), 0899654321, 99);
            samsung.AddCall(DateTime.Now.AddMinutes(20), 0899876543, 43);

            samsung.ShowHistory();

            Console.WriteLine("call price before removing the longest call");
            Console.WriteLine(samsung.CallPrice(0.37M));
            Console.WriteLine();
            Console.WriteLine("call price after removing the longest call");

            Call callToRemove = samsung.CallHistory[0];
            foreach(var call in samsung.CallHistory)
            {
                if(callToRemove.Duration<call.Duration)
                {
                    callToRemove = call;
                }
            }
            samsung.RemoveCall(callToRemove);

            Console.WriteLine(samsung.CallPrice(0.37M));
            Console.WriteLine();
            samsung.CallHistory.Clear();
            samsung.ShowHistory();
           



        }

    }
}
