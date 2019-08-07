using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRefrigerator
{
    public class VegetableNotFoundException : Exception
    {
        public VegetableNotFoundException()
        {
            Console.WriteLine("No such vegetable found");
        }
    }
}
