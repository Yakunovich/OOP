using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    static class M 
    {
        public static int FirstNumb(this Matrix m,int j)
        {
            return m[0, j];
        }
        public static void NullM(this Matrix m)
        {
            for(int i=0;i<m.H;i++)
            {
                for(int j=0;j<m.W;j++)
                {
                    if (m[i, j] < 0) m[i, j] = 0;
                   
                }
            }
        }
    }
}
