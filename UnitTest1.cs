//todo: Understanding Inheritance or how to connect a test project to the main project
namespace UnitTestProjectAnagram
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_TurnOverWord()
        {
            string start = "f1gh";

            string expected = "hg1f";
            ///???///
            StringManager sm = new StringManager("f1gh dsa2");

            string result = sm.TurnOverWord(expected);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Reverse_CharIsLetter_SharsSwapped()
        {   ///???///
            StringManager sm = new StringManager("ab");
            //String result = sm.Reverse(); Why???
            Assert.AreEqual("ba", sm.ChooseWord());
        }

        [TestMethod]
        public void Reverse_CharIsLetter_SharsSwapped()
        {
            StringManager sm = new StringManager("#1");

            Assert.AreEqual("#1", sm.ChooseWord());
        }

        [TestMethod()]
        public void NullTest()
        {
            string input = null;

            string expected = null;

            StringManager sm = new StringManager(input);

            var actual = sm.ChooseWord();

            Assert.AreEqual(expected, actual, string.Format("\"{0}\" => \"{1}\" not \"{2}\"", input, actual, expected));
        }
    }
}
