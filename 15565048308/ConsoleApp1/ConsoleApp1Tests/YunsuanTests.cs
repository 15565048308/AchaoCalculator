using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class YunsuanTests
    {
        Yunsuan YS = new Yunsuan();


        [TestMethod()]
        public void YunsuanTest()
        {

        }

        [TestMethod()]
        public void CalTest()
        {
            int[] n = {32,1,63,5,1,32,13,1};
            int[] m = {15,65,46,32,5,41,6,4 };
            int cc = 0;
            for (int i = 0;i<n.Length;i++) { YS.Cal(n[i],m[i],cc); }
          

        }

        [TestMethod()]
        public void CalTest1()
        {
            int[] n = { 32, 1, 63, 5, 1, 32, 13, 1 };
            int[] m = { 15, 65, 46, 32, 5, 41, 6, 4 };
            int[] k = { 87,1,6,57,64,67,64,51};
            int cc = 0;
            for (int i = 0; i < n.Length; i++)
            {
                YS.Cal(n[i],m[i],k[i] ,cc);
            }
           

        }

        [TestMethod()]
        public void CalTest2()
        {
            int[] n = { 32, 1, 63, 5, 1, 32, 13, 1 };
            int[] m = { 15, 65, 46, 32, 5, 41, 6, 4 };
            int[] k = { 87, 1, 6, 57, 64, 67, 64, 51 };
            int[] j = { 4,65,85,68,42,74,97,12};
            int cc = 0;
            for (int i = 0; i < n.Length; i++)
            {
                YS.Cal(n[i], m[i], k[i],j[i], cc);
            }
        }

        [TestMethod()]
        public void CalTest3()
        {
            int[] n = { 32, 1, 63, 5, 1, 32, 13, 1 };
            int[] m = { 15, 65, 46, 32, 5, 41, 6, 4 };
            int[] k = { 87, 1, 6, 57, 64, 67, 64, 51 };
            int[] j = { 4, 65, 85, 68, 42, 74, 97, 12 };
            int[] h = { 54,84,65,16,19,78,21,53};
            int cc = 0;
            for (int i = 0; i < n.Length; i++)
            {
                YS.Cal(n[i], m[i], k[i], j[i], h[i],cc);
            }
        }
    }
}