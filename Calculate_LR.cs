using System;
using System.Collections.Generic;
using System.Text;

namespace Problema_LR
{
    class Calculate_LR:LR
    {
        int n;
        int[] a = new int[100000];
        int[] b = new int[100000];
        int[] c = new int[100000];
        
        int count = 0;
        protected override void GetN()
        {
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                if(a[i]>1000000)
                {
                    break;
                }
            }
        }
        
        protected override void Calculate()
        {

            
            
            b[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                b[i] = Max(a[i], b[i - 1]);
            }
            c[n] = a[n];
            for (int i = n - 1; i >= 1; i--)
            {
                c[i] = Min(a[i], c[i + 1]);
            }
            for (int i = 2; i < n; i++)
            {
                if (b[i] == c[i]) count++;
            }
                
            

        }
        private int Max(int one,int two)
        {
            
            if(one>two)
            {
                return one;
            }
            else
            {
                return two;
            }
                      
        }
        private int Min(int one,int two)
        {
            if(one<two)
            {
                return one;
            }
            else
            {
                return two;
            }
        }
        protected override void Write()
        {
            Console.WriteLine(count);
        }
    }
}
