using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //定义一个类，含有一、二、三个运算符的运算式方法，
    // 每个运算方法包含四种运算符排列方式
  public   class Yunsuan
    {
        public Yunsuan ()
            {
            }
        public  int a;
        public  int b;
        public int c;
        public int d;
        public int e;
        public int result;
        //int iFlag = 1;
        //只含有一个运算符的运算式
        public int   Cal (int  n, int m,int cc)
        {
            int a = n ;
            int b = m;
            int iFlag = 1;

            switch (cc )
            {
                case 0:
                    result = a + b;
                    Console.WriteLine($"{a }+{b}={result }");
                    break;
                case 1:
                    if ((a - b > 0)||(a-b==0))
                    {
                        result = a - b;
                        Console.WriteLine($"{a }-{b}={result }");
                    }
                    else
                    {
                        iFlag = 0;
                    }
                    break;
                case 2:
                    result = a * b;
                    Console.WriteLine($"{a }*{b}={result }");
                    break;
                case 3:
                    if (a >= b && b != 0)
                    {
                        result = a / b;
                        Console.WriteLine($"{a }/{b}={result }");
                    }
                    else
                    {
                        iFlag = 0;
                    }
                    //else
                    //{
                    //    a = a * b; b = a - b;
                    //    Cal(a, b, cc);
                    //}
                    break;
            }
            return iFlag;
        }
        
        public int  Cal(int n, int m, int i, int cc)
        {//含有两个运算符的运算式
            int a = n;
            int b = m;
            int c = i;
            int iFlag = 1;
            switch (cc)
            {
                case 0:
                    if ((a + b - c > 0) || (a + b - c == 0))
                    {
                        result = a + b - c;
                        Console.WriteLine($"{a}+{b }-{c}={result }");
                    }
                    else
                    {
                        iFlag = 0;
                    }
                    break;
                case 1:
                    if ((a + b * c > 0) || (a + b * c == 0))
                    {
                        result = a + b * c;
                        Console.WriteLine($"{a}+{b }*{c}={result }");
                    }
                    else
                    {
                        iFlag = 0;
                    }
                    break;
                case 2:
                    if (c != 0)
                    {
                        result = a + b /c;
                        Console.WriteLine($"{a}+{b }/{c}={result }");
                    }
                    else
                    {
                        iFlag = 0;
                    }
                    break;
                case 3:
                    if (a>(b*c ))
                    {
                        result = a - b * c;
                        Console.WriteLine($"{a}-{b }*{c}={result }");
                    }
                    else
                    {
                        iFlag = 0;
                    }
                    break;
            }
            return iFlag;
        }
        //含有三个运算符的运算式
        public int  Cal(int n, int m, int i, int k, int cc)
        {
            int a = n; int b = m;
            int c = i; int d = k;
            int iFlag = 1;
            switch (cc)
            {
                case 0:
                    if ((a + b) > (c * d))
                    {
                        result = a + b - c * d;
                        Console.WriteLine($"{a}+{b}-{c}*{ d}={ result }");
                    }
                    else
                    {
                        iFlag = 0;
                    }
                    break;
                case 1:
                    if ((a + b) > (c * d))
                    {
                        result = a + b - c * d;
                        Console.WriteLine($"{a}+{b}-{c}*{ d}={ result }");
                    }
                    else
                    {
                        iFlag = 0;
                    }
                    break;
                case 2:
                    if ((b != 0) && (a / b + c > b))

                    {
                        result = a / b + c - d;
                        Console.WriteLine($"{a}/{b}+{c}_{d }={result }");
                    }
                    else
                    {
                        iFlag = 0;
                    }
                    break;
                case 3:
                    if ((c != 0) && (a / b * c > d))
                    {
                        result = a / b * c - d;
                        Console.WriteLine($"{a}/{b}*{c}-{ d}={ result }");
                    }
                    else
                    {
                        iFlag = 0;
                    }
                    break;                  
            }
            return iFlag;
        }
        //含有四个运算符的运算式
        public int  Cal(int n, int m, int i, int k,int j, int cc)
        {
            int a = n;int b = m;
            int c = i;int d = k;
            int e = j;
            int iFlag = 1;
            switch (cc)
            {
                case 0:
                    if ((e != 0) && (c * d / e < (a + b)))
                    {
                        result = a + b - c * d / e;
                        Console.WriteLine($"{a}+{b}-{c}*{d}/{e}={result }");

                    }
                    else
                    {
                        iFlag = 0;
                    }
                    break;
                case 1:
                    if ((b!=0)&&(d*e)<(a/b+c ))
                    {
                        result = a / b + c - d * e;
                        Console.WriteLine($"{a}/{b}+{c}-{d}*{e}={result }");

                    }
                    else
                    {
                        iFlag = 0;
                    }
                    break;
                case 2:
                    if ((c!=0)&&((a*b/c )>e))
                    {
                        result = a * b / c + d - e;
                        Console.WriteLine($"{a}*{b}/{c}+{d}/-{e}={result }");
                    }
                    else
                    {
                        iFlag = 0;
                    }
                    break;
                case 3:
                    if ((e!=0)&&((a+b*c )>(d/e )))
                    {
                        result = a + b * c - d / e;
                        Console.WriteLine($"{a}+{b}*{c}-{d}/{e}={result }");
                    }
                    else
                    {
                        iFlag = 0;
                    }
                    break;
            }
            return iFlag;
        }
    }
}
