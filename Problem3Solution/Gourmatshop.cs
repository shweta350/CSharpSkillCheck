using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
    public abstract class GourmetShop
    {
        public abstract double PayPerPiece(int quantity);
        public abstract double PayPerWeight(int weight);

    }
}
