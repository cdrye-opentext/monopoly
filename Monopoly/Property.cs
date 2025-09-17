using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class Property
    {
        private int BaseRent {  get; set; }
        private int currentRent { get; set; }


        public Property(int baseRent)
        {
            BaseRent = baseRent;
            currentRent = baseRent;
        }

        public int GetCurrnentRent()
        {
            return currentRent;
        }

    }
}
