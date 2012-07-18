using com.threetaps.dto.search;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _3taps_CSharp_Client_Test
{
    
    
    /// <summary>
    ///This is a test class for SearchRequestTest and is intended
    ///to contain all SearchRequestTest Unit Tests
    ///</summary>
  [TestClass()]
  public class SearchRequestTest
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
    ///A test for SearchRequest Constructor
    ///</summary>
    [TestMethod()]
    public void SearchRequestConstructorTest()
    {
      SearchRequest target = new SearchRequest();
      Assert.Inconclusive("TODO: Implement code to verify target");
    }

    /// <summary>
    ///A test for getQueryParams
    ///</summary>
    [TestMethod()]
    public void getQueryParamsTest()
    {
      SearchRequest target = new SearchRequest(); // TODO: Initialize to an appropriate value
      Dictionary<string, string> expected = null; // TODO: Initialize to an appropriate value
      Dictionary<string, string> actual;
      actual = target.getQueryParams();
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for annotations
    ///</summary>
    [TestMethod()]
    public void annotationsTest()
    {
      SearchRequest target = new SearchRequest(); // TODO: Initialize to an appropriate value
      Dictionary<string, string> expected = null; // TODO: Initialize to an appropriate value
      Dictionary<string, string> actual;
      target.annotations = expected;
      actual = target.annotations;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for body
    ///</summary>
    [TestMethod()]
    public void bodyTest()
    {
      SearchRequest target = new SearchRequest(); // TODO: Initialize to an appropriate value
      string expected = string.Empty; // TODO: Initialize to an appropriate value
      string actual;
      target.body = expected;
      actual = target.body;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for category
    ///</summary>
    [TestMethod()]
    public void categoryTest()
    {
      SearchRequest target = new SearchRequest(); // TODO: Initialize to an appropriate value
      string expected = string.Empty; // TODO: Initialize to an appropriate value
      string actual;
      target.category = expected;
      actual = target.category;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for end
    ///</summary>
    [TestMethod()]
    public void endTest()
    {
      SearchRequest target = new SearchRequest(); // TODO: Initialize to an appropriate value
      DateTime expected = new DateTime(); // TODO: Initialize to an appropriate value
      DateTime actual;
      target.end = expected;
      actual = target.end;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for externalID
    ///</summary>
    [TestMethod()]
    public void externalIDTest()
    {
      SearchRequest target = new SearchRequest(); // TODO: Initialize to an appropriate value
      string expected = string.Empty; // TODO: Initialize to an appropriate value
      string actual;
      target.externalID = expected;
      actual = target.externalID;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for heading
    ///</summary>
    [TestMethod()]
    public void headingTest()
    {
      SearchRequest target = new SearchRequest(); // TODO: Initialize to an appropriate value
      string expected = string.Empty; // TODO: Initialize to an appropriate value
      string actual;
      target.heading = expected;
      actual = target.heading;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for location
    ///</summary>
    [TestMethod()]
    public void locationTest()
    {
      SearchRequest target = new SearchRequest(); // TODO: Initialize to an appropriate value
      string expected = string.Empty; // TODO: Initialize to an appropriate value
      string actual;
      target.location = expected;
      actual = target.location;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for page
    ///</summary>
    [TestMethod()]
    public void pageTest()
    {
      SearchRequest target = new SearchRequest(); // TODO: Initialize to an appropriate value
      int expected = 0; // TODO: Initialize to an appropriate value
      int actual;
      target.page = expected;
      actual = target.page;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for rpp
    ///</summary>
    [TestMethod()]
    public void rppTest()
    {
      SearchRequest target = new SearchRequest(); // TODO: Initialize to an appropriate value
      int expected = 0; // TODO: Initialize to an appropriate value
      int actual;
      target.rpp = expected;
      actual = target.rpp;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for source
    ///</summary>
    [TestMethod()]
    public void sourceTest()
    {
      SearchRequest target = new SearchRequest(); // TODO: Initialize to an appropriate value
      string expected = string.Empty; // TODO: Initialize to an appropriate value
      string actual;
      target.source = expected;
      actual = target.source;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for start
    ///</summary>
    [TestMethod()]
    public void startTest()
    {
      SearchRequest target = new SearchRequest(); // TODO: Initialize to an appropriate value
      DateTime expected = new DateTime(); // TODO: Initialize to an appropriate value
      DateTime actual;
      target.start = expected;
      actual = target.start;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for text
    ///</summary>
    [TestMethod()]
    public void textTest()
    {
      SearchRequest target = new SearchRequest(); // TODO: Initialize to an appropriate value
      string expected = string.Empty; // TODO: Initialize to an appropriate value
      string actual;
      target.text = expected;
      actual = target.text;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }

    /// <summary>
    ///A test for trustedAnnotations
    ///</summary>
    [TestMethod()]
    public void trustedAnnotationsTest()
    {
      SearchRequest target = new SearchRequest(); // TODO: Initialize to an appropriate value
      Dictionary<string, string> expected = null; // TODO: Initialize to an appropriate value
      Dictionary<string, string> actual;
      target.trustedAnnotations = expected;
      actual = target.trustedAnnotations;
      Assert.AreEqual(expected, actual);
      Assert.Inconclusive("Verify the correctness of this test method.");
    }
  }
}
