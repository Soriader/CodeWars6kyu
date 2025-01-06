using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6kyu
{
    public class TemporalCrystalTask
    {

        public static int[] SolomonsQuest(int[][] ar)
        {
            int x = 0;
            int y = 0;
            int timeDilation = 0; 

            foreach (int[] step in ar)
            {
                timeDilation += step[0];

                int direction = step[1];

                double distance = step[2];

                double effectiveDistance = distance * Math.Pow(2, timeDilation);

                switch (direction)
                {
                    case 0: 
                        {
                            y += (int)effectiveDistance;
                            break;
                        }
                    case 1:
                        {                        
                            x += (int)effectiveDistance; 
                            break;
                        }
                    case 2:
                        {
                            y -= (int)effectiveDistance; 
                            break;
                        }
                    case 3:
                       { 
                            x -= (int)effectiveDistance; 
                            break;
                       }
                }
            }

            return new int[] { x, y };
        }

    }
}
//https://www.codewars.com/kata/59d7c910f703c460a2000034/train/csharp