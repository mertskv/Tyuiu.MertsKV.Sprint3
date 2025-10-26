using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MertsKV.Sprint3.Task3.V24.Lib;
namespace Tyuiu.MertsKV.Sprint3.Task3.V24.Test
{
    [TestClass]
    public sealed class DataServiseTest
    {
        [TestMethod]
        public void CheckReplaceCharInString()
        {
            DataServise ds = new DataServise();

            string str = "ggguuugu";
            char chr = 'g';
            char rhc = '*';
            string res = ds.ReplaceCharInString(str, chr, rhc);
            string wait = "***uuu*u";
            Assert.AreEqual(wait, res);
        }
    }
}
