using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Utility
    {
        public static double GetValueOfBook(Book vBook)
        {
            return vBook.Price;
        }

        public static double GetValueOfAmulet(Amulet vAmulet)
        {
            double amuletValue = 0;
            if (vAmulet.Quality == Level.low)
            {
                amuletValue = 12.5;
            }
            else if (vAmulet.Quality == Level.medium)
            {
                amuletValue = 20.0;
            }
            else if (vAmulet.Quality == Level.high)
            {
                amuletValue = 27.5;
            }
            return amuletValue;
        }

        public static double GetValueOfCourse(Course vCourse)
        {
            double getHours = vCourse.DurationInMinutes / 60.0;            
            int fullHours = Convert.ToInt32(getHours);
            double finalPrice = 875 * fullHours;            
            return finalPrice;
        }
    }
}
