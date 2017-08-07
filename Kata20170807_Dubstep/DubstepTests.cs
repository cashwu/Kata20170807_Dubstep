using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170807_Dubstep
{
    [TestClass]
    public class DubstepTests
    {
        [TestMethod]
        public void input_AWUB_should_return_A()
        {
            DubstepSongDecoderShouldBe("A", "AWUB");
        }

        [TestMethod]
        public void input_BWUB_should_return_B()
        {
            DubstepSongDecoderShouldBe("B", "BWUB");
        }

        [TestMethod]
        public void input_AWUBBWUB_should_return_A_B()
        {
            DubstepSongDecoderShouldBe("A B", "AWUBBWUB");
        }

        private static void DubstepSongDecoderShouldBe(string expected, string input)
        {
            var dubstep = new Dubstep();
            var actual = dubstep.SongDecoder(input);
            Assert.AreEqual(expected, actual);
        }
    }

    public class Dubstep
    {
        public string SongDecoder(string input)
        {
            return input.Replace("WUB", " ").Trim();
        }
    }
}
