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
        private int houseCount { get; set; }


        public Property(int baseRent)
        {
            BaseRent = baseRent;
        }

        public int GetCurrentRent()
        {
            switch (houseCount)
            {
                case 1:
                    return 70;
                case 2:
                    return 200;
                case 3:
                    return 550;
                case 4:
                    return 750;
                default:
                    return BaseRent;
            }
        }

        public void AddHouse()
        {
            houseCount++;
        }
    }
}
