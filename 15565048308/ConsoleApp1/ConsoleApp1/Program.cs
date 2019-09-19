using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Yunsuan yunsuan = new Yunsuan();
            Random number = new Random();                       
            Console.WriteLine("您需要的题目数量为：");
            int n = Convert.ToInt32(Console.ReadLine());  
            
            for (int i = 0; i < n; i++)
            {
                int numb1 = number.Next(1, 100);
                int numb2 = number.Next(1, 100);
                int numb3 = number.Next(1, 100);
                int numb4 = number.Next(1, 100);
                int numb5 = number.Next(1,100);
                int op = number.Next(0, 4);
                int cc = number.Next(0, 4);
                int Flag = 1;

                switch (op )
                {
                    case 0:
                       Flag = yunsuan.Cal(numb1, numb2, cc);
                        if (Flag ==0)     { i--; }
                        break;
                    case 1:
                        Flag = yunsuan.Cal(numb1, numb2, numb3, cc);
                        if (Flag == 0) { i--; }
                        break;
                    case 2:
                        Flag = yunsuan.Cal(numb1, numb2, numb3, numb4, cc);
                        if (Flag == 0) { i--; }
                        break;
                    case 3:
                        Flag = yunsuan.Cal(numb1 ,numb2 ,numb3 ,numb4 ,numb5 ,cc );
                        if (Flag == 0) { i--; }
                        break; 
                }
            }
            Console.WriteLine("感谢使用，祝您生活愉快哦！");
            Console.ReadKey();
        }
    }
}
