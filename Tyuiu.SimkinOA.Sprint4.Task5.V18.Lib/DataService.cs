using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.SimkinOA.Sprint4.Task5.V18.Lib
{
    public class DataService : ISprint4Task5V18
    {
        public int[,] Calculate(int[,] matrix)
        {
            var rows = matrix.GetLength(0);
            var cols = matrix.GetLength(1);
            var result = new int[rows, cols];
            Enumerable.Range(0, rows).ToList().ForEach(i =>
                Enumerable.Range(0, cols).ToList().ForEach(j =>
                    result[i, j] = Math.Max(0, matrix[i, j])));
            return result;
        }

    }
}