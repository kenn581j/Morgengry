using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    /*
    public class Utility
    {
        private static double lowQualityValue = 12.5;
        private static double mediumQualityValue = 20.0;
        private static double highQualityValue = 27.5;
        private static double courseHourValue = 875.00;
        public static double LowQualityValue { get => lowQualityValue; set { lowQualityValue = value; } }
        public static double MediumQualityValue { get => mediumQualityValue; set { mediumQualityValue = value; } }
        public static double HighQualityValue { get => highQualityValue; set { highQualityValue = value; } }
        public static double CourseHourValue { get => courseHourValue; set { courseHourValue = value; } }

        public static double GetValueOfMerchandise(Merchandise merchandise)
        {
            double value = 0;

            if(merchandise is Book book)
            {                
                value = book.Price;
            }
            else if(merchandise is Amulet amulet)
            {                
                if (amulet.Quality == Level.low)
                {
                    value = LowQualityValue;
                }
                else if (amulet.Quality == Level.medium)
                {
                    value = MediumQualityValue;
                }
                else if (amulet.Quality == Level.high)
                {
                    value = HighQualityValue;
                }
            }
            return value;
        }

        public static double GetValueOfCourse(Course vCourse)
        {
            double getHours = vCourse.DurationInMinutes / 60.0;            
            int fullHours = Convert.ToInt32(getHours);
            double finalPrice = CourseHourValue * fullHours;            
            return finalPrice;
        }
    }
    */
}
