using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class BouncingBallsTask
    {
        public static int bouncingBall(double h, double bounce, double window)
        {
            if (h > 0 && bounce > 0 && bounce < 1 && window < h)
            {
                int count = 0;

                while (h > window)
                {
                    count++;
                    h *= bounce;
                    if (h > window)
                        count++;
                }

                return count;
            }

            return -1;
        }
    }
}
