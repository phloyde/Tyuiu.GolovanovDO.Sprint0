using Tyuiu.GolovanovDO.Task2.V0.Lib;

namespace Tyuiu.GolovanovDO.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            // Область создания методов тестирования, методов из библиотеки
            var name = "Данила";
            var res = DataService.GetMessage(name);

            //Вызываем класс Assent и метод AreEqual
            Assert.AreEqual("Привет, Данила", res);
        }
    }
}
