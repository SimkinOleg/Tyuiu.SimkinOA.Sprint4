using Tyuiu.SimkinOA.Sprint4.Task6.V11.Lib;
namespace Tyuiu.SimkinOA.Sprint4.Task6.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Симкин О.А. | РППб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Операции сравнения                                                      *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Симкин Олег Андреевич | РППб-25-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");

            Console.WriteLine("*Дан строковый массив данных [\"Кошка\", \"Собака\", \"Слон\", \"          ");
            Console.WriteLine("Жираф\", \"Бегемот\", \"Игуана\", \"Ягуар\"] используя                     ");
            Console.WriteLine("класс Array подсчитайте количество элементов, длина которых равна 5.*      ");
                                   

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            string[] myarray = { "Кошка", "Собака", "Слон", "Жираф", "Бегемот", "Игуана", "Ягуар" };
            var result = ds.Calculate(myarray);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}