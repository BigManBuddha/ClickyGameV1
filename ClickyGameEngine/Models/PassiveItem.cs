using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickyGameEngine.Models
{
    public class PassiveItem : Item
    {
        public double PassiveClicks { get; set; }

        public PassiveItem(double passiveClicks, int id, string name, double cost) : base(id, name, cost)
        {
            PassiveClicks = passiveClicks;
        }
        public override string ToString()
        {
            return string.Format("{0}", this.Name);
        }
    }        
}
