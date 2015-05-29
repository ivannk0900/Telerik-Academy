using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsmProblem
{
    public class GSMTest
    {

        public void GSMTesting()
        {


            const int numOfPhones = 5;
            GSM[] GSMArray = new GSM[numOfPhones];

            for (int i = 0; i < numOfPhones; i++)
            {
                string currentModel = "Model " + i.ToString();
                string currentOwner = "Owner " + i.ToString();
                string currentManufacturer = "Manufacturer " + i.ToString();
                int currentPrice = 100 * i;
                Battery currentBattery = new Battery();
                Display currentDisplay = new Display();

                GSMArray[i] = new GSM(currentModel,currentManufacturer,currentOwner,currentPrice,currentBattery,currentDisplay);
            }

            foreach (var gsm in GSMArray)
            {
                Console.WriteLine(gsm.ToString());
                Console.WriteLine();
            }
        }


    }
}
