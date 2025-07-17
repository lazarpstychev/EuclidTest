using Program = Euclid.Program;

namespace EuclidTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void CorrectResult()
        {
            int a = 12, b = 30;
            int result = Program.NOD(a, b);
            Assert.That(result, Is.EqualTo(6));
        }
        [Test]
        public void NegativeDataResult()
        {
            int a =-12, b =30;
            int result = Program.NOD(a, b);
            Assert.AreEqual(result, 6);
        }


    }
}