using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculMultiple
{
   public class Multiple
    {
        public string Multiple_3(int n) {

            if (n % 3 == 0) {
                return "n est une multiple du 3";
            }
            return "n n'est pas de multiple du 3"; 
        }

        public string Multiple_5(int n)
        {

            if (n % 5 == 0)
            {
                return "n est une multiple du 5";
            }
            return "n n'est pas de multiple du 5";
        }
        public string Multiple_7(int n)
        {

            if (n % 7 == 0)
            {
                return "n est une multiple du 7";
            }
            return "n n'est pas de multiple du 7";
        }
    }
}
