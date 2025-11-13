
using Tyuiu.SimkinOA.Sprint4.Task5.V18.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tyuiu.SimkinOA.Sprint4.Task5.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalcu()
        {
            DataService ds = new DataService();

          
            int[,] mas2 = new int[5, 5] { { 3, 7, -3, 1, 5 },
                                        { 6, -3, 2, 1, 2 },
                                        { 1, 3, 2, -8, 1 },
                                        { 5, 8, 1, 5, 1 },
                                        { -3, 3, 4, 4, 6 } };

            int[,] res = ds.Calculate(mas2);

         
            int[,] wait = new int[5, 5] { { 3, 7, 0, 1, 5 },
                                         { 6, 0, 2, 1, 2 },
                                         { 1, 3, 2, 0, 1 },
                                         { 5, 8, 1, 5, 1 },
                                         { 0, 3, 4, 4, 6 } };

  
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Assert.AreEqual(wait[i, j], res[i, j]);
                }
            }
        }
    }
}