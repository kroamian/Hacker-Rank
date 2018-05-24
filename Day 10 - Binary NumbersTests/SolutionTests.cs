using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void MainTest()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                using (StringReader sr = new StringReader(string.Format("52{0}",
                    Environment.NewLine)))
                {
                    Console.SetIn(sr);

                    Solution.Main(new string[] { });

                    string expected = string.Format(
                        "Enter your name.{0}Hello, Mark.{0}Type a message.{0}You wrote: Ploeh{0}",
                        Environment.NewLine);
                    Assert.AreEqual<string>(expected, sw.ToString());
                }
            }
        }
    }
}