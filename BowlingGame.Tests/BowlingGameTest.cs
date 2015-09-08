using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Core;
using NUnit.Framework;

namespace BowlingGame.Tests
{
    [TestFixture]
    public class BowlingGameTest
    {
        private Game game;

        [SetUp]
        public void Init()
        {
            game = new Game();
        }

        private void RollMany(int n, int pins)
        {
            for (var i = 0; i < n; i++)
                game.Roll(pins);
        }

        [Test]
        public void ItCompiles()
        {
            Assert.True(true);
        }

        [Test]
        public void TestGutterGame()
        {
            RollMany(20, 0);

            Assert.AreEqual(0, game.Score());
        }

        [Test]
        public void TestAllOnes()
        {
            RollMany(20, 1);

            Assert.AreEqual(20, game.Score());
        }
    }
}
