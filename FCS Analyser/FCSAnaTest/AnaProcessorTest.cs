using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnalyseFile;


namespace FCSAnaTest
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class AnaProcessorTest
    {
        AnaProcessor m_anProc = null;
        Header m_hdObj = null;
 
        public AnaProcessorTest()
        {
            //
            // TODO: Add constructor logic here
            //
            m_anProc = new AnaProcessor();
            m_hdObj = new Header();
            
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TakeAnalysisActionTest()
        {
 
        }

        [TestMethod]
        public void AddComponentMethodTest()
        {
            //
            // TODO: Add test logic	here
            //
            m_hdObj.Install("FCS3.0*********256****1545****1792**202456*******0*******0");
            m_anProc.AddComponent("Header", m_hdObj);
            Assert.AreEqual( 1, m_anProc.GetComponentCount() );
        }
    }
}
