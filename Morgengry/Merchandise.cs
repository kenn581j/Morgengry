﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public abstract class Merchandise : IValuable
    {
        public string ItemId
        {
            get;
            set;
        }

        public abstract double GetValue();

        public override string ToString()
        {
            string v = "ItemId: " + ItemId;

            return v;
        }

    }
}
