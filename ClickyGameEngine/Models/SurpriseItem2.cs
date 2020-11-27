using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClickyGameEngine.Models
{
    public class SurpriseItem2
    {
        public double OutcomePercentage { get; set; }
        public double Cost { get; set; }

        public SurpriseItem2(double outcomePercentage, double cost)
        {
            
            OutcomePercentage = outcomePercentage;
            Cost = cost;
            
            

        }
    }
}
