using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsmProblem
{
    public class GsmProblem
    {
        static void Main()
        {
            //GSM samsung = new GSM("samsung", "samsung man", "someone", 200, new Battery(), new Display());


            //samsung.Battery.Type = BatteryType.LiIon;


            //Console.WriteLine(samsung.ToString());


            //GSMTest testing = new GSMTest();
            //testing.GSMTesting();

            //var historyTester = new GSMCallHistoryTest();
            //historyTester.CallHistoryTest();


            GSM myg = new GSM("lg", "lg man");
            Console.WriteLine(myg.Battery.Model);


        }
    }
}
