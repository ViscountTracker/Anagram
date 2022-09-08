namespace Anagram.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TurnOverWord_Test()
        {
            string input = "f1gh";

            string expected = "hg1f";

            StringManager sm = new StringManager("f1gh dsa2");

            string result = sm.TurnOverWord(expected);

            Assert.AreEqual(input, expected, result);
        }

        [TestMethod]
        public void Reverse_CharIsLetter_CharsSwapped_Test()
        {
            StringManager sm = new StringManager("ab");

            Assert.AreEqual("ba", sm.ChooseWord());
        }

        [TestMethod]
        public void Reverse_CharIsNotLetter_CharsNotSwapped_Test()
        {
            StringManager sm = new StringManager("#1");

            Assert.AreEqual("#1", sm.ChooseWord());
        }

        [TestMethod()]
        public void Null_Test()
        {
            string input = null;

            string expected = null;

            StringManager sm = new StringManager(input);

            var actual = sm.ChooseWord();

            Assert.AreEqual(expected, actual, string.Format("\"{0}\" => \"{1}\" not \"{2}\"", input, actual, expected));
        }

        [TestMethod]
        public void Empty_Test()
        {
            var input = string.Empty;

            var expected = string.Empty;

            StringManager sm = new StringManager(input);

            var actual = sm.ChooseWord();

            Assert.AreEqual(expected, actual, string.Format("\"{0}\" => \"{1}\" not \"{2}\"", input, actual, expected));

        }

        [TestMethod]
        public void LotsOfSpaces_Test()
        {
            var input = "     ";

            var expected = "     ";

            StringManager sm = new StringManager(input);

            var actual = sm.ChooseWord();

            Assert.AreEqual(expected, actual, string.Format("\"{0}\" => \"{1}\" not \"{2}\"", input, actual, expected));
        }

        [TestMethod]
        public void QWER_Test()
        {
            var input = "qwer";

            var expected = "rewq";

            StringManager sm = new StringManager(input);

            var actual = sm.ChooseWord();

            Assert.AreEqual(expected, actual, string.Format("\"{0}\" => \"{1}\" not \"{2}\"", input, actual, expected));
        }

        [TestMethod]
        public void SpaceOneBefore_Test()
        {
            var input = " qwer";

            var expected = " rewq";

            StringManager sm = new StringManager(input);

            var actual = sm.ChooseWord();

            Assert.AreEqual(expected, actual, string.Format("\"{0}\" => \"{1}\" not \"{2}\"", input, actual, expected));
        }

        [TestMethod]
        public void SpaceOneAfterBefore_Test()
        {
            var input = "qwer ";

            var expected = "rewq ";

            StringManager sm = new StringManager(input);

            var actual = sm.ChooseWord();

            Assert.AreEqual(expected, actual, string.Format("\"{0}\" => \"{1}\" not \"{2}\"", input, actual, expected));
        }

        [TestMethod]
        public void TwoWords_Test()
        {
            var input = "qwert asd";

            var expected = "dsa trewq";

            StringManager sm = new StringManager(input);

            var actual = sm.ChooseWord();

            Assert.AreEqual(expected, actual, string.Format("\"{0}\" => \"{1}\" not \"{2}\"", input, actual, expected));
        }

        [TestMethod]
        public void TwoWordsAndLotsOfSpacesBetweenWords_Test()
        {
            var input = "qwert   asdf";

            var expected = "fdsa   trewq";

            StringManager sm = new StringManager(input);

            var actual = sm.ChooseWord();

            Assert.AreEqual(expected, actual, string.Format("\"{0}\" => \"{1}\" not \"{2}\"", input, actual, expected));
        }

        [TestMethod]
        public void WordSwapTestWithCharStayPlace_Test()
        {
            var input = "q@wer asd!f";

            var expected = "r@ewq fds!a";

            StringManager sm = new StringManager(input);

            var actual = sm.ChooseWord();

            Assert.AreEqual(expected, actual, string.Format("\"{0}\" => \"{1}\" not \"{2}\"", input, actual, expected));
        }
    }
}