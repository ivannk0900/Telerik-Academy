using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    public class Worker : Human
    {
        private decimal weekSailary;

        private double workHoursPerDay;

        public decimal WeekSailary
        {
            get
            {
                return this.weekSailary;
            }
            set
            {
                if(value<0)
                {
                    throw new ArgumentException("Week sailary can not be less than 0");
                }
                else
                {
                    this.weekSailary = value;
                }
            }
        }

        public double WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Work hours per day can not be less than 0");
                }
                else
                {
                    this.workHoursPerDay = value;
                }
            }
        }

        public Worker(string fn, string ln,decimal weekSailary,double workHours)
            : base(fn,ln)
        {
            this.WeekSailary = weekSailary;
            this.WorkHoursPerDay = workHours;
        }

        public decimal MoneyPerHour()
        {
            return this.weekSailary / ((decimal)this.workHoursPerDay * 5);
        }

        public override string ToString()
        {
            return FirstName + " " + LastName + " " + MoneyPerHour();
        }

    }
}
