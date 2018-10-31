using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class ValuableRepository
    {
        private List<IValuable> valuables = new List<IValuable>();

        public void AddValuable(IValuable valuable)
        {
            valuables.Add(valuable);
        }
        public IValuable GetValuable(string id)
        {
            IValuable obj = valuables[0];
            valuables.ForEach(x =>
            {
                if(x is Book book)
                {
                    if(book.ItemId == id)
                    {
                        obj = book;
                    }
                }
                else if (x is Amulet amulet)
                {
                    if (amulet.ItemId == id)
                    {
                        obj = amulet;
                    }
                }
                else if (x is Course course)
                {
                    if (course.Name == id)
                    {
                        obj = course;
                    }
                }
            });
            return obj;

        }
        public double GetTotalValue()
        {
            double totalValue = 0;

            foreach (IValuable valuable in valuables)
            {
                if (valuable is Book book)
                {
                    totalValue += book.GetValue();
                }
                else if (valuable is Amulet amulet)
                {
                    totalValue += amulet.GetValue();
                }
                else if (valuable is Course course)
                {
                    totalValue += course.GetValue();
                }

            }
            return totalValue;
        }
    
        public int Count()
        {
            return valuables.Count();
        }
    }
}