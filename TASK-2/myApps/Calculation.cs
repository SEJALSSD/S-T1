using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myApps 
{
    public class Calculation

    {
        public static int answer ;

        public int SI(int p,int q,int r)
        {
            
            return p*q*r;
        }

        public int Di(int a , int b)
        {
            answer = -9999;

            if (b == 0)
            {
                Console.WriteLine("Warning : The second number could not be 0");
              
                return answer;
            }
            else
            {
                answer = a / b;
                return answer;
            }
        }
         
    }
}
