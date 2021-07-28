//-----------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All Rights Reserved.
//-----------------------------------------------------------------------------

using WEX.TestExecution;
using WEX.TestExecution.Markup;
using WEX.Logging.Interop;

namespace TestApp.Managed.UnitTests
{
    [TestClass]
    public class TestClass1
    {
        [TestMethod]
        public void Test1()
        {
            Log.Comment("Hello World!");
			Verify.AreEqual(1, 1);
        }

        [TestMethod]
        public void Test2()
        {
			Log.Comment("Test2");
            Verify.AreEqual(2, 2);
        }
    }
}
