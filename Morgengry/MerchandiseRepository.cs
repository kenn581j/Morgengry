using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace Morgengry
{
    public class MerchandiseRepository
    {
        private List<Merchandise> merchandises = new List<Merchandise>();
        public void AddMerchandise(Merchandise merchandise)
        {
            merchandises.Add(merchandise);
        }
        public Merchandise GetMerchandise(string itemId)
        {
            return merchandises.Find(x => x.ItemId == itemId);
        }
        public double GetTotalValue()
        {
            double totalValue = 0;           

            foreach (Merchandise merchandise in merchandises)
            {
                if(merchandise is Book)
                {
                    totalValue += Utility.GetValueOfMerchandise(merchandise);
                }
                else if(merchandise is Amulet)
                {
                    totalValue += Utility.GetValueOfMerchandise(merchandise);
                }
                
            }
            return totalValue;
        }
    }
}
*/