using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReplaceText;

namespace UnitTests
{
    [TestClass]
    public class ReplaceTextTests
    {

        [TestMethod]
        public void TestMainSuccess()
        {

            string[] args = new string[] { "ReplaceText.exe", "REPLACEME_OBJ_SERVER_NAME_REPLACEME", "MEL02OBJ", AppDomain.CurrentDomain.BaseDirectory + "\\Data" , "*.txt"};

            PrivateType pt = new PrivateType(typeof(ReplaceText.Program));
            pt.InvokeStatic("Main", new object[] { args });
        }

        [TestMethod]
        public void TestMainFailure()
        {

            string[] args = new string[] { "ReplaceText.exe"};

            PrivateType pt = new PrivateType(typeof(ReplaceText.Program));
            pt.InvokeStatic("Main", new object[] { args });
        }

        [TestMethod]
        public void TestReplaceTextSuccess()
        {

            string filename = AppDomain.CurrentDomain.BaseDirectory + "\\Data\\unitTestReplaceText.txt";

            // Setup File with dummy content
            string sourceContent = "aaa bbb REPLACEME_OBJ_SERVER_NAME_REPLACEME ccc";

            if (File.Exists(filename))
                File.Delete(filename);

            File.WriteAllText(filename, sourceContent);



            string fromText = "REPLACEME_OBJ_SERVER_NAME_REPLACEME";
            string toText = "MEL02OBJ";

            PrivateType pt = new PrivateType(typeof(ReplaceText.Program));
            pt.InvokeStatic("ReplaceText", new object[] { filename, fromText, toText });

            string assertContent = "aaa bbb MEL02OBJ ccc";
            string actualContent = File.ReadAllText(filename);
            Assert.AreEqual(assertContent, actualContent);
        }

        [TestMethod]
        public void TestReplaceTextFail()
        {

            string filename = AppDomain.CurrentDomain.BaseDirectory + "\\Data\\unitTestReplaceText.txt";

            // Setup File with dummy content
            string sourceContent = "aaa bbb REPLACEME_OBJ_SERVER_NAME_REPLACEME ccc";

            if (File.Exists(filename))
                File.Delete(filename);

            File.WriteAllText(filename, sourceContent);

            string fromText = "REPLACEME_OBJ_SERVER_NAME_REPLACEME";
            string toText = "MEL02OBJ";

            PrivateType pt = new PrivateType(typeof(ReplaceText.Program));
            pt.InvokeStatic("ReplaceText", new object[] { filename, fromText, toText });

            string assertContent = "aaa bbb MEL02OBJ ccd";
            string actualContent = File.ReadAllText(filename);
            Assert.AreNotEqual(assertContent, actualContent);
        }
    }
}
