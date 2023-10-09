using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RasterShapesDraw
{
    internal class LessThanZeroException :Exception
    {
        public LessThanZeroException():base("Numbers cannot be negative or zero!")
        {

        }
    }
}
