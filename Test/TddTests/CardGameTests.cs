using System;
using CardGameEngine;
using Moq;
using NUnit.Framework;

namespace TddTests
{
    [TestFixture]
    public class CardGameTests
    {
        private Mock<IConsole> _consoleMock;
        private CardGame _sut;

        [SetUp]
        public void Setup()
        {
            _consoleMock = new Mock<IConsole>();
            _sut = new CardGame(_consoleMock.Object);
        }

        [Test]
        public void Ctor_NoConsole()
        {
            CardGame sut = null;
            Assert.Catch<ArgumentNullException>(() => sut = new CardGame(null));
            Assert.IsNull(sut);
        }

        [Test]
        public void InitializeDeck()
        {
            _sut.InitializeDeck();
        }
    }
}
