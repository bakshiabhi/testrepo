using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NBDD.Framework.Testing;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace ClassLibrary7
{
    [TestFixture]

    public class TestAdd

    {
        [Test]
        public void should_add_2_numbers()
        {
            var number1 = 1;
            var number2 = 3;
            var total = number1 + number2;
            Assert.AreEqual(4, total);
        }

        [Test]
        public void multiple_2_num()
        {

            var obj = new Multiplyclass();
            int finalnum = obj.Multiply(3, 3);
            Assert.AreEqual(9, finalnum);



        }

        [Test]
        public void test_2_numbers_add()
        {
            var objet = new Addclass();
            int result = objet.Add(4, 4);
            Assert.AreEqual(8,result);

        }

        [Test]
        public void twenty_two()
        {
            var objt = new SubClass();
            int minus = objt.substract(5, 0);
            Assert.AreEqual(5,minus);
        }

        [Test]
        [TestCase(27,3,9)]

        public void twenty_tssjjs(int fnu1, int fnu2, int fnu3)

        {
            var obt = new DivClass();
            int sump = obt.Divide( fnu1, fnu2);
            Assert.AreEqual(fnu3, sump);



            }
        }
}