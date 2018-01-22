using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cats
{
    class CATSCOUT
    {
        private static int instances = 0;


        public CAT()
        {
            instances++;
        }
        
        public static int CatCount()
        {
            return instances;
        }



    }
}
