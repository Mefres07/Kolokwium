using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void QuickSort2Test()
        {
            List<int> nieposortowane = new List<int>
            {
                1,10,9,7,6,2,3,5,4
            };

            Program.QuickSort2(ref nieposortowane);

            List<int> posortowane = new List<int>
            {
                1,2,3,4,5,6,7,9,10
            };

            Assert.IsTrue(nieposortowane.SequenceEqual(posortowane));

        }
    }
}