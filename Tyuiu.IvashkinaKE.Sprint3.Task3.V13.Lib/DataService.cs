using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.IvashkinaKE.Sprint3.Task3.V13.Lib
{
    public class DataService : ISprint3Task3V13
    {
        public int ConvertStringToInt(string value)
        {
            string str = "";
            foreach (char chr in value)
            {
                if (Char.IsDigit(chr))
                {
                    str += chr;
                }

            }
            return Convert.ToInt32(str);
        }


    }
}
