using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public enum Level
    {
        low,
        medium,
        high
    }
    public class Amulet : Merchandise
    {
        private double lowQualityValue = 12.5;
        private double mediumQualityValue = 20.0;
        private double highQualityValue = 27.5;
        private string design;

        public Level Quality { get; set; } 
        public string Design{ get => design; set { design = value; } } 
        public double LowQualityValue { get => lowQualityValue; set { lowQualityValue = value; } }
        public double MediumQualityValue { get => mediumQualityValue; set { mediumQualityValue = value; } }
        public double HighQualityValue { get => highQualityValue; set { highQualityValue = value; } }
        
        public Amulet(string itemId, Level quality, string design)
        {
            ItemId = itemId;
            Quality = quality;
            Design = design;
        }
        public Amulet(string itemId, Level quality) :
            this(itemId, quality, "")
        {
        }
        public Amulet(string itemId) :
             this(itemId, Level.medium)
        {
        }
        public override double GetValue()
        {
            double value = 0;
            if(Quality == Level.low)
            {
                value = LowQualityValue;
            }
            else if (Quality == Level.medium)
            {
                value = MediumQualityValue;
            }
            else if (Quality == Level.high)
            {
                value = HighQualityValue;
            }
            return value;
        }
        public override string ToString()
        {
            string v = "ItemId: " + ItemId + ", " + "Quality: " + Quality + ", " + "Design: " + Design;
                
            return v;
        }
    }
}
