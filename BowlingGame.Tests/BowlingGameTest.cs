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
        [Test]
        public void ItCompiles()
        {
            Assert.True(true);
        }

        [Test]
        public void TestGutterGame()
        {
            var game = new Game();

            for (var i = 0; i < 20; i++)
                game.Roll(0);

            Assert.AreEqual(0, game.Score());

        }
    }
}
