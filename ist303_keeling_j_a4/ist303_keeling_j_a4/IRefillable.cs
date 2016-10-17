using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ist303_keeling_j_a4
{
    interface IRefillable
    {
        float FuelPercentage { get; set; }

        void Refill( int amount );
    }
}
