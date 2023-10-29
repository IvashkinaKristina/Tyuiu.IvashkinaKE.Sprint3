using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.IvashkinaKE.Sprint3.Task6.V16.Lib
{
    public class DataService : ISprint3Task6V16
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            
            int sum = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                int res = 0;

                for (int d = 1; d <= x; d++)
                {
                    if (x % d == 0)
                    {
                        res++;
                    }
                }

                sum += res;
            }

            return sum;
;
        }
    }
}
