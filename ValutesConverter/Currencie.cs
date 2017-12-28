using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValutesConverter
{
        class Currencie
        {
                private string name;

                private Double rate;

                public string Name
                {
                        get { return name; }
                        set { name = value; }
                }

                public Double Rate
                {
                        get { return rate; }
                        set { rate = value; }
                }

                public Currencie(string a, Double b)
                {
                        name = a;
                        rate = b;
                }

                public override string ToString()
                {
                        return this.Name;
                }
        }
}
