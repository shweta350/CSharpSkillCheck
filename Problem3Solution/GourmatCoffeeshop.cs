using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace ProblemThree_CompleteSolution_BL
    {
        public class GourmatCoffeeShop : GourmetShop, ITaxCompute
        {
            public Dictionary<int, double> d = new Dictionary<int, double>();
            public int itemno;
            public string itemname;
            public double pp;
            public double pw;

            public GourmatCoffeeShop(int a, string b, Dictionary<int, double> c)
            {
                itemno = a;
                itemname = b;
                foreach (KeyValuePair<int, double> items in c)
                {
                    d.Add(items.Key, items.Value);
                }
            }
            public override double PayPerPiece(int quantity)
            {

                pp = quantity * d.ElementAt(itemno).Value;
                return pp;


            }

            public override double PayPerWeight(int weight)
            {
                return weight * d.ElementAt(itemno).Value;
            }
            public double TaxOnTotalBill()
            {
                return 0.2 * pp;
            }
        }
    }


}
