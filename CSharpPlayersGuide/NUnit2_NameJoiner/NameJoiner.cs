using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit2_NameJoiner
{
    public class NameJoiner
    {
        public string Join(string firstName, string lastName)
        {
            return $"{firstName} {lastName}";
        }
    }
}
