using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    public static class Parameter
    {
        private static int nbMaxActivities = 10;
        private  enum libEvaluations {R = 'R', S = 'S', T = 'T'};

        public static int getNbMax ()
        {
            return nbMaxActivities;
        }
    }
}
