using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit3_SpecialDateStore
{
    public class SpecialDateStore
    {
        public enum SpecialDates
        {
            NewMillennium
        }
        public DateTime DateOf(SpecialDates specialDate)
        {
            switch (specialDate)
            {
                case SpecialDates.NewMillennium:
                    return new DateTime(2000,1,1,0,0,0);
                default:
                    throw new ArgumentOutOfRangeException("specialDate");
            }
        }
    }
}
