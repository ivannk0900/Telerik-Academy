using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsmProblem
{
   public class Battery
    {
        private string model;
        private int hoursTalk;
        private int hoursIdle;
        private BatteryType type;
       

        public Battery()
        {
            
        }
        public Battery(string model,int hoursTalk,int hoursIdle)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
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
        public int HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set 
            {
                this.hoursIdle = value;
            }
        }
        public int HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                this.hoursTalk = value;
            }
        }
       public BatteryType Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }
       
       
    }
}
