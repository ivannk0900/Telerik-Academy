using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsmProblem
{
    public class Call
    {
       private DateTime dateAndTime;
       private ulong dialedNum;
       private double duration;

      
       public Call(DateTime dateAndTime,ulong dialedNum, double duration)
       {
           this.dialedNum = dialedNum;
           this.duration = duration;
           this.dateAndTime = dateAndTime;
       }

       public ulong DialedNum 
       {
           get
           {
               return this.dialedNum;
           }
           set
           {    
               string check = value.ToString();

               if(check.Length!=10)
               {
                   throw new ArgumentException("The number should be 10 digits");
               }
               else
               {
                   this.dialedNum=value;
               }
           }
       }
        public double Duration
       {
            get
           {
               return this.duration;
           }
            set
           {
               this.duration = value;
           }
       }

        public DateTime DateAndTime
        {
            get
            {
                return this.dateAndTime;
            }
            set
            {
                this.dateAndTime = value;
            }
        }


    }
}
