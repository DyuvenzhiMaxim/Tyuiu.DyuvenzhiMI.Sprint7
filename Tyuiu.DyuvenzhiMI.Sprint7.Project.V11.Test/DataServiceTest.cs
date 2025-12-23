
using Tyuiu.DyuvenzhiMI.Sprint7.Project.V11.Lib;

namespace Tyuiu.DyuvenzhiMI.Sprint7.Project.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidOfInput()
        {
            DataService ds = new DataService();

            var FIO = "Василий вася васёк";
            var Addres = "Улица бла бла";
            var Tel = "22222222" ;
            var Birth = "ff fff ff";
            var Job = "работа";
            var Exp = "15";
            var Educ = "Высшее";
            var Pay = "15.555";

            bool res = ds.BoolValid(FIO, Addres, Tel, Birth, Job, Exp, Educ, Pay);
            Assert.AreEqual(false, res);
        }
    }
}
