using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _1_InputValidationTests
{
    [TestClass]
    public class InputValidationTests
    {
        [TestMethod]
        public void TestName_WithValidString1()
        {
            Form1 frm = new Form1();
            string str = "Kiss Bela";
            Assert.IsTrue(frm.ValidName(str));
            str = "Mr Tom Sawyer Senior";
            Assert.IsTrue(frm.ValidName(str));
        }
        [TestMethod]
        public void TestName_WithInValidString()
        {
            Form1 frm = new Form1();
            string str = "Kiss Béla";
            Assert.IsFalse(frm.ValidName(str));
        }

        [TestMethod]
        public void TestPhone_WithValidString1()
        {
            Form1 frm = new Form1();
            string str = "(555) 123-4567";
            Assert.IsTrue(frm.ValidPhone(str));
            str = "+36 30 214-5489";
            Assert.IsTrue(frm.ValidPhone(str));
        }
        [TestMethod]
        public void TestPhone_WithInValidString()
        {
            Form1 frm = new Form1();
            string str = "99a9-654258";
            Assert.IsFalse(frm.ValidPhone(str));
        }

        [TestMethod]
        public void TestEmail_WithValidString()
        {
            Form1 frm = new Form1();
            string str = "mentor_007@example.com";
            Assert.IsTrue(frm.ValidEmail(str));
            str = "duffy.duck@withperiod.com";
            Assert.IsTrue(frm.ValidEmail(str));
            str = "BugsBunny@looney.toons.io";
            Assert.IsTrue(frm.ValidEmail(str));
            str = "elmer_fudd@long.domain";
            Assert.IsTrue(frm.ValidEmail(str));
        }
        [TestMethod]
        public void TestEmail_WithInValidString()
        {
            Form1 frm = new Form1();
            string str = "missing_at_sign.example.com";
            Assert.IsFalse(frm.ValidEmail(str));
            str = "space in@example.com";
            Assert.IsFalse(frm.ValidEmail(str));
        }
    }
}
