using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Course : IValuable
    {
        private string name;
        private int durationInMinutes;
        private double courseHourValue = 825.00;
        public double CourseHourValue { get => courseHourValue; set { courseHourValue = value; } }


        public string Name { get => name; set { name = value; } }
        public int DurationInMinutes { get => durationInMinutes; set { durationInMinutes = value; } }

        public double GetValue()
        {           
            double getHours = DurationInMinutes / 60.0;
            double fullHours = Math.Ceiling(getHours);
            double finalPrice = CourseHourValue * fullHours;
            return finalPrice;
        }

        public Course(string name, int duration)
        {
            Name = name;
            DurationInMinutes = duration;
        }
        public Course (string name):
            this (name, 0)
            {
            }
        public override string ToString()
        {
            string v = "Name: " + Name + ", Duration in Minutes: " + DurationInMinutes + ", Pris pr påbegyndt time: " + CourseHourValue;

            return v;
        }
    }
}
