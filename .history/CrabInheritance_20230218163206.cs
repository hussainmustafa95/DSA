using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSA
{
    public class Crab
    {
        public virtual string PinchClaws()
        {
            return "clap clap";
        }
    }

    public class CoconutCrab : Crab
    {
        public override string PinchClaws()
        {
            return "CLAP CLAP";
        }
    }
}