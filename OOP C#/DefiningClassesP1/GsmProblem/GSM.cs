using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsmProblem
{
    public class GSM
    {
        private string model;
        private string manufacturer;
        private string owner;
        private int price;
        private Battery battery;
        private Display display;
        private BatteryType batteryType;
        private static GSM Iphone = new GSM("Iphone", "Apple", "Some name", 1000, new Battery(), new Display());
        private Call call;
        private List<Call> callHistory = new List<Call>();



        public GSM(string model, string manufacturer)
            : this (model,manufacturer,"unknown owner",0000,new Battery("unknown battery model",000,000),new Display(000,000))
        {
            this.model = model;
            this.manufacturer = manufacturer;
        }
        public GSM(string model, string manufacturer, string owner, int price, Battery battery, Display display)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.owner = owner;
            this.price = price;
            this.battery = battery;
            this.display = display;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                this.manufacturer = value;
            }
        }
        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                this.owner = value;
            }
        }
        public int Price
        {
            get
            {
                return this.price;

            }
            set
            {
                this.price = value;
            }
        }

        static public GSM IPhone
        {
            get
            {
                return Iphone;
            }
        }
        public Battery Battery             // property
        {
            get { return this.battery; }
            set { this.battery = value; }
        }
        public Display Display             // property
        {
            get { return this.display; }
            set { this.display = value; }
        }
        public Call Call
        {
            get
            {
                return this.call;
            }
            set
            {
                this.call = value;
            }
        }

        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }

        }

        public void ShowHistory()
        {
            if (callHistory.Count > 0)
            {
                foreach (var call in callHistory)
                {
                    Console.WriteLine("Date And Time {0,20}", call.DateAndTime);
                    Console.WriteLine("Dialed Number {0,20}", call.DialedNum);
                    Console.WriteLine("Duration {0,20}", call.Duration);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("History is empty!");
            }
        }
        public void AddCall(DateTime dateAndTime, ulong dialedNum, double duration)
        {
            this.callHistory.Add(new Call(dateAndTime, dialedNum, duration));
        }
        public void RemoveCall(Call callToRemove)
        {
            if (this.callHistory.Contains(callToRemove))
            {
                this.callHistory.Remove(callToRemove);
            }
            else
            {
                throw new ArgumentException("there is no such call to remove");
            }

        }
        public void ClearCallsHistory()
        {
            this.callHistory.Clear();
        }
        public BatteryType BatteryType
        {
            get
            {
                return this.batteryType;
            }
            set
            {
                this.batteryType = value;
            }
        }

        public decimal CallPrice(decimal costPerMinute)
        {
            decimal total = 0;
            foreach (var call in callHistory)
            {
                total += ((decimal)call.Duration / 60) * costPerMinute;
            }
            return total;
        }
       // public List<Call> RemoveLongestCall()
       //{
       //    Call longestCall = new
       //    foreach(var call in callHistory)
       //    {
       //        if(call.Duration>l)
       //        {
       //            longestDuration = call.Duration;
       //        }

       //    }

       //}


        public override string ToString()
        {
            return String.Format(
            "Manifacturer: {0}\n" +
            "Model: {1}\n" +
            "Price: {2}\n" +
            "Owner: {3}\n" +
            "Battery hours idle: {4}\n" +
            "Battery hours talk: {5}\n" +
            "Battery model: {6}\n" +
            "Battery type: {7}\n" +
            "Display size: {8}\n" +
            "Display colours {9}\n",
            this.Manufacturer, this.Model, this.Price, this.Owner,
            this.Battery.HoursIdle, this.Battery.HoursTalk, this.Battery.Model, this.Battery.Type, this.Display.Size, this.Display.Colours);
        }

    }
}
