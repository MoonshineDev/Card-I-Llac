using CardGameEngine;
using NUnit.Framework;

namespace TddTests
{
    [TestFixture]
    public class CardGameTests
    {
        [Test]
        public void Ctor()
        {
            var sut = new CardGame();
            Assert.IsNotNull(sut);
        }
    }
}
