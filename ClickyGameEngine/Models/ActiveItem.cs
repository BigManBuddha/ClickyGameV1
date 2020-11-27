using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickyGameEngine.Models
{
    public class ActiveItem : Item
    {
        public int ClickValueIncrease { get; set; }


        public ActiveItem(int clickValueIncrease, int id, string name, double cost) : base(id, name, cost)
        {
            ClickValueIncrease = clickValueIncrease;
        }
        public override string ToString()
        {
            return string.Format("{0}", this.Name);
        }
    }
}
