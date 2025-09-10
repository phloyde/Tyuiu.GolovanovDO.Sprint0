using Tyuiu.GolovanovDO.Task2.V0.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        // Вызов класса DataService и метод GetMessage
        // из библиотеки
        Console.WriteLine(DataService.GetMessage("Данила"));


        Console.ReadKey();
    }
}