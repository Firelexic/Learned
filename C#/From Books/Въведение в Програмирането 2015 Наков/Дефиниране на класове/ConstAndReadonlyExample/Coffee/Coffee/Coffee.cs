using System;
using System.Collections.Generic;
using System.Text;

namespace Coffee
{
    public enum CoffeeSize
    {
        Small = 100,
        Normal = 150,
        Double = 300
    }

    public class Coffee
    {
        public CoffeeSize size;

        public Coffee(CoffeeSize size)
        {
            this.size = size;
        }

        public CoffeeSize Size
        {
            get { return size; }
        }

    }
}
