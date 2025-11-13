using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.SimkinOA.Sprint4.Task6.V11.Lib
{
    public class DataService : ISprint4Task6V11
    {
        public int Calculate(string[] array)
        {
            int count = 0;
            
            for(int i = 0; i < array.Length; i++) 
            {
                if (array[i].Length ==5)
                {
                    count++;
                }
            }
            return count;
        }

    }
}
