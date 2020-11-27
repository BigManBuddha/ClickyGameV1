using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ClickyGameEngine.Models
{
    public class SurpriseItem1 
    {
        public double OutcomeAmount { get; set; }
        public double Cost { get; set; }

        public SurpriseItem1(double outcomeAmount, double cost) 
        {
            
            OutcomeAmount = outcomeAmount;
            Cost = cost;
        }
    }

}
