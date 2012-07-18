using com.threetaps.client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using com.threetaps.dto.search;

namespace _3taps_CSharp_Client_Test
{
    
    
    /// <summary>
    ///This is a test class for SearchClientTest and is intended
    ///to contain all SearchClientTest Unit Tests
    ///</summary>
  [TestClass()]
  public class SearchClientTest
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
    ///A test for SearchClient Constructor
    ///</summary>
    [TestMethod()]
    public void SearchClientConstructorTest()
    {
      SearchClient target = new SearchClient();
      Assert.Inconclusive("TODO: Implement code to verify target");
    }

    /// <summary>
    ///A test for count
    ///</summary>
    [TestMethod()]
    public void countTest()
    {
      SearchClient target = new SearchClient(); // TODO: Initialize to an appropriate value
      SearchRequest searchRequest = null; // TODO: Initialize to an appropriate value
      int expected = 0; // TODO: Initialize to an appropriate value
      int actual;
      actual = target.count(searchRequest);
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for getInstance
    ///</summary>
    [TestMethod()]
    public void getInstanceTest()
    {
      SearchClient expected = null; // TODO: Initialize to an appropriate value
      SearchClient actual;
      actual = SearchClient.getInstance();
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for range
    ///</summary>
    [TestMethod()]
    public void rangeTest()
    {
      SearchClient target = new SearchClient(); // TODO: Initialize to an appropriate value
      RangeRequest rangeRequest = null; // TODO: Initialize to an appropriate value
      RangeResponse expected = null; // TODO: Initialize to an appropriate value
      RangeResponse actual;
      actual = target.range(rangeRequest);
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for search
    ///</summary>
    [TestMethod()]
    public void searchTest()
    {
      SearchClient target = new SearchClient(); // TODO: Initialize to an appropriate value
      SearchRequest searchRequest = null; // TODO: Initialize to an appropriate value
      SearchResponse expected = null; // TODO: Initialize to an appropriate value
      SearchResponse actual;
      actual = target.search(searchRequest);
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for summary
    ///</summary>
    [TestMethod()]
    public void summaryTest()
    {
      SearchClient target = new SearchClient(); // TODO: Initialize to an appropriate value
      SummaryRequest summaryRequest = null; // TODO: Initialize to an appropriate value
      SummaryResponse expected = null; // TODO: Initialize to an appropriate value
      SummaryResponse actual;
      actual = target.summary(summaryRequest);
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }
  }
}
