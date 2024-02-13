using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit_demonstration;
using NUnit.Framework;
using NUnit.Framework.Legacy;


namespace Test_class
{
    public class TriangleTest
    {
        [TestFixture]
        public class TriangleTest2
        {
            [Test]
            //Iqbal Triangle Test
            public void ValidTriangle60()

            {
                int firstAngle = 60;
                int secondAngle = 60;
                int thirdAngle = 60;

                string Expected = "The triangle is valid.";

                string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

                //Assert
                ClassicAssert.AreEqual(Expected, actual);
            }
        }


    }
}
