using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class AmuletRepository
    {
        private List<Amulet> amulets = new List<Amulet>();
        public void AddAmulet (Amulet amulet)
        {
            amulets.Add(amulet);
        }
        public Amulet GetAmulet(string itemId)
        {
            return amulets.Find(x => x.ItemId == itemId);
        }
        public double GetTotalValue()
        {
            double totalValue = 0;
            foreach (Amulet v in amulets)
            {
                totalValue += Utility.GetValueOfAmulet(v);
            }
            return totalValue;
        }
    }
}
