using com.threetaps.dto.search;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _3taps_CSharp_Client_Test
{
    
    
    /// <summary>
    ///This is a test class for BestMatchResponseTest and is intended
    ///to contain all BestMatchResponseTest Unit Tests
    ///</summary>
  [TestClass()]
  public class BestMatchResponseTest
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


    /// <summary>
    ///A test for BestMatchResponse Constructor
    ///</summary>
    [TestMethod()]
    public void BestMatchResponseConstructorTest()
    {
      BestMatchResponse target = new BestMatchResponse();
      Assert.Inconclusive("TODO: Implement code to verify target");
    }

    /// <summary>
    ///A test for category
    ///</summary>
    [TestMethod()]
    public void categoryTest()
    {
      BestMatchResponse target = new BestMatchResponse(); // TODO: Initialize to an appropriate value
      string expected = string.Empty; // TODO: Initialize to an appropriate value
      string actual;
      target.category = expected;
      actual = target.category;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for numResults
    ///</summary>
    [TestMethod()]
    public void numResultsTest()
    {
      BestMatchResponse target = new BestMatchResponse(); // TODO: Initialize to an appropriate value
      int expected = 0; // TODO: Initialize to an appropriate value
      int actual;
      target.numResults = expected;
      actual = target.numResults;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }
  }
}
