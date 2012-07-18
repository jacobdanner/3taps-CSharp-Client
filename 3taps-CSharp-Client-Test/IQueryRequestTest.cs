using com.threetaps.dto.search;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _3taps_CSharp_Client_Test
{
    
    
    /// <summary>
    ///This is a test class for IQueryRequestTest and is intended
    ///to contain all IQueryRequestTest Unit Tests
    ///</summary>
  [TestClass()]
  public class IQueryRequestTest
  {


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
    //You can use the following additional attributes as you write your tests:
    //
    //Use ClassInitialize to run code before running the first test in the class
    //[ClassInitialize()]
    //public static void MyClassInitialize(TestContext testContext)
    //{
    //}
    //
    //Use ClassCleanup to run code after all tests in a class have run
    //[ClassCleanup()]
    //public static void MyClassCleanup()
    //{
    //}
    //
    //Use TestInitialize to run code before running each test
    //[TestInitialize()]
    //public void MyTestInitialize()
    //{
    //}
    //
    //Use TestCleanup to run code after each test has run
    //[TestCleanup()]
    //public void MyTestCleanup()
    //{
    //}
    //
    #endregion


    internal virtual IQueryRequest CreateIQueryRequest()
    {
      // TODO: Instantiate an appropriate concrete class.
      IQueryRequest target = null;
      return target;
    }

    /// <summary>
    ///A test for getQueryParams
    ///</summary>
    [TestMethod()]
    public void getQueryParamsTest()
    {
      IQueryRequest target = CreateIQueryRequest(); // TODO: Initialize to an appropriate value
      Dictionary<string, string> expected = null; // TODO: Initialize to an appropriate value
      Dictionary<string, string> actual;
      actual = target.getQueryParams();
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }
  }
}
